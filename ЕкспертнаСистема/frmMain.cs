using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace ЭС
{
    public partial class frmMain : Form
    {
        ExpertSystem tempES = null;
        string tempFile = "";
        bool saved = true;

        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    tempES = new ExpertSystem();
                    tempFile = saveFileDialog1.FileName;
                    if (File.Exists(tempFile))
                        File.Delete(tempFile);
                    File.Create(tempFile);
                    StartES();
                    saved = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FinishES();
            }
        }


        private void FinishES()
        {
            this.Text = "Экспертная система";
            редактированиеToolStripMenuItem.Enabled = false;
            консультацияToolStripMenuItem.Enabled = false;
            сохранитьКакToolStripMenuItem.Enabled = false;
            доменыToolStripMenuItem.Enabled = false;
            переменныеToolStripMenuItem.Enabled = false;
            правилаToolStripMenuItem.Enabled = false;
            пускToolStripMenuItem1.Enabled = false;
            цельToolStripMenuItem1.Enabled = false;
        }

        private void StartES()
        {
            this.Text = "Экспертная система - " + tempFile.Substring(tempFile.LastIndexOf('\\') + 1);
            редактированиеToolStripMenuItem.Enabled = true;
            консультацияToolStripMenuItem.Enabled = true;
            сохранитьКакToolStripMenuItem.Enabled = true;
            доменыToolStripMenuItem.Enabled = true;
            переменныеToolStripMenuItem.Enabled = true;
            правилаToolStripMenuItem.Enabled = true;
            пускToolStripMenuItem1.Enabled = true;
            цельToolStripMenuItem1.Enabled = true;
        }

        private void SaveES(string file)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenWrite(file);
                bf.Serialize(fs, tempES);
                fs.Close();
                MessageBox.Show("Экспертная система успешно сохранена!", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveES(tempFile);
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fs = File.OpenRead(openFileDialog1.FileName);
                    tempES = (ExpertSystem)bf.Deserialize(fs);
                    fs.Close();
                    tempFile = openFileDialog1.FileName;
                    StartES();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FinishES();
            }
        }

        private void доменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDomains f = new frmDomains(tempES);
            if (f.ShowDialog() == DialogResult.OK)
            {
                saved = false;
            }
        }

        private void цельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVariables f = new frmVariables(tempES);
            if (f.ShowDialog() == DialogResult.OK)
            {
                saved = false;
            }
        }

        private void пускToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRules f = new frmRules(tempES);
            if (f.ShowDialog() == DialogResult.OK)
            {
                saved = false;
            }
        }

        private void цельToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGoal fg = new frmGoal(tempES, this);
            fg.ShowDialog();
        }


        private void пускToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StartConsult();
        }


     
        public void StartConsult()
        {
            try
            {
                if (tempES.Goal != null)
                {
                    Fact f = tempES.GoConsult();
                    if (f.Truly == Rightly.Unknown)
                        MessageBox.Show("Не удалось установить истину!");
                    else
                        MessageBox.Show(f.ToString());
                }
            }
            catch (DomainException de)
            {
                MessageBox.Show("Не удалось сделать вывод! Причина: " + de.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неизвестная ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void объяснениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tempES.WorkedRules == null || tempES.WorkedRules.Count <= 0)
            {
                MessageBox.Show("Нет данных");
                return;
            }
            else
            {
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempES = null;
            FinishES();
            saved = true;   
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DialogResult dr = MessageBox.Show("Сохранить перед выходом?", "Выход", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (dr)
                {
                    case DialogResult.Yes:
                        SaveES(tempFile);
                        goto case DialogResult.No;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break; ;
                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveES(saveFileDialog1.FileName);
                tempFile = saveFileDialog1.FileName;
                StartES();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            ShowDialog();
        }
    }
}

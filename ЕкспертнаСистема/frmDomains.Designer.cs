namespace ЭС
{
    partial class frmDomains
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDomains));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDomain = new System.Windows.Forms.Button();
            this.btnDelDomain = new System.Windows.Forms.Button();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.btnDelValue = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.listBox1 = new ЭС.DragListBox();
            this.listBox2 = new ЭС.DragListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Домени";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Значення";
            // 
            // btnAddDomain
            // 
            this.btnAddDomain.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddDomain.Location = new System.Drawing.Point(20, 318);
            this.btnAddDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDomain.Name = "btnAddDomain";
            this.btnAddDomain.Size = new System.Drawing.Size(171, 28);
            this.btnAddDomain.TabIndex = 4;
            this.btnAddDomain.Text = "Додати";
            this.btnAddDomain.UseVisualStyleBackColor = false;
            this.btnAddDomain.Click += new System.EventHandler(this.btnAddDomain_Click);
            // 
            // btnDelDomain
            // 
            this.btnDelDomain.BackColor = System.Drawing.Color.LightCyan;
            this.btnDelDomain.Location = new System.Drawing.Point(199, 318);
            this.btnDelDomain.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelDomain.Name = "btnDelDomain";
            this.btnDelDomain.Size = new System.Drawing.Size(137, 28);
            this.btnDelDomain.TabIndex = 6;
            this.btnDelDomain.Text = "Видалити";
            this.btnDelDomain.UseVisualStyleBackColor = false;
            this.btnDelDomain.Click += new System.EventHandler(this.btnDelDomain_Click);
            // 
            // btnAddValue
            // 
            this.btnAddValue.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddValue.Location = new System.Drawing.Point(375, 318);
            this.btnAddValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(157, 28);
            this.btnAddValue.TabIndex = 7;
            this.btnAddValue.Text = "Додати";
            this.btnAddValue.UseVisualStyleBackColor = false;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // btnDelValue
            // 
            this.btnDelValue.BackColor = System.Drawing.Color.LightCyan;
            this.btnDelValue.Location = new System.Drawing.Point(540, 318);
            this.btnDelValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelValue.Name = "btnDelValue";
            this.btnDelValue.Size = new System.Drawing.Size(151, 28);
            this.btnDelValue.TabIndex = 9;
            this.btnDelValue.Text = "Видалити";
            this.btnDelValue.UseVisualStyleBackColor = false;
            this.btnDelValue.Click += new System.EventHandler(this.btnDelValue_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.LightCyan;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(219, 360);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(276, 28);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Збереження";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.LightCyan;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(20, 33);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 276);
            this.listBox1.TabIndex = 12;
            this.listBox1.AfterDrop += new ЭС.AfterDropEventHandler(this.listBox1_AfterDrop);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.LightCyan;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(375, 33);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(315, 276);
            this.listBox2.TabIndex = 13;
            this.listBox2.AfterDrop += new ЭС.AfterDropEventHandler(this.listBox2_AfterDrop);
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // frmDomains
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(717, 401);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDelValue);
            this.Controls.Add(this.btnAddValue);
            this.Controls.Add(this.btnDelDomain);
            this.Controls.Add(this.btnAddDomain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(735, 448);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(735, 448);
            this.Name = "frmDomains";
            this.Text = "Домени значень";
            this.Load += new System.EventHandler(this.frmDomains_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddDomain;
        private System.Windows.Forms.Button btnDelDomain;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.Button btnDelValue;
        private System.Windows.Forms.Button btnOk;
        private DragListBox listBox1;
        private DragListBox listBox2;
    }
}
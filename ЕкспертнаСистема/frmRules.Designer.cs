namespace ЭС
{
    partial class frmRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRules));
            this.btnAddRule = new System.Windows.Forms.Button();
            this.btnEditRule = new System.Windows.Forms.Button();
            this.btnDeleteRule = new System.Windows.Forms.Button();
            this.btnAddReason = new System.Windows.Forms.Button();
            this.btnDeleteReason = new System.Windows.Forms.Button();
            this.btnModifyResult = new System.Windows.Forms.Button();
            this.btnDeleteResult = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstReasons = new ЭС.DragListBox();
            this.lstResult = new ЭС.DragListBox();
            this.lstRules = new ЭС.DragListBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRule
            // 
            this.btnAddRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRule.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddRule.Location = new System.Drawing.Point(731, 20);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(210, 48);
            this.btnAddRule.TabIndex = 3;
            this.btnAddRule.Text = "Додати";
            this.btnAddRule.UseVisualStyleBackColor = false;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // btnEditRule
            // 
            this.btnEditRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditRule.BackColor = System.Drawing.Color.LightCyan;
            this.btnEditRule.Enabled = false;
            this.btnEditRule.Location = new System.Drawing.Point(731, 72);
            this.btnEditRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditRule.Name = "btnEditRule";
            this.btnEditRule.Size = new System.Drawing.Size(210, 48);
            this.btnEditRule.TabIndex = 4;
            this.btnEditRule.Text = "Змінити";
            this.btnEditRule.UseVisualStyleBackColor = false;
            this.btnEditRule.Click += new System.EventHandler(this.btnEditRule_Click);
            // 
            // btnDeleteRule
            // 
            this.btnDeleteRule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRule.BackColor = System.Drawing.Color.LightCyan;
            this.btnDeleteRule.Enabled = false;
            this.btnDeleteRule.Location = new System.Drawing.Point(731, 124);
            this.btnDeleteRule.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRule.Name = "btnDeleteRule";
            this.btnDeleteRule.Size = new System.Drawing.Size(210, 48);
            this.btnDeleteRule.TabIndex = 5;
            this.btnDeleteRule.Text = "Видалити";
            this.btnDeleteRule.UseVisualStyleBackColor = false;
            this.btnDeleteRule.Click += new System.EventHandler(this.btnDeleteRule_Click);
            // 
            // btnAddReason
            // 
            this.btnAddReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddReason.BackColor = System.Drawing.Color.LightCyan;
            this.btnAddReason.Enabled = false;
            this.btnAddReason.Location = new System.Drawing.Point(286, 32);
            this.btnAddReason.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddReason.Name = "btnAddReason";
            this.btnAddReason.Size = new System.Drawing.Size(96, 42);
            this.btnAddReason.TabIndex = 6;
            this.btnAddReason.Text = "Додати";
            this.btnAddReason.UseVisualStyleBackColor = false;
            this.btnAddReason.Click += new System.EventHandler(this.btnAddReason_Click);
            // 
            // btnDeleteReason
            // 
            this.btnDeleteReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteReason.BackColor = System.Drawing.Color.LightCyan;
            this.btnDeleteReason.Enabled = false;
            this.btnDeleteReason.Location = new System.Drawing.Point(286, 103);
            this.btnDeleteReason.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteReason.Name = "btnDeleteReason";
            this.btnDeleteReason.Size = new System.Drawing.Size(96, 42);
            this.btnDeleteReason.TabIndex = 8;
            this.btnDeleteReason.Text = "Видалити";
            this.btnDeleteReason.UseVisualStyleBackColor = false;
            this.btnDeleteReason.Click += new System.EventHandler(this.btnDeleteReason_Click);
            // 
            // btnModifyResult
            // 
            this.btnModifyResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyResult.BackColor = System.Drawing.Color.LightCyan;
            this.btnModifyResult.Enabled = false;
            this.btnModifyResult.Location = new System.Drawing.Point(275, 32);
            this.btnModifyResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifyResult.Name = "btnModifyResult";
            this.btnModifyResult.Size = new System.Drawing.Size(104, 42);
            this.btnModifyResult.TabIndex = 9;
            this.btnModifyResult.Text = "Додати";
            this.btnModifyResult.UseVisualStyleBackColor = false;
            this.btnModifyResult.Click += new System.EventHandler(this.btnModifyResult_Click);
            // 
            // btnDeleteResult
            // 
            this.btnDeleteResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteResult.BackColor = System.Drawing.Color.LightCyan;
            this.btnDeleteResult.Enabled = false;
            this.btnDeleteResult.Location = new System.Drawing.Point(275, 103);
            this.btnDeleteResult.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteResult.Name = "btnDeleteResult";
            this.btnDeleteResult.Size = new System.Drawing.Size(104, 42);
            this.btnDeleteResult.TabIndex = 10;
            this.btnDeleteResult.Text = "Видалити";
            this.btnDeleteResult.UseVisualStyleBackColor = false;
            this.btnDeleteResult.Click += new System.EventHandler(this.btnDeleteResult_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.LightCyan;
            this.btnOk.Location = new System.Drawing.Point(724, 251);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(217, 97);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Збереження";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(51, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Якщо";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "ТО";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(16, 363);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer1.Panel1.Controls.Add(this.btnAddReason);
            this.splitContainer1.Panel1.Controls.Add(this.lstReasons);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeleteReason);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LightCyan;
            this.splitContainer1.Panel2.CausesValidation = false;
            this.splitContainer1.Panel2.Controls.Add(this.btnDeleteResult);
            this.splitContainer1.Panel2.Controls.Add(this.lstResult);
            this.splitContainer1.Panel2.Controls.Add(this.btnModifyResult);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(791, 162);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 20;
            // 
            // lstReasons
            // 
            this.lstReasons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstReasons.BackColor = System.Drawing.Color.LightCyan;
            this.lstReasons.FormattingEnabled = true;
            this.lstReasons.HorizontalScrollbar = true;
            this.lstReasons.ItemHeight = 16;
            this.lstReasons.Location = new System.Drawing.Point(12, 32);
            this.lstReasons.Margin = new System.Windows.Forms.Padding(4);
            this.lstReasons.Name = "lstReasons";
            this.lstReasons.Size = new System.Drawing.Size(266, 116);
            this.lstReasons.TabIndex = 18;
            this.lstReasons.AfterDrop += new ЭС.AfterDropEventHandler(this.lstReasons_AfterDrop);
            // 
            // lstResult
            // 
            this.lstResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResult.BackColor = System.Drawing.Color.LightCyan;
            this.lstResult.FormattingEnabled = true;
            this.lstResult.HorizontalScrollbar = true;
            this.lstResult.ItemHeight = 16;
            this.lstResult.Location = new System.Drawing.Point(12, 32);
            this.lstResult.Margin = new System.Windows.Forms.Padding(4);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(255, 116);
            this.lstResult.TabIndex = 19;
            // 
            // lstRules
            // 
            this.lstRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRules.BackColor = System.Drawing.Color.LightCyan;
            this.lstRules.FormattingEnabled = true;
            this.lstRules.HorizontalScrollbar = true;
            this.lstRules.ItemHeight = 16;
            this.lstRules.Location = new System.Drawing.Point(16, 15);
            this.lstRules.Margin = new System.Windows.Forms.Padding(4);
            this.lstRules.Name = "lstRules";
            this.lstRules.Size = new System.Drawing.Size(700, 324);
            this.lstRules.TabIndex = 17;
            this.lstRules.AfterDrop += new ЭС.AfterDropEventHandler(this.lstRules_AfterDrop);
            this.lstRules.SelectedIndexChanged += new System.EventHandler(this.lstRules_SelectedIndexChanged);
            // 
            // frmRules
            // 
            this.AcceptButton = this.btnOk;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(954, 576);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lstRules);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDeleteRule);
            this.Controls.Add(this.btnEditRule);
            this.Controls.Add(this.btnAddRule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRules";
            this.Text = "Правила";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button btnEditRule;
        private System.Windows.Forms.Button btnDeleteRule;
        private System.Windows.Forms.Button btnAddReason;
        private System.Windows.Forms.Button btnDeleteReason;
        private System.Windows.Forms.Button btnModifyResult;
        private System.Windows.Forms.Button btnDeleteResult;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DragListBox lstRules;
        private DragListBox lstReasons;
        private DragListBox lstResult;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
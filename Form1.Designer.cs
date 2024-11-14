namespace testopenfile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtBath = new TextBox();
            btnSelect = new Button();
            txtFileName = new TextBox();
            label2 = new Label();
            txtExtFile = new TextBox();
            label3 = new Label();
            ofd = new OpenFileDialog();
            txtText = new TextBox();
            txtSaveFile = new Label();
            btnSave = new Button();
            btnTestFilter = new Button();
            btnCopy = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(4, 45);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "مسار الملف";
            // 
            // txtBath
            // 
            txtBath.Location = new Point(114, 42);
            txtBath.Multiline = true;
            txtBath.Name = "txtBath";
            txtBath.Size = new Size(442, 43);
            txtBath.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.Fuchsia;
            btnSelect.Cursor = Cursors.Hand;
            btnSelect.ForeColor = Color.Red;
            btnSelect.Location = new Point(0, 497);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(139, 38);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "اختر الملف";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // txtFileName
            // 
            txtFileName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFileName.ForeColor = SystemColors.MenuHighlight;
            txtFileName.Location = new Point(114, 101);
            txtFileName.Multiline = true;
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(442, 32);
            txtFileName.TabIndex = 4;
            txtFileName.Text = "اسم الملف المكتوب او المختار";
            txtFileName.TextChanged += txtFileName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(4, 104);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = "اسم الملف";
            // 
            // txtExtFile
            // 
            txtExtFile.Location = new Point(114, 148);
            txtExtFile.Name = "txtExtFile";
            txtExtFile.Size = new Size(442, 32);
            txtExtFile.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(-3, 151);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 5;
            label3.Text = "امتداد الملف";
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // txtText
            // 
            txtText.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtText.ForeColor = SystemColors.MenuHighlight;
            txtText.Location = new Point(114, 186);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(442, 305);
            txtText.TabIndex = 8;
            txtText.Text = " اكتب شيئا لتحفظه فى ملف.txt";
            txtText.TextChanged += textBox1_TextChanged;
            // 
            // txtSaveFile
            // 
            txtSaveFile.AutoSize = true;
            txtSaveFile.ForeColor = SystemColors.Highlight;
            txtSaveFile.Location = new Point(7, 186);
            txtSaveFile.Name = "txtSaveFile";
            txtSaveFile.Size = new Size(101, 25);
            txtSaveFile.TabIndex = 7;
            txtSaveFile.Text = "حفظ الملف";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Fuchsia;
            btnSave.Cursor = Cursors.Hand;
            btnSave.ForeColor = Color.Red;
            btnSave.Location = new Point(169, 497);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 38);
            btnSave.TabIndex = 9;
            btnSave.Text = "حفظ الملف";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnTestFilter
            // 
            btnTestFilter.BackColor = Color.Fuchsia;
            btnTestFilter.Cursor = Cursors.Hand;
            btnTestFilter.ForeColor = Color.Red;
            btnTestFilter.Location = new Point(329, 497);
            btnTestFilter.Name = "btnTestFilter";
            btnTestFilter.Size = new Size(139, 38);
            btnTestFilter.TabIndex = 10;
            btnTestFilter.Text = "فلتر الملفات";
            btnTestFilter.UseVisualStyleBackColor = false;
            btnTestFilter.Click += btnTestFilter_Click;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.Fuchsia;
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.ForeColor = Color.Red;
            btnCopy.Location = new Point(493, 497);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(139, 38);
            btnCopy.TabIndex = 11;
            btnCopy.Text = "انسخ الملف";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(665, 574);
            Controls.Add(btnCopy);
            Controls.Add(btnTestFilter);
            Controls.Add(btnSave);
            Controls.Add(txtText);
            Controls.Add(txtSaveFile);
            Controls.Add(txtExtFile);
            Controls.Add(label3);
            Controls.Add(txtFileName);
            Controls.Add(label2);
            Controls.Add(btnSelect);
            Controls.Add(txtBath);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximumSize = new Size(681, 1000);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "عرض الملفات";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBath;
        private Button btnSelect;
        private TextBox txtFileName;
        private Label label2;
        private TextBox txtExtFile;
        private Label label3;
        private OpenFileDialog ofd;
        private TextBox txtText;
        private Label txtSaveFile;
        private Button btnSave;
        private Button btnTestFilter;
        private Button btnCopy;
    }
}

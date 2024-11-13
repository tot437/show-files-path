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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "مسار الملف";
            // 
            // txtBath
            // 
            txtBath.Location = new Point(117, 12);
            txtBath.Name = "txtBath";
            txtBath.Size = new Size(442, 32);
            txtBath.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(230, 244);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(139, 38);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "اختر الملف";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(117, 59);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(442, 32);
            txtFileName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 62);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 3;
            label2.Text = "اسم الملف";
            // 
            // txtExtFile
            // 
            txtExtFile.Location = new Point(117, 111);
            txtExtFile.Name = "txtExtFile";
            txtExtFile.Size = new Size(442, 32);
            txtExtFile.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 114);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 5;
            label3.Text = "امتداد الملف";
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(571, 294);
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
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "عرض الملفات";
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
    }
}

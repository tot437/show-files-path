namespace testopenfile
{
    using System.IO;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {/*
            ofd.Title = "chose the file now";
            //ofd.InitialDirectory = "D:\\";
            ofd.InitialDirectory =Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.ShowDialog();
            txtBath.Text = ofd.FileName;
            txtFileName.Text = Path.GetFileName(ofd.FileName);
            txtExtFile.Text = Path.GetExtension(ofd.FileName);
            */

            ofd.Multiselect = true;
            ofd.Title = "chose the file now";
            ofd.ShowDialog();
            foreach(string f in ofd.FileNames)
            {
                MessageBox.Show("انسخ مسار الملفات التى حددتها لتستخدمها فى اماكن اخرى");
                MessageBox.Show(f);
            }


        }
    }
}

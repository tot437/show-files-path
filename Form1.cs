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
        {


            /*
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

            foreach (string f in ofd.FileNames)
            {
                MessageBox.Show("انسخ مسار الملفات التى حددتها لتستخدمها فى اماكن اخرى");
                MessageBox.Show(f);


            }







        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog sf2 = new SaveFileDialog();
            sf2.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sf2.Filter = "FilesWorld&Filespdf|*.docx;*.pdf|textFile|*.txt|vedio|*.mp4;*.wmv;*.m4v|imges|*.jpg;*png;*jfif|sound&voise|*.mp3;*.wma;*flac;*.wav;*.3gp|All Files|*.*";
            sf2.ShowDialog();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "قم باختيار مسار حفظ الملف";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            sfd.FileName = txtFileName.Text + ".txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string strPath = sfd.FileName;
                if (Path.GetExtension(sfd.FileName).ToLower() != ".txt")
                {
                    strPath += ".txt";
                }
                StreamWriter sw2 = new StreamWriter(strPath);
                sw2.WriteLine(txtText.Text);
                sw2.Close();


            }



        }

        private void btnTestFilter_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            of.Filter = "FilesWorld&Filespdf|*.docx;*.pdf|textFile|*.txt|vedio|*.mp4;*.wmv;*.m4v|imges|*.jpg;*png;*jfif|sound&voise|*.mp3;*.wma;*flac;*.wav;*.3gp|All Files|*.*";
            of.ShowDialog();
            StreamReader streamReader = new StreamReader(of.FileName);
            MessageBox.Show(streamReader.ReadToEnd());
            MessageBox.Show("هذه الاداة تفتح البيانات النصية فقط .txt!!");
            streamReader.ReadLine();
            streamReader.Close();

            /* SaveFileDialog sf2 = new SaveFileDialog();
             sf2.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
             sf2.Filter = "FilesWorld&Filespdf|*.docx;*.pdf|textFile|*.txt|vedio|*.mp4;*.wmv;*.m4v|imges|*.jpg;*png;*jfif|sound&voise|*.mp3;*.wma;*flac;*.wav;*.3gp|All Files|*.*";
             sf2.ShowDialog();
            */
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd3 = new OpenFileDialog();
            DialogResult dr = ofd3.ShowDialog();

            string f1 = "";
            string f2 = "";
            if (dr == DialogResult.OK)
            {
                if (File.Exists(ofd3.FileName))
                {
                    f1 = ofd3.FileName;

                }
                else
                {
                    MessageBox.Show("file don't found !!!");
                    return;
                }

                SaveFileDialog sfd3 = new SaveFileDialog();
                string fn = Path.GetFileName(f1);
                sfd3.FileName = fn;
                dr = sfd3.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    f2 = sfd3.FileName;
                }
                else
                {
                    MessageBox.Show("Error");
                    return;
                }

                File.Copy(f1, f2);
            }
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

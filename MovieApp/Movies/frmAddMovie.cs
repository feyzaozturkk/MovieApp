using System;
using System.Drawing;
using System.IO;
using Wisej.Web;

namespace MovieApp.Movies
{
    public partial class frmAddMovie : Form
    {
        public frmAddMovie()
        {
            InitializeComponent();
        }
        string sFileUploadPath;
        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void upload_image_Uploaded(object sender, UploadedEventArgs e)
        {
            LoadFile(e.Files);
            SaveStreamAsFile(sFileUploadPath, e.Files[0].InputStream, e.Files[0].FileName);
        }

        void SaveStreamAsFile(string filePath, Stream inputStream, string fileName)
        {
            DirectoryInfo info = new DirectoryInfo(filePath);
            if (!info.Exists)
            {
                info.Create();
            }
            string path = Path.Combine(filePath, fileName);
            using (FileStream outputFileStream = new FileStream(path, FileMode.Create))
            {
                inputStream.CopyTo(outputFileStream);
            }
        }

        private void LoadFile(System.Web.HttpFileCollection files)
        {
            if (files == null)
                return;

            if (files.Count == 0)
            {
                this.pictureBox1.Image = null;
            }
            else
            {
                this.pictureBox1.Image = GetImageFromStream(files[0].InputStream);
            }
        }
        private Image GetImageFromStream(System.IO.Stream stream)
        {
            System.IO.MemoryStream mem = new System.IO.MemoryStream();
            stream.CopyTo(mem, 1024);
            mem.Position = 0;
            return Image.FromStream(mem);
        }

        private void frmAddMovie_Load(object sender, EventArgs e)
        {
            {
                string sDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                sFileUploadPath = sDirectory.Replace("\\bin", string.Empty) + "\\Uploads\\";
            }
        }
    }
}

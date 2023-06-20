namespace MovieApp.Movies
{
    partial class MovieCardControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Wisej Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.picturebx_image = new Wisej.Web.PictureBox();
            this.label_MovieName = new Wisej.Web.Label();
            this.label_Year = new Wisej.Web.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebx_image)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromName("@table-row-background-odd");
            this.flowLayoutPanel1.Controls.Add(this.picturebx_image);
            this.flowLayoutPanel1.Controls.Add(this.label_MovieName);
            this.flowLayoutPanel1.Controls.Add(this.label_Year);
            this.flowLayoutPanel1.CssStyle = "border-radius: 5px;\r\nborder: 1px solid #ddd;";
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(30);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(199, 213);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // picturebx_image
            // 
            this.picturebx_image.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flowLayoutPanel1.SetFillWeight(this.picturebx_image, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.picturebx_image, true);
            this.picturebx_image.Location = new System.Drawing.Point(33, 33);
            this.picturebx_image.Name = "picturebx_image";
            this.picturebx_image.Size = new System.Drawing.Size(133, 100);
            this.picturebx_image.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            // 
            // label_MovieName
            // 
            this.flowLayoutPanel1.SetFillWeight(this.label_MovieName, 1);
            this.flowLayoutPanel1.SetFlowBreak(this.label_MovieName, true);
            this.label_MovieName.Location = new System.Drawing.Point(33, 139);
            this.label_MovieName.Name = "label_MovieName";
            this.label_MovieName.Size = new System.Drawing.Size(133, 18);
            this.label_MovieName.TabIndex = 1;
            this.label_MovieName.Text = "label";
            // 
            // label_Year
            // 
            this.flowLayoutPanel1.SetFillWeight(this.label_Year, 1);
            this.label_Year.Location = new System.Drawing.Point(33, 163);
            this.label_Year.Name = "label_Year";
            this.label_Year.Size = new System.Drawing.Size(133, 18);
            this.label_Year.TabIndex = 2;
            this.label_Year.Text = "label";
            // 
            // MovieCardControl
            // 
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MovieCardControl";
            this.Size = new System.Drawing.Size(199, 213);
            this.Load += new System.EventHandler(this.MovieCardControl_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturebx_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.PictureBox picturebx_image;
        private Wisej.Web.Label label_MovieName;
        private Wisej.Web.Label label_Year;
    }
}

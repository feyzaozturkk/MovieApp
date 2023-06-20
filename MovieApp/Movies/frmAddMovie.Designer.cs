namespace MovieApp.Movies
{
    partial class frmAddMovie
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
            this.label1 = new Wisej.Web.Label();
            this.pictureBox1 = new Wisej.Web.PictureBox();
            this.upload_image = new Wisej.Web.Upload();
            this.txt_MovieName = new Wisej.Web.TextBox();
            this.txt_Description = new Wisej.Web.TextBox();
            this.txt_Year = new Wisej.Web.TextBox();
            this.btn_Save = new Wisej.Web.Button();
            this.contextMenu1 = new Wisej.Web.ContextMenu();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.upload_image);
            this.flowLayoutPanel1.Controls.Add(this.txt_MovieName);
            this.flowLayoutPanel1.Controls.Add(this.txt_Description);
            this.flowLayoutPanel1.Controls.Add(this.txt_Year);
            this.flowLayoutPanel1.Controls.Add(this.btn_Save);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(30);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(609, 555);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.flowLayoutPanel1.SetFlowBreak(this.label1, true);
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Margin = new Wisej.Web.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add movie cover photo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.flowLayoutPanel1.SetFlowBreak(this.pictureBox1, true);
            this.pictureBox1.Location = new System.Drawing.Point(40, 78);
            this.pictureBox1.Margin = new Wisej.Web.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 89);
            this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.StretchImage;
            // 
            // upload_image
            // 
            this.upload_image.HideValue = true;
            this.upload_image.Location = new System.Drawing.Point(33, 180);
            this.upload_image.Name = "upload_image";
            this.upload_image.Size = new System.Drawing.Size(177, 30);
            this.upload_image.TabIndex = 7;
            this.upload_image.Text = "Upload";
            this.upload_image.Uploaded += new Wisej.Web.UploadedEventHandler(this.upload_image_Uploaded);
            // 
            // txt_MovieName
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.txt_MovieName, true);
            this.txt_MovieName.LabelText = "Movie Name";
            this.txt_MovieName.Location = new System.Drawing.Point(40, 223);
            this.txt_MovieName.Margin = new Wisej.Web.Padding(10);
            this.txt_MovieName.Name = "txt_MovieName";
            this.txt_MovieName.Size = new System.Drawing.Size(351, 53);
            this.txt_MovieName.TabIndex = 3;
            // 
            // txt_Description
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.txt_Description, true);
            this.txt_Description.LabelText = "Description";
            this.txt_Description.Location = new System.Drawing.Point(40, 296);
            this.txt_Description.Margin = new Wisej.Web.Padding(10);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(360, 110);
            this.txt_Description.TabIndex = 4;
            // 
            // txt_Year
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.txt_Year, true);
            this.txt_Year.LabelText = "Year";
            this.txt_Year.Location = new System.Drawing.Point(40, 426);
            this.txt_Year.Margin = new Wisej.Web.Padding(10);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(150, 53);
            this.txt_Year.TabIndex = 5;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromName("@focusShadow");
            this.btn_Save.Font = new System.Drawing.Font("@menu", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_Save.Location = new System.Drawing.Point(430, 492);
            this.btn_Save.Margin = new Wisej.Web.Padding(400, 3, 3, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(113, 37);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextImageRelation = Wisej.Web.TextImageRelation.Overlay;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.Name = "contextMenu1";
            // 
            // frmAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 555);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmAddMovie";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.frmAddMovie_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.Label label1;
        private Wisej.Web.PictureBox pictureBox1;
        private Wisej.Web.TextBox txt_MovieName;
        private Wisej.Web.ContextMenu contextMenu1;
        private Wisej.Web.TextBox txt_Description;
        private Wisej.Web.TextBox txt_Year;
        private Wisej.Web.Button btn_Save;
        private Wisej.Web.Upload upload_image;
    }
}
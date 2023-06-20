namespace MovieApp.Movies
{
    partial class frmMovies
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
            Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
            this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
            this.txtbox_Search = new Wisej.Web.TextBox();
            this.cmbBox_Categories = new Wisej.Web.ComboBox();
            this.btn_AddMovie = new Wisej.Web.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtbox_Search);
            this.flowLayoutPanel1.Controls.Add(this.cmbBox_Categories);
            this.flowLayoutPanel1.Controls.Add(this.btn_AddMovie);
            this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new Wisej.Web.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1048, 781);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // txtbox_Search
            // 
            this.txtbox_Search.BackColor = System.Drawing.Color.FromName("@tabHighlight");
            this.txtbox_Search.ForeColor = System.Drawing.Color.FromName("@windowText");
            this.txtbox_Search.Location = new System.Drawing.Point(13, 13);
            this.txtbox_Search.Name = "txtbox_Search";
            this.txtbox_Search.Size = new System.Drawing.Size(266, 30);
            this.txtbox_Search.TabIndex = 0;
            componentTool2.ImageSource = "icon-search";
            componentTool2.Name = "Search";
            this.txtbox_Search.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
            this.txtbox_Search.Watermark = "Search";
            // 
            // cmbBox_Categories
            // 
            this.cmbBox_Categories.DisplayMember = "CategoryName";
            this.cmbBox_Categories.Location = new System.Drawing.Point(285, 13);
            this.cmbBox_Categories.Name = "cmbBox_Categories";
            this.cmbBox_Categories.Size = new System.Drawing.Size(208, 30);
            this.cmbBox_Categories.TabIndex = 1;
            this.cmbBox_Categories.ValueMember = "Id";
            this.cmbBox_Categories.Watermark = "Categories";
            // 
            // btn_AddMovie
            // 
            this.btn_AddMovie.BackColor = System.Drawing.Color.FromName("@focusFrame");
            this.flowLayoutPanel1.SetFlowBreak(this.btn_AddMovie, true);
            this.btn_AddMovie.Font = new System.Drawing.Font("@menu", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btn_AddMovie.ForeColor = System.Drawing.Color.FromName("@appWorkspace");
            this.btn_AddMovie.Location = new System.Drawing.Point(499, 13);
            this.btn_AddMovie.Name = "btn_AddMovie";
            this.btn_AddMovie.Size = new System.Drawing.Size(156, 30);
            this.btn_AddMovie.TabIndex = 2;
            this.btn_AddMovie.Text = "Add Movie";
            this.btn_AddMovie.Click += new System.EventHandler(this.btn_AddMovie_Click);
            // 
            // frmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 781);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
            this.Name = "frmMovies";
            this.Text = "frmMovies";
            this.WindowState = Wisej.Web.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMovies_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
        private Wisej.Web.TextBox txtbox_Search;
        private Wisej.Web.ComboBox cmbBox_Categories;
        private Wisej.Web.Button btn_AddMovie;
    }
}
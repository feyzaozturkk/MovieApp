using System;
using Wisej.Web;

namespace MovieApp.Movies
{
    public partial class MovieCardControl : Wisej.Web.UserControl
    {
        public string ImagePath;
        public string MovieName;
        public int Year;

        public MovieCardControl()
        {
            InitializeComponent();
        }

        private void MovieCardControl_Load(object sender, EventArgs e)
        {
            label_Year.Text = Year.ToString();
            label_MovieName.Text = MovieName?.ToString();
            picturebx_image.ImageSource = ImagePath?.ToString();
        }
    }
}

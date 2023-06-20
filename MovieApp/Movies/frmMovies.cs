using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace MovieApp.Movies
{
    public partial class frmMovies : Form
    {
        public frmMovies()
        {
            InitializeComponent();
        }

        private void frmMovies_Load(object sender, EventArgs e)
        {
            MovieDbContext db = new MovieDbContext(); // Context sınıfınfan db nestesi oluşturur.
            List<Categories.Category> listCategory = db.Categories.ToList();  // Veritabanındaki tüm kategorileri listeye atar.
            cmbBox_Categories.DataSource = listCategory;  // listeyi combobox' ın  datasource' una bağlar  


            List<Movie> MovieList = db.Movies.ToList();
            for (int i = 0; i < MovieList.Count; i++)
            {
                MovieCardControl movieCardControl = new MovieCardControl();
                movieCardControl.Year = MovieList[i].MovieYear;
                movieCardControl.MovieName = MovieList[i].MovieName;
                movieCardControl.ImagePath = "https://image.tmdb.org/t/p/original/" + MovieList[i].MoviePicture;
                flowLayoutPanel1.Controls.Add(movieCardControl);
            }
        }

        private void btn_AddMovie_Click(object sender, EventArgs e)
        {
            frmAddMovie frmAddMovie = new frmAddMovie();
            frmAddMovie.Show();
        }
    }
}

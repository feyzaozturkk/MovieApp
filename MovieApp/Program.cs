using MovieApp.Movies;
using RestSharp;
using System;
using System.Data.Entity;
using System.Text.Json;
using System.Text.Json.Nodes;
using RestSharp.Authenticators;
using Wisej.Web;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MovieApp
{
    static class Program
    {

        static async void Main()
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    Random rnd = new Random();
            //    int RastgeleSayi1 = rnd.Next(0, 1000);

            //    var client = new HttpClient();

            //    client.DefaultRequestHeaders.Add("accept", "application/json");
            //    client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiJhZjBhYzUwNTIxN2RlY2I4Y2FhODhiNmQwOWFjZGQxOCIsInN1YiI6IjY0OTAzOWMxNDJiZjAxMDEwMWJmYWNkOSIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.c8mZXd5qt_tN3fOjyAZKf_o92lOEJRu8q_oOydMJFGA");
            //    var result = await client.GetAsync("https://api.themoviedb.org/3/movie/" + RastgeleSayi1.ToString());
            //    var resp = await result.Content.ReadAsStringAsync();
            //    Console.WriteLine(resp);
            //    dynamic json = JsonConvert.DeserializeObject(resp);


            //    using (var ctx = new MovieDbContext())
            //    {
            //        var movie = new Movie()
            //        {
            //            MovieName = json.title,
            //            MoviePicture = json.poster_path,
            //            MovieYear = Convert.ToDateTime(json.release_date).Year,
            //            Description = json.overview

            //        };

            //        ctx.Movies.Add(movie);
            //        ctx.SaveChanges();

            //    }

            //}

            frmMovies window = new frmMovies();
            window.Show();
        }


    }
}
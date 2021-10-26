using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp2.Models
{
    public class MovieRepository : IMovieRepository
    {
        private static List<Movie> _movies;
        public MovieRepository()
        {
            _movies = new List<Movie>(){
                new Movie() { Id = 1, Name = "Whiplash", Year = 2014 , Director = "Damien Chazelle" },
                new Movie() { Id = 2, Name = "Pulp Fiction", Year = 1994 , Director = "Quentin Tarantino" },
                new Movie() { Id = 3, Name = "The Good, the Bad and the Ugly", Year = 1966 , Director = "Sergio Leone" },
                new Movie() { Id = 4, Name = "12 Angry Men", Year = 1957 , Director = "Sidney Lumet" },
                new Movie() { Id = 5, Name = "Eternal Sunshine of the Spotless Mind", Year = 2004 , Director = "Michel Gondry" },
                new Movie() { Id = 6, Name = "One Flew Over the Cuckoo's Nest", Year = 1975 , Director = "Milos Forman" },
                new Movie() { Id = 7, Name = "The Green Mile", Year = 1999 , Director = "Frank Darabont" },
                new Movie() { Id = 8, Name = "Life Is Beautiful", Year = 1997 , Director = "Roberto Benigni" },
                new Movie() { Id = 9, Name = "Amélie", Year = 2001 , Director = "Jean-Pierre Jeunet" },
                new Movie() { Id = 10, Name = "Léon: The Professional", Year = 1994 , Director = "Luc Besson" }

            };
        }

        public IEnumerable<Movie> GetAll()
        {
            return _movies;
        }

        public bool DeleteById(int? id)
        {
            var m = _movies.First(m => m.Id == id);
            return _movies.Remove(m);
        }
        public void Create(string name, int year, string director)
        {
            _movies.Add(new Movie() { Id = _movies.Count() + 1, Name = name, Year = year, Director = director });
        }
        public Movie GetById(int id)
        {
            return _movies.First(e => e.Id == id);
        }
        public void Update(int updateableId, string updatedName, int updatableYear, string updatableDirector)
        {
            var m = _movies.First(m => m.Id == updateableId);
            m.Name = updatedName;
            m.Year = updatableYear;
            m.Director = updatableDirector;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp2.Models
{
    public class MovieRepository
    {
        private static List<Movie> _movies;
        public MovieRepository()
        {
            _movies = new List<Movie>(){
                new Movie() { Id = 1, Name = "Kill Bill: Vol. 1", Year = 2003 , Director = "Quentin Tarantino" },
                new Movie() { Id = 2, Name = "Pulp Fiction", Year = 1994 , Director = "Quentin Tarantino" },
                new Movie() { Id = 3, Name = "The Good, the Bad and the Ugly", Year = 1966 , Director = "Sergio Leone" },
                new Movie() { Id = 4, Name = "12 Angry Men", Year = 1957 , Director = "Sidney Lumet" }
            };
        }

        public List<Movie> GetAll()
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

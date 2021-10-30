using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp2.Models
{
    public class MovieDbRepository : IMovieRepository
    {
        private AppDbContext _dbContext;
        public MovieDbRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Movie> GetAll()
        {
            return _dbContext.Movies.ToList();
        }
        public Movie GetById(int id)
        {
            return _dbContext.Movies.Find(id);
        }
        public bool DeleteById(int id)
        {
            var e = _dbContext.Movies.Find(id);
            _dbContext.Movies.Remove(e);
            return _dbContext.SaveChanges() == 1 ? true : false; //NES EFC daro du query, t.p. Update, Create
        }
        public void Create(string name, int year, string director)
        {
            _dbContext.Movies.Add(new Movie() { Name = name , Year = year, Director = director });
            _dbContext.SaveChanges();
        }
        public void Update(int updateableId, string updatedName, int updatedYear, string updatedDirector)
        {
            var m = _dbContext.Movies.Find(updateableId);
            m.Name = updatedName;
            m.Year = updatedYear;
            m.Director = updatedDirector;
            _dbContext.SaveChanges();
        }

    }
    }

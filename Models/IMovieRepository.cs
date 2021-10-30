using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp2.Models
{
    public interface IMovieRepository
    {

        IEnumerable<Movie> GetAll();

        bool DeleteById(int id);

        void Create(string name, int year, string director);

        Movie GetById(int id);

        void Update(int updateableId, string updatedName, int updatableYear, string updatableDirector);

    }

}

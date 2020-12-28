using MoviesAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Services
{
    public class InMemoryRepository: IRepository
    {
        private List<Genre> _genres;
        public InMemoryRepository()
        {
            _genres = new List<Genre>()
            {
                new Genre() 
                {
                    Id = 0,
                    Name = "Action"
                },
                new Genre()
                {
                    Id = 1,
                    Name = "Romance"
                }
            };
        }

        public List<Genre> GetAllGenres()
        {
            return _genres;
        }

        public Genre GetGenreById(int id) 
        {
            return _genres.FirstOrDefault<Genre>(genre => genre.Id == id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entities;
using MoviesAPI.Services;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    public class GenresController: ControllerBase
    {
        private readonly IRepository repository;

        public GenresController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("/allGenres")]
        public ActionResult<List<Genre>> Get() 
        {
            return repository.GetAllGenres();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Genre> GetGenreById(int id)
        {
            var genre = repository.GetGenreById(id);

            if (genre == null)
            {
                return NotFound();
            }

            return genre;
        }
    }
}
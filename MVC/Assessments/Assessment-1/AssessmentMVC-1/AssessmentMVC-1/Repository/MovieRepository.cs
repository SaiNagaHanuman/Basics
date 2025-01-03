﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssessmentMVC_1.Models;

namespace AssessmentMVC_1.Repository
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAllMoviesByYear(int year);

        IEnumerable<Movie> GetAll();

        Movie GetById(int id);
        void Create(Movie movie);
        void Edit(Movie movie);
    }
}
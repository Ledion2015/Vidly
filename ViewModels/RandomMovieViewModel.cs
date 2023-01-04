﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestVidly.Models;

namespace TestVidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movies{ get; set; }
        public List<Customer> Customers { get; set; }
    }
}
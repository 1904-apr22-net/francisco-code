﻿using System;
using System.Collections.Generic;

namespace EfIntro.DataAccess
{
    public partial class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
    }
}

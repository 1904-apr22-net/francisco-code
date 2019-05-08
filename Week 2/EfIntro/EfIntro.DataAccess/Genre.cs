using System;
using System.Collections.Generic;

namespace EfIntro.DataAccess
{
    public partial class Genre
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
        public DateTime DateModified { get; set; }
        public bool? Active { get; set; }
    }
}

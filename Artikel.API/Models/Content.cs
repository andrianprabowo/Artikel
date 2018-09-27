using System;
using System.Collections.Generic;

namespace Artikel.API.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string IsiArtikel { get; set; }
        public DateTime Created { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace Northwind.Entites
{
    public partial class Kategory
    {
        public Kategory()
        {
            Urunlers = new HashSet<Urunler>();
        }

        public int Id { get; set; }
        public string? KategoryAdi { get; set; }
        public int? UstId { get; set; }

        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}

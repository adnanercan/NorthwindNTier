using System;
using System.Collections.Generic;

namespace Northwind.Entites
{
    public partial class Birimler
    {
        public Birimler()
        {
            Urunlers = new HashSet<Urunler>();
        }

        public int Id { get; set; }
        public string? BirimAd { get; set; }
        public string? Aciklama { get; set; }

        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}

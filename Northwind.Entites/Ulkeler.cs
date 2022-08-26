using System;
using System.Collections.Generic;

namespace Northwind.Entites
{
    public partial class Ulkeler
    {
        public int UlkeId { get; set; }
        public string IkiliKod { get; set; } = null!;
        public string UcluKod { get; set; } = null!;
        public string UlkeAdi { get; set; } = null!;
        public string TelKodu { get; set; } = null!;
    }
}

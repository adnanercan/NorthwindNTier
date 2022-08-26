using System;
using System.Collections.Generic;

namespace Northwind.Entites
{
    public partial class Urunler
    {
        public int Id { get; set; }
        public string? UrunAd { get; set; }
        public decimal? Fiyat { get; set; }
        public string? Aciklama { get; set; }
        public double? Adet { get; set; }
        public int? KategoryId { get; set; }
        public int? BirimId { get; set; }

        public virtual Birimler? Birim { get; set; }
        public virtual Kategory? Kategory { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Northwind.Entites
{
    public partial class SemtMah
    {
        public int SemtMahId { get; set; }
        public string SemtAdi { get; set; } = null!;
        public string MahalleAdi { get; set; } = null!;
        public string PostaKodu { get; set; } = null!;
        public int IlceId { get; set; }

        public virtual Ilceler Ilce { get; set; } = null!;
    }
}

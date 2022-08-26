using System;
using System.Collections.Generic;

namespace Northwind.Entites
{
    public partial class Ilceler
    {
        public Ilceler()
        {
            SemtMahs = new HashSet<SemtMah>();
        }

        public int IlceId { get; set; }
        public int SehirId { get; set; }
        public string IlceAdi { get; set; } = null!;
        public string SehirAdi { get; set; } = null!;

        public virtual Sehirler Sehir { get; set; } = null!;
        public virtual ICollection<SemtMah> SemtMahs { get; set; }
    }
}

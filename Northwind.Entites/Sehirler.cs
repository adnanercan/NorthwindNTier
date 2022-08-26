using System;
using System.Collections.Generic;

namespace Northwind.Entites
{
    public partial class Sehirler
    {
        public Sehirler()
        {
            Ilcelers = new HashSet<Ilceler>();
        }

        public int SehirId { get; set; }
        public string SehirAdi { get; set; } = null!;
        public byte PlakaNo { get; set; }
        public int TelefonKodu { get; set; }
        public int RowNumber { get; set; }

        public virtual ICollection<Ilceler> Ilcelers { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class GblEMRQcGroup
    {
        public GblEMRQcGroup()
        {
            this.GblEMRQcItems = new List<GblEMRQcItem>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<short> Point { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public string Memo { get; set; }
        public virtual ICollection<GblEMRQcItem> GblEMRQcItems { get; set; }
    }
}

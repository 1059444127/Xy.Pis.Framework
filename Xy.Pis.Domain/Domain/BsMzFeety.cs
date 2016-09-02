using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsMzFeety
    {
        public BsMzFeety()
        {
            this.BsItems = new List<BsItem>();
            this.OuInvoiceDtls = new List<OuInvoiceDtl>();
            this.OuInvoiceFeetySums = new List<OuInvoiceFeetySum>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> InvItemId { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public Nullable<int> LocationId { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsInvMzItem BsInvMzItem { get; set; }
        public virtual ICollection<BsItem> BsItems { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual ICollection<OuInvoiceDtl> OuInvoiceDtls { get; set; }
        public virtual ICollection<OuInvoiceFeetySum> OuInvoiceFeetySums { get; set; }
    }
}

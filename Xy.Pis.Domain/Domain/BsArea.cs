using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsArea
    {
        public BsArea()
        {
            this.BsAreaPoliceStations = new List<BsAreaPoliceStation>();
            this.BsHospitals = new List<BsHospital>();
            this.HuStockDtls = new List<HuStockDtl>();
            this.RdNewBirths = new List<RdNewBirth>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public string PostCode { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsAreaRegion BsAreaRegion { get; set; }
        public virtual ICollection<BsAreaPoliceStation> BsAreaPoliceStations { get; set; }
        public virtual ICollection<BsHospital> BsHospitals { get; set; }
        public virtual ICollection<HuStockDtl> HuStockDtls { get; set; }
        public virtual ICollection<RdNewBirth> RdNewBirths { get; set; }
    }
}

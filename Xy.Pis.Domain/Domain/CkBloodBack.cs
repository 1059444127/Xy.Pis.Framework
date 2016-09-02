using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class CkBloodBack
    {
        public int ID { get; set; }
        public string RecNo { get; set; }
        public int LabId { get; set; }
        public int BloodId { get; set; }
        public Nullable<System.DateTime> BackTime { get; set; }
        public Nullable<int> BackOperId { get; set; }
        public string BackReason { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual CkBdBank CkBdBank { get; set; }
        public virtual CkLab CkLab { get; set; }
    }
}

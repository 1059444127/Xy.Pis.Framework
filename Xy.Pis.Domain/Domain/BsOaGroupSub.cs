using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BsOaGroupSub
    {
        public int ID { get; set; }
        public int MainId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsOaGroup BsOaGroup { get; set; }
    }
}

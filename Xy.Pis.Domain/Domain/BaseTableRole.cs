using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class BaseTableRole
    {
        public int ID { get; set; }
        public Nullable<int> BaseTableId { get; set; }
        public Nullable<int> RoleId { get; set; }
        public virtual GblBaseTableItem GblBaseTableItem { get; set; }
        public virtual GblRole GblRole { get; set; }
    }
}

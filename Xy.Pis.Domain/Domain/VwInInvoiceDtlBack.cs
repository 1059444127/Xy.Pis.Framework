using System;
using System.Collections.Generic;

namespace Xy.Pis.Domain
{
    public partial class VwInInvoiceDtlBack
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public Nullable<short> LsGroupType { get; set; }
        public string Code { get; set; }
        public Nullable<int> GroupMainId { get; set; }
        public string GroupMainName { get; set; }
        public Nullable<int> GroupSubId { get; set; }
        public string GroupSubName { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public Nullable<bool> IsSpecSum { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<bool> IsRpForbid { get; set; }
        public Nullable<bool> IsChildAdd { get; set; }
        public Nullable<bool> IsBedFee { get; set; }
        public Nullable<bool> IsOpsAdd { get; set; }
        public int LocationId { get; set; }
        public string ExecLocName { get; set; }
        public short LsMarkType { get; set; }
        public decimal Totality { get; set; }
        public decimal PriceIn { get; set; }
        public int UnitId { get; set; }
        public string UnitIdName { get; set; }
        public decimal DiscIn { get; set; }
        public decimal DiscSelf { get; set; }
        public bool IsModiDisc { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountPay { get; set; }
        public Nullable<decimal> AmountTally { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountFact { get; set; }
        public bool IsPay { get; set; }
        public bool IsManual { get; set; }
        public short LsPerform { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<int> CancelId { get; set; }
        public Nullable<short> LsReportType { get; set; }
        public string FeeHsName { get; set; }
        public Nullable<int> FeeHsId { get; set; }
        public string FeetyName { get; set; }
        public int FeeId { get; set; }
        public string InvItemName { get; set; }
        public int InvItemId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string OrderLocationName { get; set; }
        public int ExecLocId { get; set; }
        public string ExecOperName { get; set; }
        public int ExecOperId { get; set; }
        public System.DateTime RegOperTime { get; set; }
        public int RegOperId { get; set; }
        public int DoctorId { get; set; }
        public string OrderDoctorName { get; set; }
        public Nullable<int> LimitGroupId { get; set; }
        public string LimitGroupName { get; set; }
        public Nullable<decimal> LimitFee { get; set; }
        public Nullable<int> InvoId { get; set; }
        public int HospId { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> PatientDoctorId { get; set; }
        public string PatientDoctorName { get; set; }
        public Nullable<int> PatientLocationId { get; set; }
        public string PatientLocationName { get; set; }
        public string HospNo { get; set; }
        public Nullable<int> NTime { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<short> LsInStatus { get; set; }
        public string LsInStatusName { get; set; }
        public string CardNo { get; set; }
        public string InPatNo { get; set; }
        public Nullable<int> PatID { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string SexName { get; set; }
        public string BedName { get; set; }
        public Nullable<int> BedId { get; set; }
        public Nullable<bool> IsAdd { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<short> LsGFPatType { get; set; }
        public string LsGFPatTypeName { get; set; }
        public Nullable<int> TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public Nullable<bool> IsGf { get; set; }
        public Nullable<bool> IsYb { get; set; }
        public Nullable<int> SpecialityId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<bool> IsMental { get; set; }
        public Nullable<bool> IsExpen { get; set; }
        public string FormName { get; set; }
        public Nullable<bool> IsInject { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class PsApplyReportMap : EntityTypeConfiguration<PsApplyReport>
    {
        public PsApplyReportMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ApplyNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.Equipment)
                .HasMaxLength(50);

            this.Property(t => t.ApplyMemo)
                .HasMaxLength(500);

            this.Property(t => t.CheckBody)
                .HasMaxLength(100);

            this.Property(t => t.CheckParm)
                .HasMaxLength(500);

            this.Property(t => t.CheckDesc)
                .HasMaxLength(1000);

            this.Property(t => t.CheckResult)
                .HasMaxLength(500);

            this.Property(t => t.CheckAdvice)
                .HasMaxLength(200);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.Summary)
                .HasMaxLength(1000);

            this.Property(t => t.Diagnose)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("PsApplyReport");
            this.Property(t => t.ApplyNo).HasColumnName("ApplyNo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.CancelTime).HasColumnName("CancelTime");
            this.Property(t => t.CancelOperId).HasColumnName("CancelOperId");
            this.Property(t => t.XType).HasColumnName("XType");
            this.Property(t => t.IsPre).HasColumnName("IsPre");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.IsCharged).HasColumnName("IsCharged");
            this.Property(t => t.IsConfirm).HasColumnName("IsConfirm");
            this.Property(t => t.ConfirmTime).HasColumnName("ConfirmTime");
            this.Property(t => t.Equipment).HasColumnName("Equipment");
            this.Property(t => t.ApplyMemo).HasColumnName("ApplyMemo");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.CheckTime).HasColumnName("CheckTime");
            this.Property(t => t.CheckOperId).HasColumnName("CheckOperId");
            this.Property(t => t.ReportTime).HasColumnName("ReportTime");
            this.Property(t => t.ReportOperId).HasColumnName("ReportOperId");
            this.Property(t => t.AuthOperId).HasColumnName("AuthOperId");
            this.Property(t => t.CheckBody).HasColumnName("CheckBody");
            this.Property(t => t.CheckParm).HasColumnName("CheckParm");
            this.Property(t => t.CheckDesc).HasColumnName("CheckDesc");
            this.Property(t => t.CheckResult).HasColumnName("CheckResult");
            this.Property(t => t.CheckAdvice).HasColumnName("CheckAdvice");
            this.Property(t => t.IsAbNormal).HasColumnName("IsAbNormal");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.Diagnose).HasColumnName("Diagnose");
            this.Property(t => t.CheckId).HasColumnName("CheckId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ExecuteId).HasColumnName("ExecuteId");

            // Relationships
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.PsApplyReports)
                .HasForeignKey(d => d.DoctorId);
            this.HasOptional(t => t.BsItem)
                .WithMany(t => t.PsApplyReports)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.PsApplyReports)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.BsLocation1)
                .WithMany(t => t.PsApplyReports1)
                .HasForeignKey(d => d.ExecLocId);
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.PsApplyReports)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.PsApplyReports)
                .HasForeignKey(d => d.OperId);
            this.HasOptional(t => t.BsUser1)
                .WithMany(t => t.PsApplyReports1)
                .HasForeignKey(d => d.CancelOperId);
            this.HasOptional(t => t.BsUser2)
                .WithMany(t => t.PsApplyReports2)
                .HasForeignKey(d => d.CheckOperId);
            this.HasOptional(t => t.BsUser3)
                .WithMany(t => t.PsApplyReports3)
                .HasForeignKey(d => d.ReportOperId);
            this.HasOptional(t => t.BsUser4)
                .WithMany(t => t.PsApplyReports4)
                .HasForeignKey(d => d.AuthOperId);
            this.HasOptional(t => t.CkMain)
                .WithMany(t => t.PsApplyReports)
                .HasForeignKey(d => d.CheckId);
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.PsApplyReports)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.PsApplyReports)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}

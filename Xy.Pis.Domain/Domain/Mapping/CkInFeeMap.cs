using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CkInFeeMap : EntityTypeConfiguration<CkInFee>
    {
        public CkInFeeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkInFee");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LabId).HasColumnName("LabId");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.CkLab)
                .WithMany(t => t.CkInFees)
                .HasForeignKey(d => d.LabId);

        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class CsCostClassRelaMap : EntityTypeConfiguration<CsCostClassRela>
    {
        public CsCostClassRelaMap()
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
            this.ToTable("CsCostClassRela");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ClassId).HasColumnName("ClassId");
            this.Property(t => t.CostSubjId).HasColumnName("CostSubjId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.CsCostClass)
                .WithMany(t => t.CsCostClassRelas)
                .HasForeignKey(d => d.ClassId);
            this.HasOptional(t => t.CsCostSubj)
                .WithMany(t => t.CsCostClassRelas)
                .HasForeignKey(d => d.CostSubjId);

        }
    }
}

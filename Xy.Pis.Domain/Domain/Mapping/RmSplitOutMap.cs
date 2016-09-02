using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class RmSplitOutMap : EntityTypeConfiguration<RmSplitOut>
    {
        public RmSplitOutMap()
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
            this.ToTable("RmSplitOut");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.InBatchId).HasColumnName("InBatchId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.RmSplitOuts)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.RmSplitOuts)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.RmSplit)
                .WithMany(t => t.RmSplitOuts)
                .HasForeignKey(d => d.BillId);
            this.HasRequired(t => t.Rmstore)
                .WithMany(t => t.RmSplitOuts)
                .HasForeignKey(d => d.InBatchId);

        }
    }
}

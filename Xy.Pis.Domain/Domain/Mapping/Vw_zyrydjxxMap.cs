using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class Vw_zyrydjxxMap : EntityTypeConfiguration<Vw_zyrydjxx>
    {
        public Vw_zyrydjxxMap()
        {
            // Primary Key
            this.HasKey(t => new { t.住院号, t.姓名, t.住院次数, t.入院日期, t.单位, t.联系人, t.联系电话, t.登记日期, t.性别 });

            // Properties
            this.Property(t => t.籍贯)
                .HasMaxLength(100);

            this.Property(t => t.入院科室)
                .HasMaxLength(30);

            this.Property(t => t.入院诊断)
                .HasMaxLength(100);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.门诊医生)
                .HasMaxLength(40);

            this.Property(t => t.住院号)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.住院记录)
                .HasMaxLength(44);

            this.Property(t => t.姓名)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.住院次数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.单位)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.职业)
                .HasMaxLength(50);

            this.Property(t => t.联系人)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.联系电话)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.备注)
                .HasMaxLength(500);

            this.Property(t => t.登记人)
                .HasMaxLength(30);

            this.Property(t => t.病学中心)
                .HasMaxLength(100);

            this.Property(t => t.住院科室)
                .HasMaxLength(30);

            this.Property(t => t.家庭地址)
                .HasMaxLength(4000);

            this.Property(t => t.所在居委会)
                .HasMaxLength(50);

            this.Property(t => t.病人来源)
                .HasMaxLength(50);

            this.Property(t => t.医生)
                .HasMaxLength(82);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.住院状态)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("Vw_zyrydjxx");
            this.Property(t => t.籍贯).HasColumnName("籍贯");
            this.Property(t => t.入院科室).HasColumnName("入院科室");
            this.Property(t => t.入院诊断).HasColumnName("入院诊断");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.门诊医生).HasColumnName("门诊医生");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.住院记录).HasColumnName("住院记录");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.住院次数).HasColumnName("住院次数");
            this.Property(t => t.入院日期).HasColumnName("入院日期");
            this.Property(t => t.单位).HasColumnName("单位");
            this.Property(t => t.出生日期).HasColumnName("出生日期");
            this.Property(t => t.职业).HasColumnName("职业");
            this.Property(t => t.联系人).HasColumnName("联系人");
            this.Property(t => t.联系电话).HasColumnName("联系电话");
            this.Property(t => t.备注).HasColumnName("备注");
            this.Property(t => t.登记人).HasColumnName("登记人");
            this.Property(t => t.病学中心).HasColumnName("病学中心");
            this.Property(t => t.住院科室).HasColumnName("住院科室");
            this.Property(t => t.家庭地址).HasColumnName("家庭地址");
            this.Property(t => t.所在居委会).HasColumnName("所在居委会");
            this.Property(t => t.病人来源).HasColumnName("病人来源");
            this.Property(t => t.医生).HasColumnName("医生");
            this.Property(t => t.出院日期).HasColumnName("出院日期");
            this.Property(t => t.登记日期).HasColumnName("登记日期");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.住院状态).HasColumnName("住院状态");
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Xy.Pis.Domain.Mapping
{
    public class VwOuRoomRecipeMap : EntityTypeConfiguration<VwOuRoomRecipe>
    {
        public VwOuRoomRecipeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RoomName, t.RecipeNum, t.roomid });

            // Properties
            this.Property(t => t.RoomName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.RecipeNum)
                .IsRequired()
                .HasMaxLength(21);

            this.Property(t => t.roomid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwOuRoomRecipe");
            this.Property(t => t.RoomName).HasColumnName("RoomName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.RecipeNum).HasColumnName("RecipeNum");
            this.Property(t => t.OutTime).HasColumnName("OutTime");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.roomid).HasColumnName("roomid");
        }
    }
}

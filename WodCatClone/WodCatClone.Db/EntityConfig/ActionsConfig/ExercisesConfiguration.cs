using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class ExercisesConfiguration : IEntityTypeConfiguration<Exercises>
    {
        public void Configure(EntityTypeBuilder<Exercises> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.FullDescription).IsRequired();
            builder.Property(x => x.Complexity).IsRequired();
            builder.Property(x => x.Movement).IsRequired();
            builder.Property(x => x.Modality).IsRequired();
            builder.Property(x => x.Inventory).IsRequired();
            builder.Property(x => x.Image).IsRequired();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.Actions;

namespace WodCatClone.Db.EntityConfig.ActionsConfig
{
    public class ProgramTimeUserConfiguration : IEntityTypeConfiguration<ProgramTimeUser>
    {
        public void Configure(EntityTypeBuilder<ProgramTimeUser> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.BeginProgramDate);

            builder.HasOne(_ => _.Programs)
                .WithMany(_ => _.ProgramTimeUsers)
                .HasForeignKey(b => b.ProgramsId);

            builder.HasOne(_ => _.User)
                .WithMany(_ => _.ProgramTimeUsers)
                .HasForeignKey(b => b.UserId);
        }
    }
}

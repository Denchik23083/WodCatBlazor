using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WodCatClone.Db.Entities.CallBack;

namespace WodCatClone.Db.EntityConfig.CallBackConfig
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(_ => _.Id);

            builder.Property(_ => _.Name).IsRequired();

            builder.HasOne(_ => _.Answer)
                .WithMany()
                .HasForeignKey(b => b.AnswerId);
        }
    }
}

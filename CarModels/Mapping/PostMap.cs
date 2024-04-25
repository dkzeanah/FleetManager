using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels;

namespace BlazorApp1.Data.Mapping
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasMany(e => e.Tags)
                    .WithMany(e => e.Posts)
                    .UsingEntity<PostTag>(
                        "PostTag",
                        l => l.HasOne<Tag>().WithMany(e => e.PostTags).HasForeignKey(e => e.TagId).HasPrincipalKey(e => e.Id),
                        r => r.HasOne<Post>().WithMany(e => e.PostTags).HasForeignKey(e => e.PostId).HasPrincipalKey(e => e.Id),
                        j =>
                        {
                            j.HasKey(e => new { e.PostId, e.TagId });
                            j.Property(e => e.CreatedOn).HasDefaultValueSql("CURRENT_TIMESTAMP");
                        });
        }
    }
}

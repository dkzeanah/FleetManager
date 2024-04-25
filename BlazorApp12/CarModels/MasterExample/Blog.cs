using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.CarModels.MasterExample;

namespace BlazorApp1.CarModels.MasterExample
{
    /*
     protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder
        .Entity<Blog>()
        .Property(e => e.AssetsId)
        .ValueGeneratedOnAdd();

    modelBuilder
        .Entity<BlogAssets>()
        .HasOne(e => e.Blog)
        .WithOne(e => e.Assets)
        .HasForeignKey<BlogAssets>(e => e.Id)
        .HasPrincipalKey<Blog>(e => e.AssetsId);
} 
      */
    public class Blog
    {
        public int Id { get; set; } // Primary key
        public Guid AssetsId { get; set; } // Alternate key
        public string Name { get; set; }

        public IList<Post> Posts { get; } = new List<Post>(); // Collection navigation
        public BlogAssets Assets { get; set; } // Reference navigation
    }
    //full
    /*
     public class Blog
{
    public int Id { get; set; } // Primary key
    public Guid AssetsId { get; set; } // Alternate key
    public string Name { get; set; }

    public IList<Post> Posts { get; } = new List<Post>(); // Collection navigation
    public BlogAssets Assets { get; set; } // Reference navigation
}

public class BlogAssets
{
    public Guid Id { get; set; } // Primary key and foreign key
    public byte[] Banner { get; set; }

    public Blog Blog { get; set; } // Reference navigation
}

public class Post
{
    public int Id { get; set; } // Primary key
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; } // Foreign key
    public Blog Blog { get; set; } // Reference navigation

    public IList<Tag> Tags { get; } = new List<Tag>(); // Skip collection navigation
}

public class Tag
{
    public int Id { get; set; } // Primary key
    public string Text { get; set; }

    public IList<Post> Posts { get; } = new List<Post>(); // Skip collection navigation
}
     */
}

namespace BlazorApp1.Mapping
{
    public class BlogMapConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> modelBuilder)
        {
         modelBuilder
        .Property(e => e.AssetsId)
        .ValueGeneratedOnAdd();
        }
        public void Configure(EntityTypeBuilder<BlogAssets> modelBuilder)
        {
         modelBuilder
        .HasOne(e => e.Blog)
        .WithOne(e => e.Assets)
        .HasForeignKey<BlogAssets>(e => e.Id)
        .HasPrincipalKey<Blog>(e => e.AssetsId);
        }
    }
}

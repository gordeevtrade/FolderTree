
using Microsoft.EntityFrameworkCore;
namespace Folders.DAL
{
    public class FolderContext : DbContext
    {
        public DbSet<Folder> Folders { get; set; }

        public FolderContext(DbContextOptions<FolderContext> options)
        : base(options)
        {          
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Folder>().HasData(
                new Folder { Id = 1, Name = "Creatind Digital Images", ParentFolderId = null },
                new Folder { Id = 2, Name = "Resources", ParentFolderId = 1 },
                new Folder { Id = 3, Name = "Evidence", ParentFolderId = 1 },
                new Folder { Id = 4, Name = "Graphic Products", ParentFolderId = 1},
                new Folder { Id = 5, Name = "Process", ParentFolderId = 4 },
                new Folder { Id = 6, Name = "Final Product", ParentFolderId = 4 },
                new Folder { Id = 7, Name = "Primary Sources", ParentFolderId = 2 },
                new Folder { Id = 8, Name = "Secondary Sources", ParentFolderId = 2 }
            ) ;
        }
    }
    
}

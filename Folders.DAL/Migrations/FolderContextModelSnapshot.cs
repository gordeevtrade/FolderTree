
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Folders.DAL.Migrations
{
    [DbContext(typeof(FolderContext))]
    partial class FolderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Folders.DAL.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentFolderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentFolderId");

                    b.ToTable("Folders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Creatind Digital Images"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Resources",
                            ParentFolderId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Evidence",
                            ParentFolderId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Graphic Products",
                            ParentFolderId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Process",
                            ParentFolderId = 4
                        },
                        new
                        {
                            Id = 6,
                            Name = "Final Product",
                            ParentFolderId = 4
                        },
                        new
                        {
                            Id = 7,
                            Name = "Primary Sources",
                            ParentFolderId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Secondary Sources",
                            ParentFolderId = 2
                        });
                });

            modelBuilder.Entity("Folders.DAL.Folder", b =>
                {
                    b.HasOne("Folders.DAL.Folder", "ParentFolder")
                        .WithMany("ChildFolders")
                        .HasForeignKey("ParentFolderId");

                    b.Navigation("ParentFolder");
                });

            modelBuilder.Entity("Folders.DAL.Folder", b =>
                {
                    b.Navigation("ChildFolders");
                });
#pragma warning restore 612, 618
        }
    }
}

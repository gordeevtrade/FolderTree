namespace Folders.DAL
{
    public class Folder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentFolderId { get; set; }
        public virtual Folder ParentFolder { get; set; }
        public virtual ICollection<Folder> ChildFolders { get; set; }
    }
}

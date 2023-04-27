
namespace Folders.DAL.Services.Interface
{
    public interface IFolderServices
    {
        public Folder PrimaryFolder(int folderId);
        public List<Folder> SubFolders(int folderId);
    }
}

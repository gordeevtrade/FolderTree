using Folders.DAL.Services.Interface;

namespace Folders.DAL.Services
{
    public class FolderService:IFolderServices
    {
        private FolderContext _folderContext;

        public FolderService(FolderContext folderContext)
        {

            _folderContext = folderContext;
        }

        public Folder PrimaryFolder(int folderId)
        {
            var folder = _folderContext.Folders.Find(folderId);
            CheckObjectExist(folder, $"Folder not found");
            return folder;
        }

        public List<Folder> SubFolders(int folderId)
        {
            var folders = _folderContext.Folders.Where(f => f.ParentFolderId == folderId).ToList();
            CheckObjectExist(folders, $"Subfolders  not found");
            return folders;
        }

        private T CheckObjectExist<T>(T obj, string message) where T : class
        {
            if (obj == null)
            {
                throw new ApplicationException(message);
            }
            return obj;
        }
    }
}

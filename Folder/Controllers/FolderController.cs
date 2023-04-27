
using Microsoft.AspNetCore.Mvc;
using Folders.DAL.Services.Interface;

namespace Folder.Controllers
{
    public class FolderController : Controller
    {
        private  IFolderServices _folderService;
        public FolderController(IFolderServices folderService)
        {
            _folderService = folderService;
        }
        public ActionResult ShowFolders(int folderId)
        {
            try
            {
                var folder = _folderService.PrimaryFolder(folderId);
                var folders = _folderService.SubFolders(folderId);
                ViewBag.Folders = folder.Name;
                return View(folders);
            }
            catch (Exception ex)
            {
                return RedirectToAction("ErrorMessage", "Folder", new { errorMessage = ex.Message });
            }        
        }

        public IActionResult ErrorMessage(string errorMessage)
        {
            ViewBag.ErrorMessage = errorMessage;
            return View();
        }
    }
}
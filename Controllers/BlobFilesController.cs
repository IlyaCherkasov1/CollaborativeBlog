using CollaborativeBlog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollaborativeBlog.Controllers
{
    public class BlobFilesController : Controller
    {
        private readonly IBlobService _blobService;

        public BlobFilesController(IBlobService blobService)
        {
            _blobService = blobService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var files = await _blobService.AllBlobs("images");
            return View(files);
        }

        [HttpGet]
        public IActionResult AddFile()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile file)
        {
            if (file == null || file.Length < 1) return View();

            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);

            var res = await _blobService.UploadBlob(fileName, file, "images");

           return Redirect("~/Home/Index");
        }

        [HttpGet]
        public async Task<IActionResult> ViewFile(string name)
        {
            var res = await _blobService.GetBlob(name, "images");
         
            return Redirect(res);   
        }

        [HttpGet]
        public async Task<IActionResult> DeleteFile(string name)
        {
            await _blobService.DeleteBlob(name, "images");
            return RedirectToAction("Index");
        }
    }
}

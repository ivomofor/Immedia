using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using Immedia.Models;
using Immedia.Models.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Authorization;

namespace Immedia.Controllers
{
    [Authorize]
    public class ImageController : Controller
    {
        private readonly IPhotoRepo photoRepo;
        public ImageController(IPhotoRepo repo)
        {
            photoRepo = repo;
        }
        public IActionResult Error()
        {
            return View();
        }
        public async Task<IActionResult> IndexAsync(string City)
        {
            string url = $"https://pixabay.com/api/?key=18936957-b86877b5a1144088af8a796eb&q={City}&image_type=photo&pretty=true";

            if(ModelState.IsValid)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        var json = await client.GetStringAsync(url);
                        var response = JsonConvert.DeserializeObject<RootImage>(json);
                        photoRepo.AddHit(response);
                        return View(response);
                    }
                }
                catch
                {
                    return View(nameof(Error));
                }
            }
            return View(City);
            
        }
        [HttpPost]
        public IActionResult Index(RootImage image)
        {
            photoRepo.AddHit(image);
            return RedirectToAction(nameof(SaveImage));
        }
        public IActionResult SaveImage()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Immedia.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Immedia.Models.Repository
{
    public class PhotoRepo : IPhotoRepo
    {
        private readonly DataContext context; 
        public PhotoRepo(DataContext ctx)
        {
            context = ctx;
        }
        public async Task<RootImage> GetHitAsync(int image)
        {
            RootImage hit = await context.RootImages.FindAsync(image);
            return hit;
        }
        public IEnumerable<RootImage> GetHits()
        {
            return context.RootImages;
        }
        public void  AddHit(RootImage image)
        {
            context.RootImages.Add(image);
            context.SaveChanges();
        }

        public void DeleteHit(RootImage image)
        {
            context.RootImages.Remove(image);
            context.SaveChanges();
        }
    }
}

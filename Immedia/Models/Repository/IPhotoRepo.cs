using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Immedia.Models.Repository
{
    public interface IPhotoRepo
    {
        Task<RootImage> GetHitAsync(int id);
        IEnumerable<RootImage> GetHits();
        void AddHit(RootImage image);
        void DeleteHit(RootImage image);
    }
}

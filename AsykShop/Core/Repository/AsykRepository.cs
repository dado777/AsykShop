using AsykShop.Core.Interfaces;
using AsykShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AsykShop.Core.Repository
{
    public class AsykRepository : IAllAsyktar
    {
        private readonly AppDBContent _appDBContent;

        public AsykRepository(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }

        public IEnumerable<Asyk> Asyktar => _appDBContent.Asyk.Include(c => c.Category);

        public IEnumerable<Asyk> GetFavorAsyk => _appDBContent.Asyk.Where(f => f.isFavorAsyk).Include(c => c.Category);

        public Asyk GetAsykObject(int asykId) => _appDBContent.Asyk.FirstOrDefault(i => i.Id == asykId);

        public void SaveAsyk(Asyk asyk)
        {
            if (asyk.Id == 0)
                _appDBContent.Asyk.Add(asyk);
            else
            {
                Asyk dbContent = _appDBContent.Asyk.Find(asyk.Id);
                if(dbContent != null)
                {
                    dbContent.AsykName = asyk.AsykName;
                    dbContent.AsykLongDesc = asyk.AsykLongDesc;
                    dbContent.AsykShortDesc = asyk.AsykShortDesc;
                    dbContent.AsykPrice = asyk.AsykPrice;
                    dbContent.AsykAvailable = asyk.AsykAvailable;
                    dbContent.isFavorAsyk = asyk.isFavorAsyk;
                    dbContent.AsykImageData = asyk.AsykImageData;
                    dbContent.AsykImageMimeType = asyk.AsykImageMimeType;
                    dbContent.CategoryId = asyk.CategoryId;
                }
            }

            _appDBContent.SaveChanges();
        }

        public Asyk DeleteAsyk(int asykId)
        {
            Asyk dbContent = _appDBContent.Asyk.Find(asykId);
            if(dbContent != null)
            {
                _appDBContent.Asyk.Remove(dbContent);
                _appDBContent.SaveChanges();
            }

            return dbContent;
        }
    }
}

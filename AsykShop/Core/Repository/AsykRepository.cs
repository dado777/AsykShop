using AsykShop.Core.Interfaces;
using AsykShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}

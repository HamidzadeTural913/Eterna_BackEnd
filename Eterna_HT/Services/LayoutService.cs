using Eterna_HT.DAL;
using Eterna_HT.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eterna_HT.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;

        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<SocialContact>> GetDatas()
        {
            List<SocialContact> SocialContacts = await _context.SocialContacts.ToListAsync();
            
            return SocialContacts;
        }
    }
}

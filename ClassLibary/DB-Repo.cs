using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST_DanmarksRadio.Models;

namespace ClassLibary
{
    public class DB_Repo : IRepository
    {
        private readonly DB_Context _context;

        public DB_Repo(DB_Context context)
        {
            _context = context;
        }

        public List<DR> GetAll()
        {
            return _context.DRs.ToList();
        }

        public DR? GetById(int id)
        {
            return _context.DRs.FirstOrDefault(d => d.Id == id);
        }

        public List<DR> GetByTitle(string title)
        {
            return _context.DRs.Where(d => d.Title.Contains(title)).ToList();
        }

        public DR Add(DR dr)
        {
            _context.DRs.Add(dr);
            _context.SaveChanges();
            return dr;
        }

        public DR Delete(int id)
        {
            var dr = GetById(id);
            if (dr != null)
            {
                _context.DRs.Remove(dr);
                _context.SaveChanges();
            }
            return dr;
        }

        public DR Update(int id, DR updatedDR)
        {
            var dr = GetById(id);
            if (dr != null)
            {
                dr.Title = updatedDR.Title;
                dr.Artist = updatedDR.Artist;
                dr.Duration = updatedDR.Duration;
                dr.PublishedYear = updatedDR.PublishedYear;
                _context.SaveChanges();
            }
            return dr;
        }
    }
}

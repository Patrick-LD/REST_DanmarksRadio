using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST_DanmarksRadio.Models;

namespace ClassLibary
{
    public class Repository : IRepository
    {
        private static int nextId = 4;
        private static readonly List<REST_DanmarksRadio.Models.DR> _DRs = new List<REST_DanmarksRadio.Models.DR>
        {
            new REST_DanmarksRadio.Models.DR
            {
                Id = 1,
                Title = "Smells Like Teen Spirit",
                Artist = "Nirvana",
                Duration = 301,
                PublishedYear = 1991
            },
            new REST_DanmarksRadio.Models.DR
            {
                Id = 2,
                Title = "Bohemian Rhapsody",
                Artist = "Queen",
                Duration = 354,
                PublishedYear = 1975
            },
            new REST_DanmarksRadio.Models.DR
            {
                Id = 3,
                Title = "Billie Jean",
                Artist = "Michael Jackson",
                Duration = 294,
                PublishedYear = 1982
            }
        };

        public List<REST_DanmarksRadio.Models.DR> GetAll()
        {
            return new List<REST_DanmarksRadio.Models.DR>(_DRs);
        }
        public DR? GetById(int id)
        {
            return _DRs.FirstOrDefault(d => d.Id == id);
        }

        public List<REST_DanmarksRadio.Models.DR> GetByTitle(string title)
        {
            return _DRs.Where(d => d.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public DR Add(DR dr)
        {
            dr.Id = Interlocked.Increment(ref nextId);
            _DRs.Add(dr);
            return dr;
        }

        public DR Delete(int id)
        {
            var dr = GetById(id);
            if (dr != null)
            {
                _DRs.Remove(dr);
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
            }
            return dr;
        }

    }
}

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
        private int nextId = 0;
        private readonly List<REST_DanmarksRadio.Models.DR> _DRs;

        public Repository()
        {
            _DRs = new List<REST_DanmarksRadio.Models.DR>
            {
                new REST_DanmarksRadio.Models.DR
                {
                    Id = 1,
                    Title = "Smells Like Teen Spirit",
                    Artist = "Nirvana",
                    Duration = 301,
                    publishedYear = 1991
                },
                new REST_DanmarksRadio.Models.DR
                {
                    Id = 2,
                    Title = "Bohemian Rhapsody",
                    Artist = "Queen",
                    Duration = 354,
                    publishedYear = 1975
                },
                new REST_DanmarksRadio.Models.DR
                {
                    Id = 3,
                    Title = "Billie Jean",
                    Artist = "Michael Jackson",
                    Duration = 294,
                    publishedYear = 1982
                }
            };
        }

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

    }
}

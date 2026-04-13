using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibary
{
    public class Repository
    {
        private int nextId = 0;
        private readonly List<REST_DanmarksRadio.Models.DR> _DRs = new List<REST_DanmarksRadio.Models.DR>();


        public List<REST_DanmarksRadio.Models.DR> GetAll()
        {
            return new List<REST_DanmarksRadio.Models.DR>(_DRs);
        }

    }
}

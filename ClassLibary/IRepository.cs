using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST_DanmarksRadio.Models;

namespace ClassLibary
{
    public interface IRepository
    {
        List<DR> GetAll();
        DR? GetById(int id);
        List<DR> GetByTitle(string title);
        DR Add(DR dr);
    }
}

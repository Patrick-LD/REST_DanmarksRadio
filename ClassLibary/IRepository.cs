using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibary.Models;

namespace ClassLibary
{
    public interface IRepository
    {
        List<DR> GetAll();
        DR? GetById(int id);
        List<DR> GetByTitle(string title);
        DR Add(DR dr);
        DR Delete(int id);

        DR Update(int id, DR dr);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetByID(string id);
        //void Insert(T theObject);
        void Update(int index, T theObject);
        void Delete(int index);
        void SaveChanges();

    }
}

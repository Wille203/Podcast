using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class poddRepository
    {
        private List <pod> enPod = new List<pod> ();
        
        public void LäggTillEnPod (pod pod)
        {
            enPod.Add (pod);
        }

        public List<pod> HämtaEnPod()
        {
            return enPod;
        }
      //public IEnumerable<pod> GetAll() { return enPod; }



        //List<T> GetAll();
        //T GetByID(string id);
        //void Update(int index, T theObject);
        //void Delete(int index);
        //void SaveChanges();
    }
}

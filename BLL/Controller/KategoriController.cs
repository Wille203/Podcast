using DAL.Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Controller
{
    public class KategoriController
    {
        IRepository<Kategori> kategoriRepository;

        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
        }

        public List<Kategori> LasAllaKategorier()
        {
            List<Kategori> kategoriLista = kategoriRepository.GetAll();
            return kategoriLista;
        }
            
    }
}

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
        Kategori nyKategori;
        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
            nyKategori = new Kategori();
        }

        //public List<Kategori> LasAllaKategorier()
        //{
        //    List<Kategori> kategoriLista = kategoriRepository.GetAll();
        //    return kategoriLista;
        //}

        public void SkapaFardigKategori()
        {
            KategoriRepository.kategoriPopulerare();
        }

        public List<String>  LasAllaKategorier()
        {
            List<String> kategoriLista = KategoriRepository.HamtaAllaKategorier();
            return kategoriLista;
        }

        public void LaggTillKategori(string namn, List<Pod>)
        {
            nyKategori.KattNamn = namn;
            kategoriRepository.Create(nyKategori);
        }
    }
}

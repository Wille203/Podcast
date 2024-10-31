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
        //Kategori nyKategori;
        public KategoriController()
        {
            kategoriRepository = new KategoriRepository();
            //nyKategori = new Kategori();
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

        public void UpdateraKategori(Kategori kategori)
        {
            int index = kategoriRepository.GetIndex(kategori.KattNamn);
            if(index >= 0)
            {
                kategoriRepository.Update(index, kategori);
            }
            else
            {
                kategoriRepository.Create(kategori);
            }
        }

        public Kategori hamtaKategoriByName (string kategoriNamn)
        {
            return kategoriRepository.GetByName(kategoriNamn);
        }

        public void LaggTillKategori(string name, List<Pod> poddLista)
        {
            Kategori nyKategori = new Kategori(name)
            {
                Pod = poddLista
            };

            kategoriRepository.Create(nyKategori);
        }

        public List<Pod> HamtaPoddarForKategori(string kategoriNamn)
        {
            var kategori = hamtaKategoriByName(kategoriNamn); // Hämta kategori baserat på namn
            return kategori?.Pod ?? new List<Pod>(); // Returnera poddar om kategorin finns, annars en tom lista
        }
    }
}

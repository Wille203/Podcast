using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DAL.Repository;
using System.Diagnostics;

namespace BLL.Controller
{
    public class PoddController
    {
        IRepository<Pod> podRepository;
        Pod newPod;
        KategoriController kategoriController;
        public PoddController()
        {
            podRepository = new PodRepository();
            newPod = new Pod();
            kategoriController = new KategoriController();
        }

        public void HamtaPoddFranRss(string rssLank)
        {
            try
            {
                XmlReader minXmlLasare = XmlReader.Create(rssLank);
                SyndicationFeed poddFlode = SyndicationFeed.Load(minXmlLasare);

                if (poddFlode == null)
                {
                    throw new Exception("Flödet kunde inte laddas");
                }

                if (poddFlode.Title == null || poddFlode.Description == null)
                {
                    throw new Exception("Flödet saknar nödvändig information");
                }
                Pod pod = new Pod
                {
                    PodTitel = poddFlode.Title.Text,
                    Beskrivning = poddFlode.Description.Text,
                    PodUrl = rssLank
                };

                foreach (SyndicationItem item in poddFlode.Items)
                {
                    Avsnitt avsnitt = new Avsnitt
                    {
                        Titel = item.Title.Text,
                        Beskrivning = item.Summary.Text,
                    };
                    pod.Avsnitt.Add(avsnitt);
                }
                podRepository.Create(pod);
                newPod = pod; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett fel uppstod vid hämtning av rss-Flödet");
            }
        }

        public List<Pod> GetAllPods()
        {
            return podRepository.GetAll().Distinct().ToList();
        }


        public void DeletePod(string name)
        {
            int index = podRepository.GetIndex(name);
            if(index >= 0)
            {
                var podToRemove = podRepository.GetByName(name);
                podRepository.Delete(index);

                var kategori = kategoriController.LasAllaKategorier()
                .Select(kName => kategoriController.hamtaKategoriByName(kName))
                .FirstOrDefault(k => k != null && k.Pod != null && k.Pod.Any(p => p.PodTitel.Equals(name, StringComparison.OrdinalIgnoreCase)));

                if (kategori != null)
                {
                    var poddToRemove = kategori.Pod.FirstOrDefault(p => p.PodTitel.Equals(name, StringComparison.OrdinalIgnoreCase));
                    if (poddToRemove != null)
                    {
                        kategori.Pod.Remove(poddToRemove);
                        kategoriController.UpdateraKategori(kategori);
                    }
                }

            }
            else
            {
                Console.WriteLine("Podden kunde inte hittas och togs därför inte bort.");
            }
            
        }

        //public string GetPodName(string name)
        //{
        //    return podRepository.GetByName(name).PodTitel;  
        //}

        public string GetPodName()
        {
            return newPod.PodTitel;
        }

        public void SavePod(string rssLank, string name, string kategoriNamn)
        {
            Kategori kategori = kategoriController.hamtaKategoriByName(kategoriNamn);
            if (kategori == null)
            {
                kategori = new Kategori(kategoriNamn);
                kategoriController.LaggTillKategori(kategoriNamn, new List<Pod>());
            }

            if(kategori.Pod == null)
            {
                kategori.Pod = new List<Pod>();
            }

            Pod nyPod = new Pod {PodUrl = rssLank, PodTitel = name};

            if(!podRepository.GetAll().Any(p => p.PodTitel.Equals(nyPod.PodTitel, StringComparison.OrdinalIgnoreCase)))
            {
                kategori.Pod.Add(nyPod);
                podRepository.Create(nyPod);
                kategoriController.UpdateraKategori(kategori);
            }
        }
        public Pod GetPodByTitle(string title)
        {

            List<Pod> allaPoddar = GetAllPods();

            foreach (var podd in allaPoddar)
            {
                Debug.WriteLine($"Kontrollerar podd: '{podd.PodTitel}' (längd: {podd.PodTitel.Length})");

              
                if (podd.PodTitel.Trim().Equals(title.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    Debug.WriteLine("Match found: " + podd.PodTitel);
                    return podd;
                }
            }

            Debug.WriteLine("Ingen matchning hittades för titeln: '" + title + "'");
            return null;
        }




    }
}

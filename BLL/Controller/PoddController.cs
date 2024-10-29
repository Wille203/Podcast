using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DAL.Repository;

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

                newPod = pod;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ett fel uppstod vid hämtning av rss-Flödet");
            }

            //foreach (SyndicationItem item in poddFlode.Items)
            //{
            //    Pod enPodd = new Pod
            //    {
            //        PodTitel = item.Title.Text,
            //        Beskrivning = item.Summary.Text,
            //        PodUrl = rssLank
            //    };
            //    podRepository.Create(enPodd);
            //}
        }

        public List<Pod> GetAllPods()
        {
            return podRepository.GetAll();
        }

        public void DeletePod(string name)
        {
            int index = podRepository.GetIndex(name);
            podRepository.Delete(index);
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
            kategori.Pod.Add(nyPod);
            kategoriController.UpdateraKategori(kategori);
        }
    }
}

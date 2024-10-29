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
        public PoddController()
        {
            podRepository = new PodRepository();
            newPod = new Pod();
        }

        public void HamtaPoddFranRss(string rssLank)
        {
            XmlReader minXmlLasare = XmlReader.Create(rssLank);
            SyndicationFeed poddFlode = SyndicationFeed.Load(minXmlLasare);

            Pod pod = new Pod
            {
                PodTitel = poddFlode.Title.Text,
                Beskrivning = poddFlode.Description.Text,
                PodUrl = rssLank
            };

            newPod = pod;

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

        public void SavePod(string rssLank, string name)
        {
            newPod.PodTitel = name;
            podRepository.Create(newPod);
        }
    }
}

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
        private PoddRepository poddRepository;
        public PoddController()
        {
            poddRepository = new PoddRepository();
        }

        public void HämtaPoddFrånRss(string rssLank)
        {
            XmlReader minXmlLasare = XmlReader.Create(rssLank);
            SyndicationFeed poddFlode = SyndicationFeed.Load(minXmlLasare);

            foreach (SyndicationItem item in poddFlode.Items)
            {
                Pod enPodd = new Pod
                {
                    PodTitel = item.Title.Text,
                    Beskrivning = item.Summary.Text,

                };
                PoddRepository.Add(enPodd);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Models
{
    [Serializable]
    public class Pod
    {
        public string PodTitel {  get; set; }
        //public string PodNamn { get; set; }
        public string PodUrl { get; set; }
        //public string PodKategori { get; set; }
        public string Beskrivning { get; set; }
        public List<Avsnitt>Avsnitt { get; set; }

        public Pod()
        {
            Avsnitt = new List<Avsnitt>();
        }
        public Pod(string url, string podTitel)
        {
            PodUrl = url;
            PodTitel = podTitel;
        }
    }
}

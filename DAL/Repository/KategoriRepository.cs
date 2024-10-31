using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class KategoriRepository : IRepository<Kategori>
    {
        List<Kategori> kategoriLista;
        Serializer<Kategori> kategoriSerializer;
        string className => "kategori";

        public KategoriRepository()
        {
            kategoriSerializer = new Serializer<Kategori>();
            kategoriLista = LaddaKategori(); 
        }
        public void Create(Kategori entity)
        {
            kategoriLista.Add(entity);
            SaveChanges();
        }

        private List<Kategori> LaddaKategori()
        {
            try
            {
                return kategoriSerializer.Deserialize(className) ?? new List<Kategori>();
            }
            catch (Exception)
            {
                return new List<Kategori>();
            }
        }

        public void Delete(int index)
        {
            if(index >= 0 && index < kategoriLista.Count)
            {
                kategoriLista.RemoveAt(index);
                SaveChanges();
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        public List<Kategori> GetAll()
        {
            return kategoriLista;
            //List<Kategori>deserialiseraadKategoriLista = new List<Kategori>();
            //try
            //{
            //    deserialiseraadKategoriLista = kategoriSerializer.Deserialize(className);
            //}
            //catch (Exception) 
            //{

            //}
            //return deserialiseraadKategoriLista;
        }

        public Kategori GetByName(string name)
        {
            return GetAll().FirstOrDefault(p => p.KattNamn.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public int GetIndex(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Kategori kan inte vara tomt", nameof(name));
            }

            return kategoriLista.FindIndex(e => e.KattNamn.Equals(name, StringComparison.OrdinalIgnoreCase));
            //int index = GetAll().FindIndex(e => e.KattNamn.Equals(name, StringComparison.OrdinalIgnoreCase));
            //return index;
        }

        public void SaveChanges()
        {
            kategoriSerializer.Serialize(kategoriLista, className); 
        }

        public void Update(int index, Kategori theObject)
        {
            if (index < 0 || index >= kategoriLista.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }
            else
            {
                kategoriLista[index] = theObject;
                SaveChanges();
            }
        }

        public static void kategoriPopulerare()
        {
            string[] lines = { "Komedi", "Historia", "Dokumentär", "Verkliga brott" };

            using (FileStream fileStream = new FileStream("Category.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    foreach (string line in lines)
                        writer.WriteLine(line);
                }
            }
        }
        
        public static void LaggTillKategori(string nyKategori)
        {
            using(FileStream filestream = new FileStream("Category.txt", FileMode.Append, FileAccess.Write))
            {
                using(StreamWriter writer = new StreamWriter(filestream))
                {
                    writer.WriteLine(nyKategori);
                }
            }
        }

        public static List<string> HamtaKategoriLista()
        {
            List<string> kategoriLista = new List<string>();

            using(FileStream filestream = new FileStream("Category.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(filestream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                       kategoriLista.Add(line);
                    }
                }
            }
            return kategoriLista;

        }

        public static List<String> HamtaAllaKategorier()
        {
            return HamtaKategoriLista();
        }
    }
}

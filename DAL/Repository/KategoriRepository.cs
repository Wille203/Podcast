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
            kategoriLista = new List<Kategori>();
            kategoriSerializer = new Serializer<Kategori>();
        }
        public void Create(Kategori entity)
        {
            kategoriLista.Add(entity);
            SaveChanges();
        }

        public void Delete(int index)
        {
            kategoriLista.RemoveAt(index);
            SaveChanges();
        }

        public List<Kategori> GetAll()
        {
            List<Kategori>deserializedKategoriList = new List<Kategori>();
            try
            {
                deserializedKategoriList = kategoriSerializer.Deserialize(className);
            }
            catch (Exception) 
            {

            }
            return deserializedKategoriList;
        }

        public Kategori GetByName(string name)
        {
            return GetAll().FirstOrDefault(p => p.KattNamn.Equals(name));
        }

        public int GetIndex(string name)
        {
            return GetAll().FindIndex(e => e.KattNamn.Equals(name));
        }

        public void SaveChanges()
        {
            kategoriSerializer.Serialize(kategoriLista, className); 
        }

        public void Update(int index, Kategori theObject)
        {
            if (index >= 0)
            {
                kategoriLista[index] = theObject;
            }
            SaveChanges();
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

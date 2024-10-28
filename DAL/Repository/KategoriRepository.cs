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
            string[] lines = { "", "Komedi", "Historia", "Dokumentär", "Verkliga brott" };

            FileStream 
    }
}

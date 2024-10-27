﻿using System;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PodRepository : IRepository<Pod>
    {
        List<Pod> poddLista;
        Serializer<Pod> poddSerializer;
        string className => "pod";

        public PodRepository()
        {
            poddLista = new List<Pod>();
            poddSerializer = new Serializer<Pod>();   
        }

        public void Create(Pod pod)
        {
            poddLista.Add(pod);
            SaveChanges();
        }

        public void Delete(int index)
        {
            poddLista.RemoveAt(index);
            SaveChanges();
        }

        public List<Pod> GetAll()
        {
            List<Pod>deserializedPodList = new List<Pod>();
            try
            {
                deserializedPodList = poddSerializer.Deserialize(className);
            }
            catch (Exception)
            {
                
            }
            return deserializedPodList;
        }

        public Pod GetByName(string name)
        {
            return GetAll().FirstOrDefault(p => p.PodTitel.Equals(name));
        }

        public int GetIndex(string name)
        {
            return GetAll().FindIndex(e => e.PodTitel.Equals(name));
        }

        public void SaveChanges()
        {
            poddSerializer.Serialize(poddLista, className);
        }

        public void Update(int index, Pod theObject)
        {
            if(index >= 0)
            {
                poddLista[index] = theObject;
            }
            SaveChanges();
        }
    }
}

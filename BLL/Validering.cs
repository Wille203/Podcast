﻿using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Validering
    {
        KategoriRepository kategoriRepository;
        PodRepository podRepository;

        public Validering() 
        {
            kategoriRepository = new KategoriRepository();
            podRepository = new PodRepository();
        }
        public bool CheckIfStringIsEmpty(string text)
        {
            if ((text == null) || (text == ""))
            {
                return true;

            }
            else
            {
                return false;
            }


        }

        public bool CheckIfCategoryExist(string categoryName)
        {
            var selectCategory = from aCategory in kategoriRepository.GetAll()
                                 where aCategory.Equals(categoryName)
                                 select aCategory;
            return selectCategory.Any();

        }

        public bool CheckIfNameExist(string name)
        {
            var selectName = from aPod in podRepository.GetAll()
                             where aPod.PodTitel.Equals(name)
                             select aPod.PodTitel;
            return selectName.Any();
        }

        public bool CheckIfUrlExist(string url)
        {
            var selectUrl = from aPod in podRepository.GetAll()
                            where aPod.PodUrl.Equals(url)
                            select aPod.PodUrl;
            return selectUrl.Any();
        }

    }
}
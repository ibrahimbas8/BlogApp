﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public List<About> GetList()
        {
            return _aboutDal.GetListAll();
        }
        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }
        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }
        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }
        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_Template_SM22_Csharp.Context;
using Project_Template_SM22_Csharp.DomainClass;

namespace Project_Template_SM22_Csharp.Repositories
{
    public class SachRepository
    {
        FpolyDBContext _dbContext;

        public SachRepository()
        {
            _dbContext = new FpolyDBContext();
        }

        public List<Sach> GetAll()
        {
            return _dbContext.Saches.ToList();
        }

        public bool Add(Sach s)
        {
            if (s == null) return false;
            _dbContext.Saches.Add(s);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Delete(Sach s)
        {
            if (s == null) return false;
            _dbContext.Saches.Remove(s);
            _dbContext.SaveChanges();
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project_Template_SM22_Csharp.DomainClass;
using Project_Template_SM22_Csharp.Repositories;

namespace Project_Template_SM22_Csharp.Services
{
    internal class SachService
    {
        private SachRepository _sachRepository;
        List<Sach> _sachList;

        public SachService()
        {
            _sachRepository = new SachRepository();
            _sachList = new List<Sach>();
            GetValue();
        }

        public void GetValue()
        {
            _sachList = _sachRepository.GetAll();
        }

        public List<Sach> GetSach()
        {
            return _sachList;
        }
        public List<Sach> GetSach(Sach s)
        {

            if (s == null) return GetSach();
            return _sachRepository.GetAll().Where(p => p.Ma == s.Ma).ToList();
        }

        public string Add(Sach s)
        {
            if (_sachRepository.Add(s))
            {
                GetValue();
                return "Thêm thành công";
            }
            return "Thêm không thành công";
        }
        public string Delete(Sach s)
        {
            var sach = _sachRepository.GetAll().FirstOrDefault(p => p.Ma == s.Ma);
            if (_sachRepository.Delete(sach))
            {
                GetValue();
                return "Xóa thành công";
            }
            return "Xóa không thành công";
        }
    }
}

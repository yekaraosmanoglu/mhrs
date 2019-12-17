using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class DepartmanBLL
    {
        DepartmanlarDAL _departmanDAL;

        public DepartmanBLL()
        {
            _departmanDAL = new DepartmanlarDAL();
        }

        public List<Departmanlar> List()
        {
            return _departmanDAL.GetAllDepartman();
        }

        public Departmanlar DepartmanGetir(int departmanId)
        {
            return _departmanDAL.GetDepartmanByID(departmanId);
        }

        public List<Departmanlar> DepartmanGelByHastaneID(int hastaneID)
        {
            return _departmanDAL.GetDepartmanByHastaneID(hastaneID);
        }

        public List<Doktorlar> DoktorGetir(int departmanID, int hastaneID)
        {
            return _departmanDAL.GetDoktorByDepartmanIDandHastaneID(departmanID, hastaneID);
        }
       
    }
}

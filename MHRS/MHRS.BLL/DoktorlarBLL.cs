using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MHRS.DAL;
using MHRS.Entities;

namespace MHRS.BLL
{
    public class DoktorlarBLL
    {
        DoktorlarDAL _doktorlarDAL;

        public DoktorlarBLL()
        {
            _doktorlarDAL = new DoktorlarDAL();
        }

        public List<Doktorlar> List()
        {
            return _doktorlarDAL.GetAllDoktor();
        }

        public Doktorlar DoktorGetir(int doktorId)
        {
            return _doktorlarDAL.GetDoktorByID(doktorId);
        }

        public List<Doktorlar> DoktorGetirDepartmanID(int DepartmanID)
        {
            return _doktorlarDAL.GetDoktorlarByDepartmanID(DepartmanID);
        }

     
    }
}

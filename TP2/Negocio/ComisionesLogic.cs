using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Business.Entities;

namespace Negocio
{
    public class ComisionesLogic : BusinessLogic
    {
        private Data.Database.ComisionesAdapter ComisionesData;
        public ComisionesLogic ()
        {
            ComisionesData = new Data.Database.ComisionesAdapter();
        }
        public Comision  GetOne(int ID)
        {
            try
            {
                return ComisionesData.GetOne(ID);
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
        public List<Comision> GetAll()
        {
            try
            {
                return ComisionesData.GetAll();
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
        public void Save(Comision com)
        {
            try
            {
                ComisionesData.Save(com);
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
        public void Delete(int ID)
        {
            try
            {
                ComisionesData.Delete(ID);
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
    }
}

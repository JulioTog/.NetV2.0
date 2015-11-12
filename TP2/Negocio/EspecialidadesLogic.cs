using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data;

namespace Negocio
{
      
    public class EspecialidadesLogic : BusinessLogic
    {
        private Data.Database.EspecialidadesAdapter EspecialidadData;
        public EspecialidadesLogic()
        {
            EspecialidadData = new Data.Database.EspecialidadesAdapter();
        }
     public Especialidad GetOne(int ID)
        {
            try
            {
                return EspecialidadData.GetOne(ID);
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
     public List<Especialidad> GetAll()
     {
         try
         {
             return EspecialidadData.GetAll();
         }
         catch (Exception Ex)
         {
             throw;
         }
     }
     public void Save(Especialidad esp)
     {
         try
         {
             EspecialidadData.Save(esp);
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
             EspecialidadData.Delete(ID);
         }
         catch (Exception Ex)
         {
             throw;
         }
     }
    }
}

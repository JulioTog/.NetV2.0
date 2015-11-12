using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data;

namespace Negocio
{
    public class PlanLogic : BusinessLogic
    {
        private Data.Database.PlanAdapter PlanData;
         public PlanLogic()
        {
            PlanData = new Data.Database.PlanAdapter();
        }
         public Plan GetOne(int ID)
         {
             try
             {
                 return PlanData.GetOne(ID);
             }
             catch (Exception Ex)
             {
                 throw;
             }
         }
         public List<Plan> GetAll()
         {
             try
             {
                 return PlanData.GetAll();
             }
             catch (Exception Ex)
             {
                 throw;
             }
         }
         public void Save(Plan pln)
         {
             try
             {
                 PlanData.Save(pln);
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
                 PlanData.Delete(ID);
             }
             catch (Exception Ex)
             {
                 throw;
             }
         }
    }
}

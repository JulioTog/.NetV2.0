using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data;

namespace Negocio
{
    public class MateriaLogic:BusinessLogic
    {
        private Data.Database.MateriasAdapter MateriaData;
        public MateriaLogic()
        {
            MateriaData = new Data.Database.MateriasAdapter();
        }
        public Materia GetOne(int ID)
        {
            try
            {
                return MateriaData.GetOne(ID);
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
        public List<Materia> GetAll()
        {
            try
            {
                return MateriaData.GetAll();
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
        public void Save(Materia mtr)
        {
            try
            {
                MateriaData.Save(mtr);
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
                MateriaData.Delete(ID);
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
    }
}

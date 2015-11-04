using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data;


namespace Negocio
{
    public class CursoLogic : BusinessLogic
    {
        Data.Database.CursoAdapter CursoData;
        public CursoLogic()
        {
            CursoData = new Data.Database.CursoAdapter();
        }
    public Curso GetOne (int id)
        {
            try
            {
                return CursoData.GetOne( id);
            }
            catch (Exception Ex)
            {
                throw;
            }
        }
    public List<Curso> GetAll()
    {
        try
        {
            return CursoData.GetAll();
        }
        catch (Exception Ex)
        {
            throw;
        }
    }
    public void Save(Curso curso)
    {
        try
        {
            CursoData.Save(curso);
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
                CursoData.Delete(ID);
            }
            catch (Exception Ex)
            {
                throw;
            }
    }
    }
    
}


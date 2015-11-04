using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public  class CursoAdapter:Adapter
    {
       public List<Curso> GetAll()
       {
           List<Curso> cursos = new List<Curso>();
           try
           {
               this.OpenConnection();
               SqlCommand cmdCurso = new SqlCommand("select * from cursos", sqlConn);
               SqlDataReader drCurso = cmdCurso.ExecuteReader();
               while (drCurso.Read())
               {
                   Curso cursorecuperado = new Curso();
                   cursorecuperado.ID = (int)drCurso["id_curso"];
                   cursorecuperado.IDComision = (int)drCurso["id_comision"];
                   cursorecuperado.IDMateria = (int)drCurso["id_materia"];
                   cursorecuperado.AnioCalendario = (int)drCurso["anio_calendario"];
                   cursorecuperado.Cupo = (int)drCurso["cupo"];
                   //Fijarse de agregar descripcion
                   cursos.Add(cursorecuperado);

               }
               drCurso.Close();
           }
           catch (Exception Ex)
           {
               Exception ExcepcionManejada = new Exception("Error al recuperar lista de cursos", Ex);
                throw ExcepcionManejada;
           }
            finally
            {
                this.CloseConnection();
            } 
           return cursos;
       }
       public Curso GetOne(int id)
       {
           Curso cursorecu = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select * from usuarios where id_curso=@id", sqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();

                if (drCurso.Read())
                {
                   cursorecu.ID = (int)drCurso["id_curso"];
                   cursorecu.IDComision = (int)drCurso["id_comision"];
                   cursorecu.IDMateria = (int)drCurso["id_materia"];
                   cursorecu.AnioCalendario = (int)drCurso["anio_calendario"];
                   cursorecu.Cupo = (int)drCurso["cupo"];
                    //Fijarse de agregar descripcion
                }
                drCurso.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return cursorecu;
       }
       public void Delete(int ID)
       {
           try
           {
               this.OpenConnection();
               SqlCommand cmdDelete = new SqlCommand("delete cursos where id_curso=@id", sqlConn);
               cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
               cmdDelete.ExecuteNonQuery();
           }
           catch (Exception Ex)
           {
               Exception ExceptionManejada = new Exception("Error al eliminar curso", Ex);
               throw ExceptionManejada;
           }
           finally
           {
               this.CloseConnection();
           }
       }
       public void Save(Curso curso)
       {
           if (curso.State == BusinessEntity.States.Deleted)
           {
               this.Delete(curso.ID);
           }
           else if (curso.State == BusinessEntity.States.New)
           {
               this.Insert(curso);
           }
           else if (curso.State == BusinessEntity.States.Modified)
           {
               this.Update(curso);
           }
           curso.State = BusinessEntity.States.Unmodified;
       }
       protected void Update(Curso curso)
       {
           try
           {
               this.OpenConnection();
               SqlCommand cmdSave = new SqlCommand(
                   "UPDATE cursos SET " +
                   "anio_calendario = @anio_calendario, cupo = @cupo " +
                   "WHERE id_curso = @id", sqlConn);

               cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
               // cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;
              //  cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
               cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
               cmdSave.Parameters.Add("@cupo", SqlDbType.VarChar, 50).Value = curso.Cupo;
               //Fijarse de agregar descripcion
               cmdSave.ExecuteNonQuery();
           }
           catch (Exception Ex)
           {
               Exception ExcepcionManejada = new Exception("Error al modificar datos del curso", Ex);
               throw ExcepcionManejada;
           }
           finally
           {
               this.CloseConnection();
           }
       }
       protected void Insert(Curso curso)
       {
           try
           {
               this.OpenConnection();
               SqlCommand cmdSave = new SqlCommand(
                   "insert into cursos(id_materia,id_comision,anio_calendario,cupo) " +
                   "values(@id_materia,@id_comision,@anio_calendario,@cupo) " +
                   "select @@identity", sqlConn);

               cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;
               cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
               cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
               cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;             
               curso.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
           }
           catch (Exception Ex)
           {
               Exception ExcepcionManejada = new Exception("Error al crear curso", Ex);
               throw ExcepcionManejada;
           }
           finally
           {
               this.CloseConnection();
           }
       }
            
    }
}

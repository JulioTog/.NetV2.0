using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class PlanAdapter: Adapter
    {
        public List<Plan> GetAll()
        {
            List<Plan> plan = new List<Plan>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("select * from planes", sqlConn);
                SqlDataReader drPlan = cmdPlan.ExecuteReader();

                while (drPlan.Read())
                {
                    Plan pln = new Plan();
                    pln.ID = (int)drPlan["id_plan"];
                    pln.Descripcion = (string)drPlan["desc_plan"];
                    pln.IDEspecialidad = (int)drPlan["id_especialidad"];
                    

                    plan.Add(pln);
                }
                drPlan.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de planes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return plan;
        }
        public Business.Entities.Plan GetOne(int ID)
        {
            Plan pln = new Plan();
            try
            {
                this.OpenConnection();

                SqlCommand cmdPlan = new SqlCommand("select * from planes where id_plan=@id", sqlConn);
                cmdPlan.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPlan = cmdPlan.ExecuteReader();

                if (drPlan.Read())
                {
                    pln.ID = (int)drPlan["id_plan"];
                    pln.Descripcion = (string)drPlan["desc_plan"];
                    pln.IDEspecialidad = (int)drPlan["id_especialidad"];                    
                }
                drPlan.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return pln;
        }
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete planes where id_plan=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExceptionManejada = new Exception("Error al eliminar plan", Ex);
                throw ExceptionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE planes SET desc_plan = @desc_plan, id_especialidad = @id_especialidad, " +                    
                    "WHERE id_plan = @id", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;               
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "insert into planes(desc_plan,id_especialidad) " +
                    "values(@desc_plan,@id_especialidad) " +
                    "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;                
                plan.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}

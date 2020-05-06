using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Mesa
    {
        SqlConnection _conexion;

        public Dao_Mesa()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_MesaSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual DataSet SelectAvailability(int ID_Local)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_Mesa_SelectAvailability";
            
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Local", ID_Local);
            _adapter.SelectCommand = _command;
            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual string Insert(T_Mesa _mesa)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_MesaInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Cantidad", _mesa.Cantidad);
                _command.Parameters.AddWithValue("Descripcion", _mesa.Descripcion);
                _command.Parameters.AddWithValue("Id_Mesa", _mesa.Id_Mesa);
                _command.Parameters.AddWithValue("Imagen", _mesa.Imagen);
                _command.Parameters.AddWithValue("Height", _mesa.Height);
                _command.Parameters.AddWithValue("Width", _mesa.Width);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nueva mesa registrada";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                _command.Connection.Close();
            }
        }
        public virtual string Update(T_Mesa _mesa)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_MesaUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Cantidad", _mesa.Cantidad);
                _command.Parameters.AddWithValue("Descripcion", _mesa.Descripcion);
                _command.Parameters.AddWithValue("Id_Mesa", _mesa.Id_Mesa);
                _command.Parameters.AddWithValue("Imagen", _mesa.Imagen);
                _command.Parameters.AddWithValue("Height", _mesa.Height);
                _command.Parameters.AddWithValue("Width", _mesa.Width);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Modificación realizada";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                _command.Connection.Close();
            }
        }
        public virtual string Delete(int _idmesa)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_MesaDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Mesa", _idmesa);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Modificación realizada";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                _command.Connection.Close();
            }
        }
    }
}


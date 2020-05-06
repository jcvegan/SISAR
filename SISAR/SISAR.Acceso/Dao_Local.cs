using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Local
    {
        SqlConnection _conexion;

        public Dao_Local()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_LocalSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }

        public virtual T_Local Select(int _idLocal)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            T_Local _local = new T_Local();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_LocalSelect";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Local", _idLocal);
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            DataRowView _drv = _data.Tables[0].DefaultView[0];
            _command.Connection.Close();
            _local.Id_Local = Convert.ToInt32(_drv["Id_Local"]);
            _local.Nombre = Convert.ToString(_drv["Nombre"]);
            _local.Direccion = Convert.ToString(_drv["Direccion"]);
            _local.Telefono = Convert.ToInt32(_drv["Telefono"]);
            return _local;
        }
        public virtual string Insert(T_Local _Local)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_LocalInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Direccion", _Local.Direccion);
                _command.Parameters.AddWithValue("Nombre", _Local.Nombre);
                _command.Parameters.AddWithValue("Telefono", _Local.Telefono);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nueva Local registrada";
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
        public virtual string Update(T_Local _Local)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_LocalUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Direccion", _Local.Direccion);
                _command.Parameters.AddWithValue("Id_Local", _Local.Id_Local);
                _command.Parameters.AddWithValue("Nombre", _Local.Nombre);
                _command.Parameters.AddWithValue("Telefono", _Local.Telefono);
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
        public virtual string Delete(int _idLocal)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_LocalDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Local", _idLocal);
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



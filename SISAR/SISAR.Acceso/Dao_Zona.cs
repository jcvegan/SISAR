using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Zona
    {
        SqlConnection _conexion;

        public Dao_Zona()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_ZonaSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public DataSet SelectAllById_Local(int _idLocal)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_ZonaSelectAllById_Local";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Local", _idLocal);
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual string Insert(T_Zona _zona)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_ZonaInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Descripcion", _zona.Descripcion);
                _command.Parameters.AddWithValue("Id_Local", _zona.Id_Local);
                _command.Parameters.AddWithValue("Nombre", _zona.Nombre);
                _command.Parameters.AddWithValue("Aforo", _zona.Aforo);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nueva zona registrada";
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
        public virtual string Update(T_Zona _zona)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_ZonaUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Descripcion", _zona.Descripcion);
                _command.Parameters.AddWithValue("Id_Local", _zona.Id_Local);
                _command.Parameters.AddWithValue("Id_Zona", _zona.Id_Zona);
                _command.Parameters.AddWithValue("Nombre", _zona.Nombre);
                _command.Parameters.AddWithValue("Aforo", _zona.Aforo);
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
        public virtual string Delete(int _idzona)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_ZonaDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Zona", _idzona);
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


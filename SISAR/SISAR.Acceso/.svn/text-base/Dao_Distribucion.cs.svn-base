using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Distribucion
    {
        SqlConnection _conexion;

        public Dao_Distribucion()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_DistribucionSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public DataSet SelectAllById_Zona(int _idZona)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_DistribucionSelectAllById_Zona";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Zona", _idZona);
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual string Insert(T_Distribucion _distribucion)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_DistribucionInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Descripcion", _distribucion.Descripcion);
                _command.Parameters.AddWithValue("Id_Zona", _distribucion.Id_Zona);
                _command.Parameters.AddWithValue("Nombre", _distribucion.Nombre);
                _command.Parameters.AddWithValue("Estado", _distribucion.Estado);
                _command.Connection.Open();
                _distribucion.Id_Distribucion = Convert.ToInt32(_command.ExecuteScalar().ToString());
                return "Nueva distribución registrada";
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
        public virtual string Update(T_Distribucion _distribucion)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_DistribucionUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Descripcion", _distribucion.Descripcion);
                _command.Parameters.AddWithValue("Id_Distribucion", _distribucion.Id_Distribucion);
                _command.Parameters.AddWithValue("Id_Zona", _distribucion.Id_Zona);
                _command.Parameters.AddWithValue("Nombre", _distribucion.Nombre);
                _command.Parameters.AddWithValue("Estado", _distribucion.Estado);
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
        public virtual string Delete(int _iddistribucion)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_DistribucionDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Distribucion", _iddistribucion);
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


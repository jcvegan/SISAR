using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_DistribucionxMesa
    {
        SqlConnection _conexion;

        public Dao_DistribucionxMesa()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_DistribucionxMesaSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual DataSet SelectAllById_Distribucion(int _IdDistribucionxMesa)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_DistribucionxMesaSelectAllById_Distribucion";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Distribucion", _IdDistribucionxMesa);
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public string DeleteAllById_Distribucion(int _IdDistribucionxMesa)
        {
            SqlCommand _command = null;
            try
            {
                SqlDataAdapter _adapter = new SqlDataAdapter();
                _command = new SqlCommand();
                DataSet _data = new DataSet();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_DistribucionxMesaDeleteAllById_Distribucion";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Distribucion", _IdDistribucionxMesa);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                _command.Connection.Close();
                return "Nueva distribucion por mesa eliminada";
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
        public virtual string Insert(T_DistribucionxMesa _distribucionxMesa)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_DistribucionxMesaInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Estado", _distribucionxMesa.Estado);
                _command.Parameters.AddWithValue("Id_Distribucion", _distribucionxMesa.Id_Distribucion);
                _command.Parameters.AddWithValue("Id_Mesa", _distribucionxMesa.Id_Mesa);
                _command.Parameters.AddWithValue("Numero_Mesa", _distribucionxMesa.Numero_Mesa);
                _command.Parameters.AddWithValue("Posicion_X", _distribucionxMesa.Posicion_X);
                _command.Parameters.AddWithValue("Posicion_Y", _distribucionxMesa.Posicion_Y);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nueva distribucion por mesa registrada";
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
        public virtual string Update(T_DistribucionxMesa _distribucionxMesa)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_DistribucionxMesaUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Estado", _distribucionxMesa.Estado);
                _command.Parameters.AddWithValue("Id_Codigo_Mesa", _distribucionxMesa.Id_Codigo_Mesa);
                _command.Parameters.AddWithValue("Id_Distribucion", _distribucionxMesa.Id_Distribucion);
                _command.Parameters.AddWithValue("Id_Mesa", _distribucionxMesa.Id_Mesa);
                _command.Parameters.AddWithValue("Numero_Mesa", _distribucionxMesa.Numero_Mesa);
                _command.Parameters.AddWithValue("Posicion_X", _distribucionxMesa.Posicion_X);
                _command.Parameters.AddWithValue("Posicion_Y", _distribucionxMesa.Posicion_Y);
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


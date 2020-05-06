using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Tipo_Cambio
    {
        SqlConnection _conexion;

        public Dao_Tipo_Cambio()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_Tipo_CambioSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual string Insert(T_Tipo_Cambio _tipo_Cambio)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Tipo_CambioInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Tipo_Cambio", _tipo_Cambio.Id_Tipo_Cambio);
                _command.Parameters.AddWithValue("Cantidad", _tipo_Cambio.Cantidad);
                _command.Parameters.AddWithValue("Fecha_TC", _tipo_Cambio.Fecha_TC);
                _command.Parameters.AddWithValue("Id_Moneda", _tipo_Cambio.Id_Moneda);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nuevo tipo de cambio registrado";
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
        public virtual string Update(T_Tipo_Cambio _tipo_Cambio)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Tipo_CambioUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Tipo_Cambio", _tipo_Cambio.Id_Tipo_Cambio);
                _command.Parameters.AddWithValue("Cantidad", _tipo_Cambio.Cantidad);
                _command.Parameters.AddWithValue("Fecha_TC", _tipo_Cambio.Fecha_TC);
                _command.Parameters.AddWithValue("Id_Moneda", _tipo_Cambio.Id_Moneda);
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
        public virtual string Delete(int _idtipo_Cambio)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Tipo_CambioDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Tipo_Cambio", _idtipo_Cambio);
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


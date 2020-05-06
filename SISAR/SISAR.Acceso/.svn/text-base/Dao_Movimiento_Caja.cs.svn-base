using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Movimiento_Caja
    {
        SqlConnection _conexion;

        public Dao_Movimiento_Caja()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_Movimiento_CajaSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual string Insert(T_Moviemiento_Caja _movimiento_Caja)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Moviemiento_CajaInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Fecha_Emision", _movimiento_Caja.Fecha_Emision);
                _command.Parameters.AddWithValue("Id_Cliente", _movimiento_Caja.Id_Cliente);
                _command.Parameters.AddWithValue("Id_Empleado", _movimiento_Caja.Id_Empleado);
                _command.Parameters.AddWithValue("Id_Movimiento_Caja", _movimiento_Caja.Id_Movimiento_Caja);
                _command.Parameters.AddWithValue("IGV", _movimiento_Caja.IGV);
                _command.Parameters.AddWithValue("Tipo_Movimiento", _movimiento_Caja.Tipo_Movimiento);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nuevo Movimiento de caja registrado";
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
        public virtual string Update(T_Moviemiento_Caja _movimiento_Caja)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Movimiento_CajaUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Fecha_Emision", _movimiento_Caja.Fecha_Emision);
                _command.Parameters.AddWithValue("Id_Cliente", _movimiento_Caja.Id_Cliente);
                _command.Parameters.AddWithValue("Id_Empleado", _movimiento_Caja.Id_Empleado);
                _command.Parameters.AddWithValue("Id_Movimiento_Caja", _movimiento_Caja.Id_Movimiento_Caja);
                _command.Parameters.AddWithValue("IGV", _movimiento_Caja.IGV);
                _command.Parameters.AddWithValue("Tipo_Movimiento", _movimiento_Caja.Tipo_Movimiento);
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
        public virtual string Delete(int _idmovimiento_Caja)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Movimiento_CajaDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Movimiento_Caja", _idmovimiento_Caja);
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Detalle_Movimiento_Caja
    {
        SqlConnection _conexion;

        public Dao_Detalle_Movimiento_Caja()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_Detalle_Movimiento_CajaSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual string Insert(T_Detalle_Movimiento_Caja _detalle_Movimiento_Caja)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Detalle_Movimiento_CajaInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Cantidad", _detalle_Movimiento_Caja.Cantidad);
                _command.Parameters.AddWithValue("Id_Detalle_Movimiento_Caja", _detalle_Movimiento_Caja.Id_Detalle_Movimiento_Caja);
                _command.Parameters.AddWithValue("Id_Movimiento_Caja", _detalle_Movimiento_Caja.Id_Movimiento_Caja);
                _command.Parameters.AddWithValue("Id_Producto", _detalle_Movimiento_Caja.Id_Producto);
                _command.Parameters.AddWithValue("SubTotal", _detalle_Movimiento_Caja.SubTotal);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nuevo detalle de movimiento de caja registrado";
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
        public virtual string Update(T_Detalle_Movimiento_Caja _detalle_Movimiento_Caja)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Detalle_Movimiento_CajaUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Cantidad", _detalle_Movimiento_Caja.Cantidad);
                _command.Parameters.AddWithValue("Id_Detalle_Movimiento_Caja", _detalle_Movimiento_Caja.Id_Detalle_Movimiento_Caja);
                _command.Parameters.AddWithValue("Id_Movimiento_Caja", _detalle_Movimiento_Caja.Id_Movimiento_Caja);
                _command.Parameters.AddWithValue("Id_Producto", _detalle_Movimiento_Caja.Id_Producto);
                _command.Parameters.AddWithValue("SubTotal", _detalle_Movimiento_Caja.SubTotal);
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
        public virtual string Delete(int _iddetalle_Movimiento_Caja)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Detalle_Movimiento_CajaDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Detalle_Movimient_Cajao", _iddetalle_Movimiento_Caja);
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


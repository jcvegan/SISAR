using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Detalle_Pedido
    {
        SqlConnection _conexion;

        public Dao_Detalle_Pedido()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_Detalle_PedidoSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual DataSet SelectAllById_ZonaAndNumero_Mesa(int _id_Zona, int _numero_Mesa)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_Detalle_PedidoSelectAllById_ZonaAndNumero_Mesa";
            _command.Parameters.AddWithValue("Id_Zona", _id_Zona);
            _command.Parameters.AddWithValue("Numero_Mesa", _numero_Mesa);
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual DataSet SelectAllById_Local(int _idLocal)
        {
            try
            {
                SqlDataAdapter _adapter = new SqlDataAdapter();
                SqlCommand _command = new SqlCommand();
                DataSet _data = new DataSet();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Detalle_PedidoSelectAllById_Local";
                _command.Parameters.AddWithValue("Id_Local", _idLocal);
                _command.CommandType = CommandType.StoredProcedure;
                _adapter.SelectCommand = _command;

                _adapter.Fill(_data);
                _command.Connection.Close();
                return _data;
            }
            catch
            {
                return null;
            }
        }
        public virtual string Insert(T_Detalle_Pedido _detalle_Pedido)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Detalle_PedidoInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Estado", _detalle_Pedido.Estado);
                _command.Parameters.AddWithValue("Id_Detalle_Pedido", _detalle_Pedido.Id_Detalle_Pedido);
                _command.Parameters.AddWithValue("Id_Pedido", _detalle_Pedido.Id_Pedido);
                _command.Parameters.AddWithValue("Id_Producto", _detalle_Pedido.Id_Producto);
                _command.Parameters.AddWithValue("Observacion", _detalle_Pedido.Observacion);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nuevo detalle de pedido registrado";
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
        public virtual string Update(T_Detalle_Pedido _detalle_Pedido)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Detalle_PedidoUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Estado", _detalle_Pedido.Estado);
                _command.Parameters.AddWithValue("Id_Detalle_Pedido", _detalle_Pedido.Id_Detalle_Pedido);
                _command.Parameters.AddWithValue("Id_Pedido", _detalle_Pedido.Id_Pedido);
                _command.Parameters.AddWithValue("Id_Producto", _detalle_Pedido.Id_Producto);
                _command.Parameters.AddWithValue("Observacion", _detalle_Pedido.Observacion);
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
        public virtual string UpdateEstado(T_Detalle_Pedido _detalle_Pedido)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Detalle_PedidoUpdateEstado";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Estado", _detalle_Pedido.Estado);
                _command.Parameters.AddWithValue("Id_Detalle_Pedido", _detalle_Pedido.Id_Detalle_Pedido);
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
        public virtual string Delete(int _iddetalle_Pedido)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Detalle_PedidoDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Detalle_Pedido", _iddetalle_Pedido);
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


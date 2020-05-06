using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_ProductoxLocal
    {
        SqlConnection _conexion;

        public Dao_ProductoxLocal()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_Producto_LocalSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual string Insert(T_ProductoxLocal _productoxLocal)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Producto_LocalInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Estado", _productoxLocal.Estado);
                _command.Parameters.AddWithValue("Id_Producto", _productoxLocal.Id_Producto);
                _command.Parameters.AddWithValue("Id_Local", _productoxLocal.Id_Local);
                _command.Parameters.AddWithValue("Stock", _productoxLocal.Stock);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nuevo producto por Local registrado";
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
        public virtual string Update(T_ProductoxLocal _productoxLocal)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Producto_LocalUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Estado", _productoxLocal.Estado);
                _command.Parameters.AddWithValue("Id_Producto", _productoxLocal.Id_Producto);
                _command.Parameters.AddWithValue("Id_Local", _productoxLocal.Id_Local);
                _command.Parameters.AddWithValue("Stock", _productoxLocal.Stock);
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
        public virtual string Delete(int _idproducto_Local)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_Producto_LocalDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Producto_Local", _idproducto_Local);
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

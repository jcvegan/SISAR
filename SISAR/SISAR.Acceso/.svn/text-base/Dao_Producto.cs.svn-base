using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SISAR.Acceso
{
    public class Dao_Producto
    {
        SqlConnection _conexion;

        public Dao_Producto()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_ProductoSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual DataSet SelectAllMenu()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_ProductoSelectAllMenu";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual T_Producto Select(int _idProducto)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            T_Producto _producto = new T_Producto();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_ProductoSelect";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Producto", _idProducto);
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            DataRowView _drv = _data.Tables[0].DefaultView[0];
            _command.Connection.Close();
            _producto.Descripcion = Convert.ToString(_drv["Descripcion"]);
            _producto.Id_Categoria = Convert.ToInt32(_drv["Id_Categoria"]);
            _producto.Id_Moneda = Convert.ToInt32(_drv["Id_Moneda"]);
            _producto.Id_Producto = Convert.ToInt32(_drv["Id_Producto"]);
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, _drv["Imagen"]);
            _producto.Imagen = ms.ToArray();
            _producto.Nombre = Convert.ToString(_drv["Nombre"]);
            _producto.Observacion = Convert.ToString(_drv["Observacion"]);
            _producto.PrecioUnitario = Convert.ToDecimal(_drv["PrecioUnitario"]);


            _command.Connection.Close();
            return _producto;
        }
        public virtual string Insert(T_Producto _producto)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_ProductoInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Descripcion", _producto.Descripcion);
                _command.Parameters.AddWithValue("Id_Categoria", _producto.Id_Categoria);
                _command.Parameters.AddWithValue("Id_Moneda", _producto.Id_Moneda);
                _command.Parameters.AddWithValue("Imagen", _producto.Imagen);
                _command.Parameters.AddWithValue("Nombre", _producto.Nombre);
                _command.Parameters.AddWithValue("Observacion", _producto.Observacion);
                _command.Parameters.AddWithValue("PrecioUnitario", _producto.PrecioUnitario);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nuevo producto registrado";
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
        public virtual string Update(T_Producto _producto)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_ProductoUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Producto", _producto.Id_Producto);
                _command.Parameters.AddWithValue("Descripcion", _producto.Descripcion);
                _command.Parameters.AddWithValue("Id_Categoria", _producto.Id_Categoria);
                _command.Parameters.AddWithValue("Id_Moneda", _producto.Id_Moneda);
                _command.Parameters.AddWithValue("Imagen", _producto.Imagen);
                _command.Parameters.AddWithValue("Nombre", _producto.Nombre);
                _command.Parameters.AddWithValue("Observacion", _producto.Observacion);
                _command.Parameters.AddWithValue("PrecioUnitario", _producto.PrecioUnitario);
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
        public virtual string Delete(int _idproducto)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_ProductoDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Producto", _idproducto);
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
        public DataSet SelectByCategory(int _category)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_ProductoSelectAllById_Categoria";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Categoria", _category);
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }

        public DataSet SelectByCategoryPersonalizado(int _category, int _local)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_SelectProductoxCategoria";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Categoria", _category);
            _command.Parameters.AddWithValue("Id_Local", _local);
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
    }
}


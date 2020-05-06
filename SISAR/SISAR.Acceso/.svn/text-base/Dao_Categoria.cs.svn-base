using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Categoria
    {
        SqlConnection _conexion;

        public Dao_Categoria()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_CategoriaSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual DataSet SelectAllCategorias()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_CategoriaSelectAllCategorias";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual DataSet SelectAllByCategoria_Padre(int _categoriaPadre)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_CategoriaSelectAllByCategoria_Padre";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Categoria_Padre", _categoriaPadre);
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual T_Categoria Select(int _idCategoria)
        {
            SqlDataAdapter _Adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            T_Categoria _categoria = new T_Categoria();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_CategoriaSelect";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Categoria", _idCategoria);
            _Adapter.SelectCommand = _command;

            _Adapter.Fill(_data);
            DataRowView _drv = _data.Tables[0].DefaultView[0];
            _command.Connection.Close();
            _categoria.Categoria_Padre = Convert.ToInt32(0+_drv["Categoria_Padre"].ToString());
            _categoria.Descripcion = Convert.ToString(_drv["Descripcion"]);
            _categoria.Id_Categoria = Convert.ToInt32(_drv["Id_Categoria"]);
            _categoria.Nombre = Convert.ToString(_drv["Nombre"]);
            return _categoria;
        }
        public virtual string Insert(T_Categoria _categoria)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_CategoriaInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Categoria_Padre", _categoria.Categoria_Padre);
                _command.Parameters.AddWithValue("Descripcion", _categoria.Descripcion);
                _command.Parameters.AddWithValue("Nombre", _categoria.Nombre);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nueva categoria registrado";
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
        public virtual string Update(T_Categoria _categoria)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_CategoriaUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Categoria_Padre", _categoria.Categoria_Padre);
                _command.Parameters.AddWithValue("Descripcion", _categoria.Descripcion);
                _command.Parameters.AddWithValue("Id_Categoria", _categoria.Id_Categoria);
                _command.Parameters.AddWithValue("Nombre", _categoria.Nombre);
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
        public virtual string Delete(int _idCategoria)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_CategoriaDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Usuario", _idCategoria);
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

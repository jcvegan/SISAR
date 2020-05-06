using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Usuario
    {
        SqlConnection _conexion;

        public Dao_Usuario()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_UsuarioSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual DataSet SelectAllEmployee()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_UsuarioSelectAllEmployee";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual DataSet SelectAllById_Perfil(int _idPerfil)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_UsuarioSelectAllById_Perfil";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Perfil", _idPerfil);
            _adapter.SelectCommand = _command;
            
            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual string Insert(T_Usuario _usuario)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_UsuarioInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Apellidos", _usuario.Apellidos);
                _command.Parameters.AddWithValue("Contraseña", _usuario.Contraseña);
                _command.Parameters.AddWithValue("Direccion", _usuario.Direccion);
                _command.Parameters.AddWithValue("Email", _usuario.Email);
                _command.Parameters.AddWithValue("Estado", _usuario.Estado);
                _command.Parameters.AddWithValue("Fecha_Nacimiento", _usuario.Fecha_Nacimiento);
                _command.Parameters.AddWithValue("Fecha_Registro", _usuario.Fecha_Registro);
                _command.Parameters.AddWithValue("Id_Perfil", _usuario.Id_Perfil);
                _command.Parameters.AddWithValue("Id_Local", _usuario.Id_Local);
                _command.Parameters.AddWithValue("Id_Usuario", _usuario.Id_Usuario);
                _command.Parameters.AddWithValue("Nombres", _usuario.Nombres);
                _command.Parameters.AddWithValue("Telefono", _usuario.Telefono);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nuevo usuario registrado";
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
        public virtual string Update(T_Usuario _usuario)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_UsuarioUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Apellidos", _usuario.Apellidos);
                _command.Parameters.AddWithValue("Contraseña", _usuario.Contraseña);
                _command.Parameters.AddWithValue("Direccion", _usuario.Direccion);
                _command.Parameters.AddWithValue("Email", _usuario.Email);
                _command.Parameters.AddWithValue("Estado", _usuario.Estado);
                _command.Parameters.AddWithValue("Fecha_Nacimiento", _usuario.Fecha_Nacimiento);
                _command.Parameters.AddWithValue("Fecha_Registro", _usuario.Fecha_Registro);
                _command.Parameters.AddWithValue("Id_Perfil", _usuario.Id_Perfil);
                _command.Parameters.AddWithValue("Id_Local", _usuario.Id_Local);
                _command.Parameters.AddWithValue("Id_Usuario", _usuario.Id_Usuario);
                _command.Parameters.AddWithValue("Nombres", _usuario.Nombres);
                _command.Parameters.AddWithValue("Telefono", _usuario.Telefono);
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
        public virtual string Delete(int _dniUsuario)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_UsuarioDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Usuario", _dniUsuario);
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

        public virtual T_Usuario Authenticate(int _idUsuario, string _password)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_UsuarioAuthenticate";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Usuario", _idUsuario);
            _command.Parameters.AddWithValue("Contraseña", _password);
            _adapter.SelectCommand = _command;
            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            T_Usuario _user = new T_Usuario();
            _user.Nombres = ds.Tables[0].Rows[0][1].ToString();
            _user.Apellidos = ds.Tables[0].Rows[0][2].ToString();
            _user.Email = ds.Tables[0].Rows[0][3].ToString();
            _user.Fecha_Nacimiento = DateTime.Parse(ds.Tables[0].Rows[0][4].ToString());
            _user.Contraseña = ds.Tables[0].Rows[0][5].ToString();
            _user.Estado = ds.Tables[0].Rows[0][6].ToString();
            //_user.Id_Local = int.Parse(ds.Tables[0].Rows[0][7].ToString());
            _user.Id_Perfil = int.Parse(ds.Tables[0].Rows[0][8].ToString());
            _user.Direccion = ds.Tables[0].Rows[0][9].ToString();
            _user.Telefono = ds.Tables[0].Rows[0][10].ToString();
            //_user.Fecha_Registro = DateTime.Parse(ds.Tables[0].Rows[0][11].ToString());
            return _user;
        }
    }
}

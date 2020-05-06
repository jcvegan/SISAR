using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Perfil
    {
        SqlConnection _conexion;

        public Dao_Perfil()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_PerfilSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual T_Perfil Select(int _idPerfil)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            T_Perfil _perfil = new T_Perfil();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_PerfilSelect";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Perfil", _idPerfil);
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            DataRowView _drv = _data.Tables[0].DefaultView[0];
            _command.Connection.Close();
            _perfil.Id_Perfil = Convert.ToInt32(_drv["Id_Perfil"]);
            _perfil.Nombre = Convert.ToString(_drv["Nombre"]);
            _perfil.Descripcion = Convert.ToString(_drv["Descripcion"]);
            return _perfil;
        }
        public virtual DataSet SelectAllforEmploye()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_PerfilSelectAllforEmploye";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual string Insert(T_Perfil _perfil)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_PerfilInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Descripcion", _perfil.Descripcion);
                _command.Parameters.AddWithValue("Nombre", _perfil.Nombre);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nuevo perfil registrado";
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
        public virtual string Update(T_Perfil _perfil)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_PerfilUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Perfil", _perfil.Id_Perfil);
                _command.Parameters.AddWithValue("Descripcion", _perfil.Descripcion);
                _command.Parameters.AddWithValue("Nombre", _perfil.Nombre);
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
        public virtual string Delete(int _idperfil)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_PerfilDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Perfil", _idperfil);
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


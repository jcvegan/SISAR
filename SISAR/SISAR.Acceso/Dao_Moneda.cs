using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Moneda
    {
        SqlConnection _conexion;

        public Dao_Moneda()
        {
            _conexion = new SqlConnection(Conexion.CadConexion);
        }

        public virtual DataSet SelectAll()
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_MonedaSelectAll";
            _command.CommandType = CommandType.StoredProcedure;
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            _command.Connection.Close();
            return _data;
        }
        public virtual T_Moneda Select(int _idMoneda)
        {
            SqlDataAdapter _adapter = new SqlDataAdapter();
            SqlCommand _command = new SqlCommand();
            DataSet _data = new DataSet();
            T_Moneda _moneda = new T_Moneda();
            _command.Connection = _conexion;
            _command.CommandText = "sp_T_MonedaSelect";
            _command.CommandType = CommandType.StoredProcedure;
            _command.Parameters.AddWithValue("Id_Moneda", _idMoneda);
            _adapter.SelectCommand = _command;

            _adapter.Fill(_data);
            DataRowView _drv = _data.Tables[0].DefaultView[0];
            _command.Connection.Close();
            _moneda.Id_Moneda = Convert.ToInt32(_drv["Id_Moneda"]);
            _moneda.Nombre = Convert.ToString(_drv["Nombre"]);
            _moneda.Simbolo = Convert.ToString(_drv["Simbolo"]);
            return _moneda;
        }
        public virtual string Insert(T_Moneda _moneda)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_MonedaInsert";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Moneda", _moneda.Id_Moneda);
                _command.Parameters.AddWithValue("Nombre", _moneda.Nombre);
                _command.Parameters.AddWithValue("Simbolo", _moneda.Simbolo);
                _command.Connection.Open();
                _command.ExecuteNonQuery();
                return "Nueva moneda registrada";
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
        public virtual string Update(T_Moneda _moneda)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_MonedaUpdate";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Moneda", _moneda.Id_Moneda);
                _command.Parameters.AddWithValue("Nombre", _moneda.Nombre);
                _command.Parameters.AddWithValue("Simbolo", _moneda.Simbolo);
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
        public virtual string Delete(int _idmoneda)
        {
            SqlCommand _command = null;
            try
            {
                _command = new SqlCommand();
                _command.Connection = _conexion;
                _command.CommandText = "sp_T_MonedaDelete";
                _command.CommandType = CommandType.StoredProcedure;
                _command.Parameters.AddWithValue("Id_Moneda", _idmoneda);
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


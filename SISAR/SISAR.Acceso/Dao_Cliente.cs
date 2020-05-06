using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace SISAR.Acceso
{
    public class Dao_Cliente
    {

        Dao_Usuario _usuario;
        
        public Dao_Cliente()
        {
            _usuario = new Dao_Usuario();
        }

        public virtual DataSet SelectAll()
        {
            return this._usuario.SelectAllById_Perfil(T_Usuario.IDPERFILPERSONANATURAL);
        }
        public virtual string Insert(T_Usuario _usuario)
        {
            _usuario.Id_Perfil = T_Usuario.IDPERFILPERSONANATURAL;
            return this._usuario.Insert(_usuario);
        }
        public virtual string Update(T_Usuario _usuario)
        {
            _usuario.Id_Perfil = T_Usuario.IDPERFILPERSONANATURAL;
            return this._usuario.Update(_usuario);
        }
        public virtual string Delete(int _dniUsuario) 
        {
            return this._usuario.Delete(_dniUsuario);
        }
    }
}

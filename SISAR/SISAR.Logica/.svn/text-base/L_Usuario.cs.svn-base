using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Usuario
    {
        Dao_Usuario _usuario;

        public L_Usuario()
        {
            _usuario = new Dao_Usuario();
        }

        public virtual DataSet SelectAll()
        {
            return this._usuario.SelectAll();
        }    
        public virtual DataSet SelectAllEmployee()
        {
            return this._usuario.SelectAllEmployee();
        }       
        public virtual string Insert(T_Usuario _usuario)
        {
            return this._usuario.Insert(_usuario);
        }
        public virtual string Update(T_Usuario _usuario)
        {
            return this._usuario.Update(_usuario);
        }
        public virtual string Delete(int _idUsuario)
        {
            return this._usuario.Delete(_idUsuario);
        }
        public virtual T_Usuario Authenticate(int _idUsuario, string _password)
        {
            return this._usuario.Authenticate(_idUsuario, _password);
        }
    }
}


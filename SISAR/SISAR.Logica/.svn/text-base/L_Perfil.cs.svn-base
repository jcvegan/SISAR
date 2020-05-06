using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Perfil
    {
        Dao_Perfil _perfil;

        public L_Perfil()
        {
            _perfil = new Dao_Perfil();
        }

        public virtual DataSet SelectAll()
        {
            return this._perfil.SelectAll();
        }
        public virtual T_Perfil Select(int _idPerfil)
        {
            return this._perfil.Select(_idPerfil);
        }
        public virtual DataSet SelectAllforEmploye()
        {
            return this._perfil.SelectAllforEmploye();
        }       
        public virtual string Insert(T_Perfil _perfil)
        {
            return this._perfil.Insert(_perfil);
        }
        public virtual string Update(T_Perfil _perfil)
        {
            return this._perfil.Update(_perfil);
        }
        public virtual string Delete(int _idPerfil)
        {
            return this._perfil.Delete(_idPerfil);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_PerfilxPermiso
    {
        Dao_PerfilxPermiso _perfilxPermiso;

        public L_PerfilxPermiso()
        {
            _perfilxPermiso = new Dao_PerfilxPermiso();
        }

        public virtual DataSet SelectAllById_Perfil(int _perfilID)
        {
            return this._perfilxPermiso.SelectAllById_Perfil(_perfilID);
        }
    }
}


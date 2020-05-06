using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Permiso
    {
        Dao_Permiso _permiso;

        public L_Permiso()
        {
            _permiso = new Dao_Permiso();
        }

        public virtual DataSet SelectAll()
        {
            return this._permiso.SelectAll();
        }       
        public virtual string Insert(T_Permiso _permiso)
        {
            return this._permiso.Insert(_permiso);
        }
        public virtual string Update(T_Permiso _permiso)
        {
            return this._permiso.Update(_permiso);
        }
        public virtual string Delete(int _idPermiso)
        {
            return this._permiso.Delete(_idPermiso);
        }
    }
}


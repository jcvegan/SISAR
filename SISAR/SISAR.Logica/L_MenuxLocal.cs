using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_MenuxLocal
    {
        Dao_MenuxLocal _menuxLocal;

        public L_MenuxLocal()
        {
            _menuxLocal = new Dao_MenuxLocal();
        }

        public virtual DataSet SelectAll()
        {
            return this._menuxLocal.SelectAll();
        }       
        public virtual string Insert(T_MenuxLocal _menuxLocal)
        {
            return this._menuxLocal.Insert(_menuxLocal);
        }
        public virtual string Update(T_MenuxLocal _menuxLocal)
        {
            return this._menuxLocal.Update(_menuxLocal);
        }
    }
}


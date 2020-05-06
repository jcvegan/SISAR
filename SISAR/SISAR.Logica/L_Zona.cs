using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Zona
    {
        Dao_Zona _zona;

        public L_Zona()
        {
            _zona = new Dao_Zona();
        }

        public virtual DataSet SelectAll()
        {
            return this._zona.SelectAll();
        }
        public virtual DataSet SelectAllById_Local(int _idLocal)
        {
            return this._zona.SelectAllById_Local(_idLocal);
        }    
        public virtual string Insert(T_Zona _zona)
        {
            return this._zona.Insert(_zona);
        }
        public virtual string Update(T_Zona _zona)
        {
            return this._zona.Update(_zona);
        }
        public virtual string Delete(int _idZona)
        {
            return this._zona.Delete(_idZona);
        }

    }
}


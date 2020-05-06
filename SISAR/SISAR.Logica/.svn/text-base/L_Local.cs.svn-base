using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Local
    {
        Dao_Local _local;

        public L_Local()
        {
            _local = new Dao_Local();
        }

        public virtual DataSet SelectAll()
        {
            return this._local.SelectAll();
        }
        public virtual T_Local Select(int _idLocal)
        {
            return this._local.Select(_idLocal);
        }
        public virtual string Insert(T_Local _Local)
        {
            return this._local.Insert(_Local);
        }
        public virtual string Update(T_Local _Local)
        {
            return this._local.Update(_Local);
        }
        public virtual string Delete(int _idLocal)
        {
            return this._local.Delete(_idLocal);
        }
    }
}


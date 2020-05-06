using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Moneda
    {
        Dao_Moneda _moneda;

        public L_Moneda()
        {
            _moneda = new Dao_Moneda();
        }

        public virtual DataSet SelectAll()
        {
            return this._moneda.SelectAll();
        }
        public virtual T_Moneda Select(int _idMoneda)
        {
            return this._moneda.Select(_idMoneda);
        }
        public virtual string Insert(T_Moneda _moneda)
        {
            return this._moneda.Insert(_moneda);
        }
        public virtual string Update(T_Moneda _moneda)
        {
            return this._moneda.Update(_moneda);
        }
        public virtual string Delete(int _idMoneda)
        {
            return this._moneda.Delete(_idMoneda);
        }
    }
}


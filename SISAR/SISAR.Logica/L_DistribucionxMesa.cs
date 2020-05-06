using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_DistribucionxMesa
    {
        Dao_DistribucionxMesa _distribucionxMesa;

        public L_DistribucionxMesa()
        {
            _distribucionxMesa = new Dao_DistribucionxMesa();
        }

        public virtual DataSet SelectAll()
        {
            return this._distribucionxMesa.SelectAll();
        }

        public virtual DataSet SelectAllById_Distribucion(int _IdDistribucionxMesa)
        {
            return this._distribucionxMesa.SelectAllById_Distribucion(_IdDistribucionxMesa);
        }
        public virtual string DeleteAllById_Distribucion(int _IdDistribucionxMesa)
        {
            return this._distribucionxMesa.DeleteAllById_Distribucion(_IdDistribucionxMesa);
        }
        public virtual string Insert(T_DistribucionxMesa _distribucionxMesa)
        {
            return this._distribucionxMesa.Insert(_distribucionxMesa);
        }
        public virtual string Update(T_DistribucionxMesa _distribucionxMesa)
        {
            return this._distribucionxMesa.Update(_distribucionxMesa);
        }
    }
}


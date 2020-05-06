using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_ProductoxLocal
    {
        Dao_ProductoxLocal _productoxLocal;

        public L_ProductoxLocal()
        {
            _productoxLocal = new Dao_ProductoxLocal();
        }

        public virtual DataSet SelectAll()
        {
            return this._productoxLocal.SelectAll();
        }
        public virtual string Insert(T_ProductoxLocal _productoxLocal)
        {
            return this._productoxLocal.Insert(_productoxLocal);
        }
        public virtual string Update(T_ProductoxLocal _productoxLocal)
        {
            return this._productoxLocal.Update(_productoxLocal);
        }
        public virtual string Delete(int _idProducto_Local)
        {
            return this._productoxLocal.Delete(_idProducto_Local);
        }
    }
}


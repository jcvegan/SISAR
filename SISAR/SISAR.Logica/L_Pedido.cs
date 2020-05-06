using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Pedido
    {
        Dao_Pedido _pedido;

        public L_Pedido()
        {
            _pedido = new Dao_Pedido();
        }

        public virtual DataSet SelectAll()
        {
            return this._pedido.SelectAll();
        }       
        public virtual string Insert(T_Pedido _pedido)
        {
            return this._pedido.Insert(_pedido);
        }
        public virtual string Update(T_Pedido _pedido)
        {
            return this._pedido.Update(_pedido);
        }
        public virtual string Delete(int _idPedido)
        {
            return this._pedido.Delete(_idPedido);
        }
    }
}


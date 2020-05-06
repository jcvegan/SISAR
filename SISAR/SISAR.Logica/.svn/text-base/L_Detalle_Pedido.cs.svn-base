using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Detalle_Pedido
    {
        Dao_Detalle_Pedido _detalle_Pedido;

        public L_Detalle_Pedido()
        {
            _detalle_Pedido = new Dao_Detalle_Pedido();
        }

        public virtual DataSet SelectAll()
        {
            return this._detalle_Pedido.SelectAll();
        }
        public virtual DataSet SelectAllById_ZonaAndNumero_Mesa(int _id_Zona, int _numero_Mesa)
        {
            return this._detalle_Pedido.SelectAllById_ZonaAndNumero_Mesa(_id_Zona, _numero_Mesa);
        }
        public virtual DataSet SelectAllById_Local(int _idLocal)
        {
            return this._detalle_Pedido.SelectAllById_Local(_idLocal);
        }
        public virtual string Insert(T_Detalle_Pedido _detalle_Pedido)
        {
            return this._detalle_Pedido.Insert(_detalle_Pedido);
        }
        public virtual string Update(T_Detalle_Pedido _detalle_Pedido)
        {
            return this._detalle_Pedido.Update(_detalle_Pedido);
        }
        public virtual string UpdateEstado(T_Detalle_Pedido _detallePedido)
        {
            return this._detalle_Pedido.UpdateEstado(_detallePedido);
        }
        public virtual string Delete(int _idDetalle_Pedido)
        {
            return this._detalle_Pedido.Delete(_idDetalle_Pedido);
        }
    }
}


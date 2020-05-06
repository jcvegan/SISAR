using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Detalle_Movimiento_Caja
    {
        Dao_Detalle_Movimiento_Caja _detalle_Movimiento_Caja;

        public L_Detalle_Movimiento_Caja()
        {
            _detalle_Movimiento_Caja = new Dao_Detalle_Movimiento_Caja();
        }

        public virtual DataSet SelectAll()
        {
            return this._detalle_Movimiento_Caja.SelectAll();
        }       
        public virtual string Insert(T_Detalle_Movimiento_Caja _detalle_Movimiento_Caja)
        {
            return this._detalle_Movimiento_Caja.Insert(_detalle_Movimiento_Caja);
        }
        public virtual string Update(T_Detalle_Movimiento_Caja _detalle_Movimiento_Caja)
        {
            return this._detalle_Movimiento_Caja.Update(_detalle_Movimiento_Caja);
        }
        public virtual string Delete(int _idDetalle_Movimiento_Caja)
        {
            return this._detalle_Movimiento_Caja.Delete(_idDetalle_Movimiento_Caja);
        }
    }
}


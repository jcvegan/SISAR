using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Movimiento_Caja
    {
        Dao_Movimiento_Caja _movimiento_Caja;

        public L_Movimiento_Caja()
        {
            _movimiento_Caja = new Dao_Movimiento_Caja();
        }

        public virtual DataSet SelectAll()
        {
            return this._movimiento_Caja.SelectAll();
        }       
        public virtual string Insert(T_Moviemiento_Caja _movimiento_Caja)
        {
            return this._movimiento_Caja.Insert(_movimiento_Caja);
        }
        public virtual string Update(T_Moviemiento_Caja _movimiento_Caja)
        {
            return this._movimiento_Caja.Update(_movimiento_Caja);
        }
        public virtual string Delete(int _idMovimiento_Caja)
        {
            return this._movimiento_Caja.Delete(_idMovimiento_Caja);
        }
    }
}


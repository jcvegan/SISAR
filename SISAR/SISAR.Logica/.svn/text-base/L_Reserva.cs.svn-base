using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Reserva
    {
        Dao_Reserva _reserva;

        public L_Reserva()
        {
            _reserva = new Dao_Reserva();
        }

        public virtual DataSet SelectAll()
        {
            return this._reserva.SelectAll();
        }       
        public virtual string Insert(T_Reserva _reserva)
        {
            return this._reserva.Insert(_reserva);
        }
        public virtual string Update(T_Reserva _reserva)
        {
            return this._reserva.Update(_reserva);
        }
        public virtual string Delete(int _idReserva)
        {
            return this._reserva.Delete(_idReserva);
        }
    }
}


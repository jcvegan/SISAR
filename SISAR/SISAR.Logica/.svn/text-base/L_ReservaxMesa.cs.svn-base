using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_ReservaxMesa
    {
        Dao_ReservaxMesa _reservaxMesa;

        public L_ReservaxMesa()
        {
            _reservaxMesa = new Dao_ReservaxMesa();
        }

        public virtual DataSet SelectAll()
        {
            return this._reservaxMesa.SelectAll();
        }       
        public virtual string Insert(T_ReservaxMesa _reservaxMesa)
        {
            return this._reservaxMesa.Insert(_reservaxMesa);
        }
        public virtual string Update(T_ReservaxMesa _reservaxMesa)
        {
            return this._reservaxMesa.Update(_reservaxMesa);
        }
    }
}


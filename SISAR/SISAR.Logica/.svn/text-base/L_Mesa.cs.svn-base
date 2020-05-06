using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Mesa
    {
        Dao_Mesa _mesa;

        public L_Mesa()
        {
            _mesa = new Dao_Mesa();
        }
        public virtual DataSet SelectAvailability(int ID_Local)
        {
            return this._mesa.SelectAvailability(ID_Local);
        }
        public virtual DataSet SelectAll()
        {
            return this._mesa.SelectAll();
        }       
        public virtual string Insert(T_Mesa _mesa)
        {
            return this._mesa.Insert(_mesa);
        }
        public virtual string Update(T_Mesa _mesa)
        {
            return this._mesa.Update(_mesa);
        }
        public virtual string Delete(int _idMesa)
        {
            return this._mesa.Delete(_idMesa);
        }
    }
}


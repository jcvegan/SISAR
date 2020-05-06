using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Tipo_Cambio
    {
        Dao_Tipo_Cambio _tipo_Cambio;

        public L_Tipo_Cambio()
        {
            _tipo_Cambio = new Dao_Tipo_Cambio();
        }

        public virtual DataSet SelectAll()
        {
            return this._tipo_Cambio.SelectAll();
        }       
        public virtual string Insert(T_Tipo_Cambio _tipo_Cambio)
        {
            return this._tipo_Cambio.Insert(_tipo_Cambio);
        }
        public virtual string Update(T_Tipo_Cambio _tipo_Cambio)
        {
            return this._tipo_Cambio.Update(_tipo_Cambio);
        }
        public virtual string Delete(int _idTipo_Cambio)
        {
            return this._tipo_Cambio.Delete(_idTipo_Cambio);
        }
    }
}


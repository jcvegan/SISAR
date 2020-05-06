using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Distribucion
    {
        Dao_Distribucion _distribucion;

        public L_Distribucion()
        {
            _distribucion = new Dao_Distribucion();
        }

        public virtual DataSet SelectAll()
        {
            return this._distribucion.SelectAll();
        }
        public virtual DataSet SelectAllById_Zona(int _idZona)
        {
            return this._distribucion.SelectAllById_Zona(_idZona);
        }       
        public virtual string Insert(T_Distribucion _distribucion)
        {
            return this._distribucion.Insert(_distribucion);
        }
        public virtual string Update(T_Distribucion _distribucion)
        {
            return this._distribucion.Update(_distribucion);
        }
        public virtual string Delete(int _idDistribucion)
        {
            return this._distribucion.Delete(_idDistribucion);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Cliente
    {
        
        Dao_Cliente _cliente;

        public L_Cliente()
        {
            _cliente = new Dao_Cliente();
        }

        public virtual DataSet SelectAll()
        {
            return this._cliente.SelectAll();
        }
        public virtual string Insert(T_Usuario _usuario)
        {
            return this._cliente.Insert(_usuario);
        }
        public virtual string Update(T_Usuario _usuario)
        {
            return this._cliente.Update(_usuario);
        }
        public virtual string Delete(int _dniUsuario) 
        {
            return this._cliente.Delete(_dniUsuario);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Menu
    {
        Dao_Menu _menu;

        public L_Menu()
        {
            _menu = new Dao_Menu();
        }

        public virtual DataSet SelectAll()
        {
            return this._menu.SelectAll();
        }       
        public virtual string Insert(T_Menu _menu)
        {
            return this._menu.Insert(_menu);
        }
        public virtual string Update(T_Menu _menu)
        {
            return this._menu.Update(_menu);
        }
        public virtual string Delete(int _idMenu)
        {
            return this._menu.Delete(_idMenu);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Detalle_Menu
    {
        Dao_Detalle_Menu _detalle_Menu;

        public L_Detalle_Menu()
        {
            _detalle_Menu = new Dao_Detalle_Menu();
        }

        public virtual DataSet SelectAll()
        {
            return this._detalle_Menu.SelectAll();
        }
        public virtual DataSet SelectAllById_Menu(int _idDetalle_Menu)
        {
            return this._detalle_Menu.SelectAllById_Menu(_idDetalle_Menu);
        }       
        public virtual string Insert(T_Detalle_Menu _detalle_Menu)
        {
            return this._detalle_Menu.Insert(_detalle_Menu);
        }
        public virtual string DeleteAllById_Menu(int _idDetalle_Menu)
        {
            return this._detalle_Menu.DeleteAllById_Menu(_idDetalle_Menu);
        }
    }
}


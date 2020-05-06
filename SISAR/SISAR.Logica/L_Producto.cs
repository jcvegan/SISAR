using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Producto
    {
        Dao_Producto _producto;

        public L_Producto()
        {
            _producto = new Dao_Producto();
        }

        public virtual DataSet SelectAll()
        {
            return this._producto.SelectAll();
        }
        public virtual DataSet SelectAllMenu()
        {
            return this._producto.SelectAllMenu();
        }
        public virtual T_Producto Select(int _idProducto)
        {
            return this._producto.Select(_idProducto);
        }       
        public virtual string Insert(T_Producto _producto)
        {
            return this._producto.Insert(_producto);
        }
        public virtual string Update(T_Producto _producto)
        {
            return this._producto.Update(_producto);
        }
        public virtual string Delete(int _idProducto)
        {
            return this._producto.Delete(_idProducto);
        }
        public virtual DataSet SelectByCategory(int _category)
        {
            return this._producto.SelectByCategory(_category);
        }
        public virtual DataSet SelectByCategoryPersonalizado(int _category, int _local)
        {
            return this._producto.SelectByCategoryPersonalizado(_category, _local);
        }
    }
}


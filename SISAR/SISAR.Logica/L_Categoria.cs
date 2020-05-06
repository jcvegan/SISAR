using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISAR.Acceso;
using SISAR.Entidades;
using System.Data;

namespace SISAR.Logica
{
    public class L_Categoria
    {
        Dao_Categoria _categoria;

        public L_Categoria()
        {
            _categoria = new Dao_Categoria();
        }

        public virtual DataSet SelectAll()
        {
            return this._categoria.SelectAll();
        }
        public virtual DataSet SelectAllCategorias()
        {
            return this._categoria.SelectAllCategorias();
        }
        public virtual DataSet SelectAllByCategoria_Padre(int _categoriaPadre)
        {
            return this._categoria.SelectAllByCategoria_Padre(_categoriaPadre);
        }
        public virtual T_Categoria Select(int _idCategoria)
        {
            return this._categoria.Select(_idCategoria);
        }
        public virtual string Insert(T_Categoria _categoria)
        {
            return this._categoria.Insert(_categoria);
        }
        public virtual string Update(T_Categoria _categoria)
        {
            return this._categoria.Update(_categoria);
        }
        public virtual string Delete(int _idCategoria)
        {
            return this._categoria.Delete(_idCategoria);
        }
    }
}

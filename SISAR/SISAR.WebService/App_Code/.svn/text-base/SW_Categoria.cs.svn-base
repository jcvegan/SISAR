using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Categoria
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Categoria : System.Web.Services.WebService
{
    L_Categoria _categoria;
    public SW_Categoria()
    {
        _categoria = new L_Categoria();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._categoria.SelectAll();
    }
    [WebMethod]
    public virtual DataSet SelectAllCategorias()
    {
        return this._categoria.SelectAllCategorias();
    }
    [WebMethod]
    public virtual DataSet SelectAllByCategoria_Padre(int _categoriaPadre)
    {
        return this._categoria.SelectAllByCategoria_Padre(_categoriaPadre);
    }
    [WebMethod]
    public virtual T_Categoria Select(int _idCategoria)
    {
        return this._categoria.Select(_idCategoria);
    }
    [WebMethod]
    public virtual string Insert(T_Categoria _categoria)
    {
        return this._categoria.Insert(_categoria);
    }
    [WebMethod]
    public virtual string Update(T_Categoria _categoria)
    {
        return this._categoria.Update(_categoria);
    }
    [WebMethod]
    public virtual string Delete(int _idCategoria)
    {
        return this._categoria.Delete(_idCategoria);
    }
}


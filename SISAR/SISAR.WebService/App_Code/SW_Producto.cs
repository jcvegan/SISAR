using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Producto
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Producto : System.Web.Services.WebService
{
    L_Producto _producto;
    public SW_Producto()
    {
        _producto = new L_Producto();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._producto.SelectAll();
    }
    [WebMethod]
    public virtual DataSet SelectAllMenu()
    {
        return this._producto.SelectAllMenu();
    }
    [WebMethod]
    public virtual T_Producto Select(int _idProducto)
    {
        return this._producto.Select(_idProducto);
    }
    [WebMethod]
    public virtual string Insert(T_Producto _producto)
    {
        return this._producto.Insert(_producto);
    }
    [WebMethod]
    public virtual string Update(T_Producto _producto)
    {
        return this._producto.Update(_producto);
    }
    [WebMethod]
    public virtual string Delete(int _idProducto)
    {
        return this._producto.Delete(_idProducto);
    }
    [WebMethod]
    public virtual DataSet SelectByCategory(int _category)
    {
        return this._producto.SelectByCategory(_category);
    }
    [WebMethod]
    public virtual DataSet SelectByCategoryPersonalizado(int _category, int _local)
    {
        return this._producto.SelectByCategoryPersonalizado(_category, _local);
    }
}



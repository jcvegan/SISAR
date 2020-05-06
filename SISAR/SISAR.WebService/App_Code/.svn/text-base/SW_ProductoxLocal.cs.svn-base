using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_ProductoxLocal
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_ProductoxLocal : System.Web.Services.WebService
{
    L_ProductoxLocal _productoxLocal;
    public SW_ProductoxLocal()
    {
        _productoxLocal = new L_ProductoxLocal();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._productoxLocal.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_ProductoxLocal _productoxLocal)
    {
        return this._productoxLocal.Insert(_productoxLocal);
    }
    [WebMethod]
    public virtual string Update(T_ProductoxLocal _productoxLocal)
    {
        return this._productoxLocal.Update(_productoxLocal);
    }
    [WebMethod]
    public virtual string Delete(int _idProducto_Local)
    {
        return this._productoxLocal.Delete(_idProducto_Local);
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Pedido
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Pedido : System.Web.Services.WebService
{
    L_Pedido _pedido;
    public SW_Pedido()
    {
        _pedido = new L_Pedido();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._pedido.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Pedido _pedido)
    {
        return this._pedido.Insert(_pedido);
    }
    [WebMethod]
    public virtual string Update(T_Pedido _pedido)
    {
        return this._pedido.Update(_pedido);
    }
    [WebMethod]
    public virtual string Delete(int _idPedido)
    {
        return this._pedido.Delete(_idPedido);
    }
}



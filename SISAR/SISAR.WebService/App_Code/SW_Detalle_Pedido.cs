using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Detalle_Pedido
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Detalle_Pedido : System.Web.Services.WebService
{
    L_Detalle_Pedido _detalle_Pedido;
    public SW_Detalle_Pedido()
    {
        _detalle_Pedido = new L_Detalle_Pedido();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._detalle_Pedido.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Detalle_Pedido _detalle_Pedido)
    {
        return this._detalle_Pedido.Insert(_detalle_Pedido);
    }
    [WebMethod]
    public virtual string Update(T_Detalle_Pedido _detalle_Pedido)
    {
        return this._detalle_Pedido.Update(_detalle_Pedido);
    }
    [WebMethod]
    public virtual string Delete(int _idDetalle_Pedido)
    {
        return this._detalle_Pedido.Delete(_idDetalle_Pedido);
    }
}



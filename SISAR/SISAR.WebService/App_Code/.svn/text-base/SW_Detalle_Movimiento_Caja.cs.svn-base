using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Detalle_Movimiento_Caja
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Detalle_Movimiento_Caja : System.Web.Services.WebService
{
    L_Detalle_Movimiento_Caja _detalle_Movimiento_Caja;
    public SW_Detalle_Movimiento_Caja()
    {
        _detalle_Movimiento_Caja = new L_Detalle_Movimiento_Caja();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._detalle_Movimiento_Caja.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Detalle_Movimiento_Caja _detalle_Movimiento_Caja)
    {
        return this._detalle_Movimiento_Caja.Insert(_detalle_Movimiento_Caja);
    }
    [WebMethod]
    public virtual string Update(T_Detalle_Movimiento_Caja _detalle_Movimiento_Caja)
    {
        return this._detalle_Movimiento_Caja.Update(_detalle_Movimiento_Caja);
    }
    [WebMethod]
    public virtual string Delete(int _idDetalle_Movimiento_Caja)
    {
        return this._detalle_Movimiento_Caja.Delete(_idDetalle_Movimiento_Caja);
    }
}



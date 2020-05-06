using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Movimiento_Caja
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Movimiento_Caja : System.Web.Services.WebService
{
    L_Movimiento_Caja _movimiento_Caja;
    public SW_Movimiento_Caja()
    {
        _movimiento_Caja = new L_Movimiento_Caja();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._movimiento_Caja.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Moviemiento_Caja _movimiento_Caja)
    {
        return this._movimiento_Caja.Insert(_movimiento_Caja);
    }
    [WebMethod]
    public virtual string Update(T_Moviemiento_Caja _movimiento_Caja)
    {
        return this._movimiento_Caja.Update(_movimiento_Caja);
    }
    [WebMethod]
    public virtual string Delete(int _idMovimiento_Caja)
    {
        return this._movimiento_Caja.Delete(_idMovimiento_Caja);
    }
}



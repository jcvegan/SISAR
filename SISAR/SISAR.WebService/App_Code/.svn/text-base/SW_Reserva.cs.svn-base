using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Reserva
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Reserva : System.Web.Services.WebService
{
    L_Reserva _reserva;
    public SW_Reserva()
    {
        _reserva = new L_Reserva();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._reserva.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Reserva _reserva)
    {
        return this._reserva.Insert(_reserva);
    }
    [WebMethod]
    public virtual string Update(T_Reserva _reserva)
    {
        return this._reserva.Update(_reserva);
    }
    [WebMethod]
    public virtual string Delete(int _idReserva)
    {
        return this._reserva.Delete(_idReserva);
    }
}



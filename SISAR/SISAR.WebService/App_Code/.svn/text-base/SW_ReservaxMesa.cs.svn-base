using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_ReservaxMesa
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_ReservaxMesa : System.Web.Services.WebService
{
    L_ReservaxMesa _reservaxMesa;
    public SW_ReservaxMesa()
    {
        _reservaxMesa = new L_ReservaxMesa();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._reservaxMesa.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_ReservaxMesa _reservaxMesa)
    {
        return this._reservaxMesa.Insert(_reservaxMesa);
    }
    [WebMethod]
    public virtual string Update(T_ReservaxMesa _reservaxMesa)
    {
        return this._reservaxMesa.Update(_reservaxMesa);
    }
}



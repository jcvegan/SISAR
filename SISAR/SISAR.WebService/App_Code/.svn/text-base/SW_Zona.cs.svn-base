using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Zona
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Zona : System.Web.Services.WebService
{
    L_Zona _zona;
    public SW_Zona()
    {
        _zona = new L_Zona();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._zona.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Zona _zona)
    {
        return this._zona.Insert(_zona);
    }
    [WebMethod]
    public virtual string Update(T_Zona _zona)
    {
        return this._zona.Update(_zona);
    }
    [WebMethod]
    public virtual string Delete(int _idZona)
    {
        return this._zona.Delete(_idZona);
    }
}



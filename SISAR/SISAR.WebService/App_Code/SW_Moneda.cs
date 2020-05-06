using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Moneda
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Moneda : System.Web.Services.WebService
{
    L_Moneda _moneda;
    public SW_Moneda()
    {
        _moneda = new L_Moneda();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._moneda.SelectAll();
    }
    [WebMethod]
    public virtual T_Moneda Select(int _idMoneda)
    {
        return this._moneda.Select(_idMoneda);
    }
    [WebMethod]
    public virtual string Insert(T_Moneda _moneda)
    {
        return this._moneda.Insert(_moneda);
    }
    [WebMethod]
    public virtual string Update(T_Moneda _moneda)
    {
        return this._moneda.Update(_moneda);
    }
    [WebMethod]
    public virtual string Delete(int _idMoneda)
    {
        return this._moneda.Delete(_idMoneda);
    }
}



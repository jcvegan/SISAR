using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Mesa
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Mesa : System.Web.Services.WebService
{
    L_Mesa _mesa;
    public SW_Mesa()
    {
        _mesa = new L_Mesa();
    }

    [WebMethod]
    public virtual DataSet SelectAvailability(int ID_Local)
    {
        return this._mesa.SelectAvailability(ID_Local);
    }
    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._mesa.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Mesa _mesa)
    {
        return this._mesa.Insert(_mesa);
    }
    [WebMethod]
    public virtual string Update(T_Mesa _mesa)
    {
        return this._mesa.Update(_mesa);
    }
    [WebMethod]
    public virtual string Delete(int _idMesa)
    {
        return this._mesa.Delete(_idMesa);
    }
}



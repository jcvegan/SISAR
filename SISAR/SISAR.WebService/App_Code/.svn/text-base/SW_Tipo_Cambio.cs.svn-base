using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Tipo_Cambio
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Tipo_Cambio : System.Web.Services.WebService
{
    L_Tipo_Cambio _tipo_Cambio;
    public SW_Tipo_Cambio()
    {
        _tipo_Cambio = new L_Tipo_Cambio();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._tipo_Cambio.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Tipo_Cambio _tipo_Cambio)
    {
        return this._tipo_Cambio.Insert(_tipo_Cambio);
    }
    [WebMethod]
    public virtual string Update(T_Tipo_Cambio _tipo_Cambio)
    {
        return this._tipo_Cambio.Update(_tipo_Cambio);
    }
    [WebMethod]
    public virtual string Delete(int _idTipo_Cambio)
    {
        return this._tipo_Cambio.Delete(_idTipo_Cambio);
    }
}



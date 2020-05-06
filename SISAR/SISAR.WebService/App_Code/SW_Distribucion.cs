using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Distribucion
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Distribucion : System.Web.Services.WebService
{
    L_Distribucion _distribucion;
    public SW_Distribucion()
    {
        _distribucion = new L_Distribucion();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._distribucion.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Distribucion _distribucion)
    {
        return this._distribucion.Insert(_distribucion);
    }
    [WebMethod]
    public virtual string Update(T_Distribucion _distribucion)
    {
        return this._distribucion.Update(_distribucion);
    }
    [WebMethod]
    public virtual string Delete(int _idDistribucion)
    {
        return this._distribucion.Delete(_idDistribucion);
    }
}



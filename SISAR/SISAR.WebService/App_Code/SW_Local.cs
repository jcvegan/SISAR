using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Local
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Local : System.Web.Services.WebService
{
    L_Local _local;
    public SW_Local()
    {
        _local = new L_Local();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._local.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Local _Local)
    {
        return this._local.Insert(_Local);
    }
    [WebMethod]
    public virtual string Update(T_Local _Local)
    {
        return this._local.Update(_Local);
    }
    [WebMethod]
    public virtual string Delete(int _idLocal)
    {
        return this._local.Delete(_idLocal);
    }
}


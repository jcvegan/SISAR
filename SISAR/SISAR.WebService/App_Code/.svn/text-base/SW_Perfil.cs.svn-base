using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Perfil
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Perfil : System.Web.Services.WebService
{
    L_Perfil _perfil;
    public SW_Perfil()
    {
        _perfil = new L_Perfil();
    }

    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._perfil.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Perfil _perfil)
    {
        return this._perfil.Insert(_perfil);
    }
    [WebMethod]
    public virtual string Update(T_Perfil _perfil)
    {
        return this._perfil.Update(_perfil);
    }
    [WebMethod]
    public virtual string Delete(int _idPerfil)
    {
        return this._perfil.Delete(_idPerfil);
    }
}



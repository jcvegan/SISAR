using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_PerfilxPermiso
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_PerfilxPermiso : System.Web.Services.WebService
{
    L_PerfilxPermiso _perfilxPermiso;
    public SW_PerfilxPermiso()
    {
        _perfilxPermiso = new L_PerfilxPermiso();
    }

    [WebMethod]
    public virtual DataSet SelectAllById_Perfil(int _perfilId)
    {
        return this._perfilxPermiso.SelectAllById_Perfil(_perfilId);
    }
}



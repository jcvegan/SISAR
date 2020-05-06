using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using SISAR.Logica;
using System.Data;
using SISAR.Entidades;

/// <summary>
/// Descripción breve de SW_Usuario
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la lónea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class SW_Usuario : System.Web.Services.WebService
{
    L_Usuario _usuario;
    public SW_Usuario()
    {
        _usuario = new L_Usuario();
    }
    
    [WebMethod]
    public virtual DataSet SelectAll()
    {
        return this._usuario.SelectAll();
    }
    [WebMethod]
    public virtual string Insert(T_Usuario _usuario)
    {
        return this._usuario.Insert(_usuario);
    }
    [WebMethod]
    public virtual string Update(T_Usuario _usuario)
    {
        return this._usuario.Update(_usuario);
    }
    [WebMethod]
    public virtual string Delete(int _idUsuario)
    {
        return this._usuario.Delete(_idUsuario);
    }
    [WebMethod]
    public virtual T_Usuario Authenticate(int _idUsuario, string _password)
    {
        return this._usuario.Authenticate(_idUsuario, _password);
    }
}



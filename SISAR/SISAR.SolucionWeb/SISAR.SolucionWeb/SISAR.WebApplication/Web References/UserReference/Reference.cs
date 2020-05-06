﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.3603
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=2.0.50727.3603.
// 
#pragma warning disable 1591

namespace SISAR.WebApplication.UserReference {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SW_UsuarioSoap", Namespace="http://tempuri.org/")]
    public partial class SW_Usuario : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SelectAllOperationCompleted;
        
        private System.Threading.SendOrPostCallback InsertOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteOperationCompleted;
        
        private System.Threading.SendOrPostCallback AuthenticateOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SW_Usuario() {
            this.Url = global::SISAR.WebApplication.Properties.Settings.Default.SISAR_WebApplication_UserReference_SW_Usuario;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SelectAllCompletedEventHandler SelectAllCompleted;
        
        /// <remarks/>
        public event InsertCompletedEventHandler InsertCompleted;
        
        /// <remarks/>
        public event UpdateCompletedEventHandler UpdateCompleted;
        
        /// <remarks/>
        public event DeleteCompletedEventHandler DeleteCompleted;
        
        /// <remarks/>
        public event AuthenticateCompletedEventHandler AuthenticateCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SelectAll", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet SelectAll() {
            object[] results = this.Invoke("SelectAll", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void SelectAllAsync() {
            this.SelectAllAsync(null);
        }
        
        /// <remarks/>
        public void SelectAllAsync(object userState) {
            if ((this.SelectAllOperationCompleted == null)) {
                this.SelectAllOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSelectAllOperationCompleted);
            }
            this.InvokeAsync("SelectAll", new object[0], this.SelectAllOperationCompleted, userState);
        }
        
        private void OnSelectAllOperationCompleted(object arg) {
            if ((this.SelectAllCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SelectAllCompleted(this, new SelectAllCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Insert", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Insert(T_Usuario _usuario) {
            object[] results = this.Invoke("Insert", new object[] {
                        _usuario});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void InsertAsync(T_Usuario _usuario) {
            this.InsertAsync(_usuario, null);
        }
        
        /// <remarks/>
        public void InsertAsync(T_Usuario _usuario, object userState) {
            if ((this.InsertOperationCompleted == null)) {
                this.InsertOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsertOperationCompleted);
            }
            this.InvokeAsync("Insert", new object[] {
                        _usuario}, this.InsertOperationCompleted, userState);
        }
        
        private void OnInsertOperationCompleted(object arg) {
            if ((this.InsertCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsertCompleted(this, new InsertCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Update", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Update(T_Usuario _usuario) {
            object[] results = this.Invoke("Update", new object[] {
                        _usuario});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateAsync(T_Usuario _usuario) {
            this.UpdateAsync(_usuario, null);
        }
        
        /// <remarks/>
        public void UpdateAsync(T_Usuario _usuario, object userState) {
            if ((this.UpdateOperationCompleted == null)) {
                this.UpdateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateOperationCompleted);
            }
            this.InvokeAsync("Update", new object[] {
                        _usuario}, this.UpdateOperationCompleted, userState);
        }
        
        private void OnUpdateOperationCompleted(object arg) {
            if ((this.UpdateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateCompleted(this, new UpdateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Delete", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Delete(int _idUsuario) {
            object[] results = this.Invoke("Delete", new object[] {
                        _idUsuario});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteAsync(int _idUsuario) {
            this.DeleteAsync(_idUsuario, null);
        }
        
        /// <remarks/>
        public void DeleteAsync(int _idUsuario, object userState) {
            if ((this.DeleteOperationCompleted == null)) {
                this.DeleteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteOperationCompleted);
            }
            this.InvokeAsync("Delete", new object[] {
                        _idUsuario}, this.DeleteOperationCompleted, userState);
        }
        
        private void OnDeleteOperationCompleted(object arg) {
            if ((this.DeleteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteCompleted(this, new DeleteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Authenticate", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public T_Usuario Authenticate(int _idUsuario, string _password) {
            object[] results = this.Invoke("Authenticate", new object[] {
                        _idUsuario,
                        _password});
            return ((T_Usuario)(results[0]));
        }
        
        /// <remarks/>
        public void AuthenticateAsync(int _idUsuario, string _password) {
            this.AuthenticateAsync(_idUsuario, _password, null);
        }
        
        /// <remarks/>
        public void AuthenticateAsync(int _idUsuario, string _password, object userState) {
            if ((this.AuthenticateOperationCompleted == null)) {
                this.AuthenticateOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAuthenticateOperationCompleted);
            }
            this.InvokeAsync("Authenticate", new object[] {
                        _idUsuario,
                        _password}, this.AuthenticateOperationCompleted, userState);
        }
        
        private void OnAuthenticateOperationCompleted(object arg) {
            if ((this.AuthenticateCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AuthenticateCompleted(this, new AuthenticateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <comentarios/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class T_Usuario {
        
        private int id_UsuarioField;
        
        private string nombresField;
        
        private string apellidosField;
        
        private string telefonoField;
        
        private string direccionField;
        
        private string emailField;
        
        private System.DateTime fecha_RegistroField;
        
        private string contraseñaField;
        
        private string estadoField;
        
        private int id_LocalField;
        
        private int id_PerfilField;
        
        private System.DateTime fecha_NacimientoField;
        
        /// <comentarios/>
        public int Id_Usuario {
            get {
                return this.id_UsuarioField;
            }
            set {
                this.id_UsuarioField = value;
            }
        }
        
        /// <comentarios/>
        public string Nombres {
            get {
                return this.nombresField;
            }
            set {
                this.nombresField = value;
            }
        }
        
        /// <comentarios/>
        public string Apellidos {
            get {
                return this.apellidosField;
            }
            set {
                this.apellidosField = value;
            }
        }
        
        /// <comentarios/>
        public string Telefono {
            get {
                return this.telefonoField;
            }
            set {
                this.telefonoField = value;
            }
        }
        
        /// <comentarios/>
        public string Direccion {
            get {
                return this.direccionField;
            }
            set {
                this.direccionField = value;
            }
        }
        
        /// <comentarios/>
        public string Email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <comentarios/>
        public System.DateTime Fecha_Registro {
            get {
                return this.fecha_RegistroField;
            }
            set {
                this.fecha_RegistroField = value;
            }
        }
        
        /// <comentarios/>
        public string Contraseña {
            get {
                return this.contraseñaField;
            }
            set {
                this.contraseñaField = value;
            }
        }
        
        /// <comentarios/>
        public string Estado {
            get {
                return this.estadoField;
            }
            set {
                this.estadoField = value;
            }
        }
        
        /// <comentarios/>
        public int Id_Local {
            get {
                return this.id_LocalField;
            }
            set {
                this.id_LocalField = value;
            }
        }
        
        /// <comentarios/>
        public int Id_Perfil {
            get {
                return this.id_PerfilField;
            }
            set {
                this.id_PerfilField = value;
            }
        }
        
        /// <comentarios/>
        public System.DateTime Fecha_Nacimiento {
            get {
                return this.fecha_NacimientoField;
            }
            set {
                this.fecha_NacimientoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void SelectAllCompletedEventHandler(object sender, SelectAllCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SelectAllCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SelectAllCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void InsertCompletedEventHandler(object sender, InsertCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsertCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsertCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void UpdateCompletedEventHandler(object sender, UpdateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void DeleteCompletedEventHandler(object sender, DeleteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    public delegate void AuthenticateCompletedEventHandler(object sender, AuthenticateCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AuthenticateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AuthenticateCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public T_Usuario Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((T_Usuario)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591
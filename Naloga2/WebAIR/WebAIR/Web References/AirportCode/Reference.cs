﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebAIR.AirportCode {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="airportSoap", Namespace="http://www.webserviceX.NET")]
    public partial class airport : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getAirportInformationByISOCountryCodeOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAirportInformationByCityOrAirportNameOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAirportInformationByCountryOperationCompleted;
        
        private System.Threading.SendOrPostCallback getAirportInformationByAirportCodeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public airport() {
            this.Url = global::WebAIR.Properties.Settings.Default.WebAIR_net_webservicex_www1_airport;
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
        public event getAirportInformationByISOCountryCodeCompletedEventHandler getAirportInformationByISOCountryCodeCompleted;
        
        /// <remarks/>
        public event getAirportInformationByCityOrAirportNameCompletedEventHandler getAirportInformationByCityOrAirportNameCompleted;
        
        /// <remarks/>
        public event GetAirportInformationByCountryCompletedEventHandler GetAirportInformationByCountryCompleted;
        
        /// <remarks/>
        public event getAirportInformationByAirportCodeCompletedEventHandler getAirportInformationByAirportCodeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/getAirportInformationByISOCountryCode", RequestNamespace="http://www.webserviceX.NET", ResponseNamespace="http://www.webserviceX.NET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAirportInformationByISOCountryCode(string CountryAbbrviation) {
            object[] results = this.Invoke("getAirportInformationByISOCountryCode", new object[] {
                        CountryAbbrviation});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAirportInformationByISOCountryCodeAsync(string CountryAbbrviation) {
            this.getAirportInformationByISOCountryCodeAsync(CountryAbbrviation, null);
        }
        
        /// <remarks/>
        public void getAirportInformationByISOCountryCodeAsync(string CountryAbbrviation, object userState) {
            if ((this.getAirportInformationByISOCountryCodeOperationCompleted == null)) {
                this.getAirportInformationByISOCountryCodeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAirportInformationByISOCountryCodeOperationCompleted);
            }
            this.InvokeAsync("getAirportInformationByISOCountryCode", new object[] {
                        CountryAbbrviation}, this.getAirportInformationByISOCountryCodeOperationCompleted, userState);
        }
        
        private void OngetAirportInformationByISOCountryCodeOperationCompleted(object arg) {
            if ((this.getAirportInformationByISOCountryCodeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAirportInformationByISOCountryCodeCompleted(this, new getAirportInformationByISOCountryCodeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/getAirportInformationByCityOrAirportName", RequestNamespace="http://www.webserviceX.NET", ResponseNamespace="http://www.webserviceX.NET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAirportInformationByCityOrAirportName(string cityOrAirportName) {
            object[] results = this.Invoke("getAirportInformationByCityOrAirportName", new object[] {
                        cityOrAirportName});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAirportInformationByCityOrAirportNameAsync(string cityOrAirportName) {
            this.getAirportInformationByCityOrAirportNameAsync(cityOrAirportName, null);
        }
        
        /// <remarks/>
        public void getAirportInformationByCityOrAirportNameAsync(string cityOrAirportName, object userState) {
            if ((this.getAirportInformationByCityOrAirportNameOperationCompleted == null)) {
                this.getAirportInformationByCityOrAirportNameOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAirportInformationByCityOrAirportNameOperationCompleted);
            }
            this.InvokeAsync("getAirportInformationByCityOrAirportName", new object[] {
                        cityOrAirportName}, this.getAirportInformationByCityOrAirportNameOperationCompleted, userState);
        }
        
        private void OngetAirportInformationByCityOrAirportNameOperationCompleted(object arg) {
            if ((this.getAirportInformationByCityOrAirportNameCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAirportInformationByCityOrAirportNameCompleted(this, new getAirportInformationByCityOrAirportNameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/GetAirportInformationByCountry", RequestNamespace="http://www.webserviceX.NET", ResponseNamespace="http://www.webserviceX.NET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAirportInformationByCountry(string country) {
            object[] results = this.Invoke("GetAirportInformationByCountry", new object[] {
                        country});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAirportInformationByCountryAsync(string country) {
            this.GetAirportInformationByCountryAsync(country, null);
        }
        
        /// <remarks/>
        public void GetAirportInformationByCountryAsync(string country, object userState) {
            if ((this.GetAirportInformationByCountryOperationCompleted == null)) {
                this.GetAirportInformationByCountryOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAirportInformationByCountryOperationCompleted);
            }
            this.InvokeAsync("GetAirportInformationByCountry", new object[] {
                        country}, this.GetAirportInformationByCountryOperationCompleted, userState);
        }
        
        private void OnGetAirportInformationByCountryOperationCompleted(object arg) {
            if ((this.GetAirportInformationByCountryCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAirportInformationByCountryCompleted(this, new GetAirportInformationByCountryCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.webserviceX.NET/getAirportInformationByAirportCode", RequestNamespace="http://www.webserviceX.NET", ResponseNamespace="http://www.webserviceX.NET", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string getAirportInformationByAirportCode(string airportCode) {
            object[] results = this.Invoke("getAirportInformationByAirportCode", new object[] {
                        airportCode});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getAirportInformationByAirportCodeAsync(string airportCode) {
            this.getAirportInformationByAirportCodeAsync(airportCode, null);
        }
        
        /// <remarks/>
        public void getAirportInformationByAirportCodeAsync(string airportCode, object userState) {
            if ((this.getAirportInformationByAirportCodeOperationCompleted == null)) {
                this.getAirportInformationByAirportCodeOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetAirportInformationByAirportCodeOperationCompleted);
            }
            this.InvokeAsync("getAirportInformationByAirportCode", new object[] {
                        airportCode}, this.getAirportInformationByAirportCodeOperationCompleted, userState);
        }
        
        private void OngetAirportInformationByAirportCodeOperationCompleted(object arg) {
            if ((this.getAirportInformationByAirportCodeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getAirportInformationByAirportCodeCompleted(this, new getAirportInformationByAirportCodeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void getAirportInformationByISOCountryCodeCompletedEventHandler(object sender, getAirportInformationByISOCountryCodeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAirportInformationByISOCountryCodeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAirportInformationByISOCountryCodeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void getAirportInformationByCityOrAirportNameCompletedEventHandler(object sender, getAirportInformationByCityOrAirportNameCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAirportInformationByCityOrAirportNameCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAirportInformationByCityOrAirportNameCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetAirportInformationByCountryCompletedEventHandler(object sender, GetAirportInformationByCountryCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAirportInformationByCountryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAirportInformationByCountryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void getAirportInformationByAirportCodeCompletedEventHandler(object sender, getAirportInformationByAirportCodeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getAirportInformationByAirportCodeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getAirportInformationByAirportCodeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591
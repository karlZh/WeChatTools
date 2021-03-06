﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
namespace WeChatTools.Core
{
    // 
    // 此源代码由 wsdl 自动生成, Version=4.0.30319.33440。
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "serviceApi", Namespace = "http://tempuri.org/")]
    public partial class ServiceApi : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback ApiOperationCompleted;

        /// <remarks/>
        public ServiceApi()
        {
            string apiUrl = ConfigTool.ReadVerifyConfig("wxCheckService", "WeChatCheck");
            this.Url = apiUrl;
        }

        /// <remarks/>
        public event ApiCompletedEventHandler ApiCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IServiceApi/Api", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string Api([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string Parameters)
        {
            object[] results = this.Invoke("Api", new object[] {
                    Parameters});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public System.IAsyncResult BeginApi(string Parameters, System.AsyncCallback callback, object asyncState)
        {
            return this.BeginInvoke("Api", new object[] {
                    Parameters}, callback, asyncState);
        }

        /// <remarks/>
        public string EndApi(System.IAsyncResult asyncResult)
        {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void ApiAsync(string Parameters)
        {
            this.ApiAsync(Parameters, null);
        }

        /// <remarks/>
        public void ApiAsync(string Parameters, object userState)
        {
            if ((this.ApiOperationCompleted == null))
            {
                this.ApiOperationCompleted = new System.Threading.SendOrPostCallback(this.OnApiOperationCompleted);
            }
            this.InvokeAsync("Api", new object[] {
                    Parameters}, this.ApiOperationCompleted, userState);
        }

        private void OnApiOperationCompleted(object arg)
        {
            if ((this.ApiCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ApiCompleted(this, new ApiCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    public delegate void ApiCompletedEventHandler(object sender, ApiCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ApiCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal ApiCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}
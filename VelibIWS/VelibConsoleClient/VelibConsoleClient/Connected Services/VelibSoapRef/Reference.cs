﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace VelibConsoleClient.VelibSoapRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VelibSoapRef.IVelibService")]
    public interface IVelibService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/GetStationsOfACity", ReplyAction="http://tempuri.org/IVelibService/GetStationsOfACityResponse")]
        string GetStationsOfACity(string city);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IVelibService/GetStationsOfACity", ReplyAction="http://tempuri.org/IVelibService/GetStationsOfACityResponse")]
        System.IAsyncResult BeginGetStationsOfACity(string city, System.AsyncCallback callback, object asyncState);
        
        string EndGetStationsOfACity(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/GetStationInfo", ReplyAction="http://tempuri.org/IVelibService/GetStationInfoResponse")]
        string GetStationInfo(string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IVelibService/GetStationInfo", ReplyAction="http://tempuri.org/IVelibService/GetStationInfoResponse")]
        System.IAsyncResult BeginGetStationInfo(string city, string station, System.AsyncCallback callback, object asyncState);
        
        string EndGetStationInfo(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/GetHelp", ReplyAction="http://tempuri.org/IVelibService/GetHelpResponse")]
        string GetHelp();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IVelibService/GetHelp", ReplyAction="http://tempuri.org/IVelibService/GetHelpResponse")]
        System.IAsyncResult BeginGetHelp(System.AsyncCallback callback, object asyncState);
        
        string EndGetHelp(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibServiceChannel : VelibConsoleClient.VelibSoapRef.IVelibService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetStationsOfACityCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetStationsOfACityCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetStationInfoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetStationInfoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetHelpCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetHelpCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VelibServiceClient : System.ServiceModel.ClientBase<VelibConsoleClient.VelibSoapRef.IVelibService>, VelibConsoleClient.VelibSoapRef.IVelibService {
        
        private BeginOperationDelegate onBeginGetStationsOfACityDelegate;
        
        private EndOperationDelegate onEndGetStationsOfACityDelegate;
        
        private System.Threading.SendOrPostCallback onGetStationsOfACityCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetStationInfoDelegate;
        
        private EndOperationDelegate onEndGetStationInfoDelegate;
        
        private System.Threading.SendOrPostCallback onGetStationInfoCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetHelpDelegate;
        
        private EndOperationDelegate onEndGetHelpDelegate;
        
        private System.Threading.SendOrPostCallback onGetHelpCompletedDelegate;
        
        public VelibServiceClient() {
        }
        
        public VelibServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VelibServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetStationsOfACityCompletedEventArgs> GetStationsOfACityCompleted;
        
        public event System.EventHandler<GetStationInfoCompletedEventArgs> GetStationInfoCompleted;
        
        public event System.EventHandler<GetHelpCompletedEventArgs> GetHelpCompleted;
        
        public string GetStationsOfACity(string city) {
            return base.Channel.GetStationsOfACity(city);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetStationsOfACity(string city, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetStationsOfACity(city, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetStationsOfACity(System.IAsyncResult result) {
            return base.Channel.EndGetStationsOfACity(result);
        }
        
        private System.IAsyncResult OnBeginGetStationsOfACity(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string city = ((string)(inValues[0]));
            return this.BeginGetStationsOfACity(city, callback, asyncState);
        }
        
        private object[] OnEndGetStationsOfACity(System.IAsyncResult result) {
            string retVal = this.EndGetStationsOfACity(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetStationsOfACityCompleted(object state) {
            if ((this.GetStationsOfACityCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetStationsOfACityCompleted(this, new GetStationsOfACityCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetStationsOfACityAsync(string city) {
            this.GetStationsOfACityAsync(city, null);
        }
        
        public void GetStationsOfACityAsync(string city, object userState) {
            if ((this.onBeginGetStationsOfACityDelegate == null)) {
                this.onBeginGetStationsOfACityDelegate = new BeginOperationDelegate(this.OnBeginGetStationsOfACity);
            }
            if ((this.onEndGetStationsOfACityDelegate == null)) {
                this.onEndGetStationsOfACityDelegate = new EndOperationDelegate(this.OnEndGetStationsOfACity);
            }
            if ((this.onGetStationsOfACityCompletedDelegate == null)) {
                this.onGetStationsOfACityCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetStationsOfACityCompleted);
            }
            base.InvokeAsync(this.onBeginGetStationsOfACityDelegate, new object[] {
                        city}, this.onEndGetStationsOfACityDelegate, this.onGetStationsOfACityCompletedDelegate, userState);
        }
        
        public string GetStationInfo(string city, string station) {
            return base.Channel.GetStationInfo(city, station);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetStationInfo(string city, string station, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetStationInfo(city, station, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetStationInfo(System.IAsyncResult result) {
            return base.Channel.EndGetStationInfo(result);
        }
        
        private System.IAsyncResult OnBeginGetStationInfo(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string city = ((string)(inValues[0]));
            string station = ((string)(inValues[1]));
            return this.BeginGetStationInfo(city, station, callback, asyncState);
        }
        
        private object[] OnEndGetStationInfo(System.IAsyncResult result) {
            string retVal = this.EndGetStationInfo(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetStationInfoCompleted(object state) {
            if ((this.GetStationInfoCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetStationInfoCompleted(this, new GetStationInfoCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetStationInfoAsync(string city, string station) {
            this.GetStationInfoAsync(city, station, null);
        }
        
        public void GetStationInfoAsync(string city, string station, object userState) {
            if ((this.onBeginGetStationInfoDelegate == null)) {
                this.onBeginGetStationInfoDelegate = new BeginOperationDelegate(this.OnBeginGetStationInfo);
            }
            if ((this.onEndGetStationInfoDelegate == null)) {
                this.onEndGetStationInfoDelegate = new EndOperationDelegate(this.OnEndGetStationInfo);
            }
            if ((this.onGetStationInfoCompletedDelegate == null)) {
                this.onGetStationInfoCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetStationInfoCompleted);
            }
            base.InvokeAsync(this.onBeginGetStationInfoDelegate, new object[] {
                        city,
                        station}, this.onEndGetStationInfoDelegate, this.onGetStationInfoCompletedDelegate, userState);
        }
        
        public string GetHelp() {
            return base.Channel.GetHelp();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetHelp(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetHelp(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndGetHelp(System.IAsyncResult result) {
            return base.Channel.EndGetHelp(result);
        }
        
        private System.IAsyncResult OnBeginGetHelp(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetHelp(callback, asyncState);
        }
        
        private object[] OnEndGetHelp(System.IAsyncResult result) {
            string retVal = this.EndGetHelp(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetHelpCompleted(object state) {
            if ((this.GetHelpCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetHelpCompleted(this, new GetHelpCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetHelpAsync() {
            this.GetHelpAsync(null);
        }
        
        public void GetHelpAsync(object userState) {
            if ((this.onBeginGetHelpDelegate == null)) {
                this.onBeginGetHelpDelegate = new BeginOperationDelegate(this.OnBeginGetHelp);
            }
            if ((this.onEndGetHelpDelegate == null)) {
                this.onEndGetHelpDelegate = new EndOperationDelegate(this.OnEndGetHelp);
            }
            if ((this.onGetHelpCompletedDelegate == null)) {
                this.onGetHelpCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetHelpCompleted);
            }
            base.InvokeAsync(this.onBeginGetHelpDelegate, null, this.onEndGetHelpDelegate, this.onGetHelpCompletedDelegate, userState);
        }
    }
}

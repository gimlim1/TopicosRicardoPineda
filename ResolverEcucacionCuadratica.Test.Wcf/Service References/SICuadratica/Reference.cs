﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ResolverEcucacionCuadratica.Test.Wcf.SICuadratica {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/WcfResolverEcuacionCuadratica")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SICuadratica.IResolverEcuacionEcuadratica")]
    public interface IResolverEcuacionEcuadratica {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResolverEcuacionEcuadratica/ResolverEcuacion", ReplyAction="http://tempuri.org/IResolverEcuacionEcuadratica/ResolverEcuacionResponse")]
        ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.ResolverEcuacionResponse ResolverEcuacion(ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.ResolverEcuacionRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResolverEcuacionEcuadratica/ResolverEcuacion", ReplyAction="http://tempuri.org/IResolverEcuacionEcuadratica/ResolverEcuacionResponse")]
        System.Threading.Tasks.Task<ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.ResolverEcuacionResponse> ResolverEcuacionAsync(ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.ResolverEcuacionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResolverEcuacionEcuadratica/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IResolverEcuacionEcuadratica/GetDataUsingDataContractResponse")]
        ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.CompositeType GetDataUsingDataContract(ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IResolverEcuacionEcuadratica/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IResolverEcuacionEcuadratica/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.CompositeType> GetDataUsingDataContractAsync(ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.CompositeType composite);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ResolverEcuacion", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ResolverEcuacionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public double primer;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public double segundo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public double tercer;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public double x1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public double x2;
        
        public ResolverEcuacionRequest() {
        }
        
        public ResolverEcuacionRequest(double primer, double segundo, double tercer, double x1, double x2) {
            this.primer = primer;
            this.segundo = segundo;
            this.tercer = tercer;
            this.x1 = x1;
            this.x2 = x2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ResolverEcuacionResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ResolverEcuacionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public double x1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public double x2;
        
        public ResolverEcuacionResponse() {
        }
        
        public ResolverEcuacionResponse(double x1, double x2) {
            this.x1 = x1;
            this.x2 = x2;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IResolverEcuacionEcuadraticaChannel : ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.IResolverEcuacionEcuadratica, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ResolverEcuacionEcuadraticaClient : System.ServiceModel.ClientBase<ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.IResolverEcuacionEcuadratica>, ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.IResolverEcuacionEcuadratica {
        
        public ResolverEcuacionEcuadraticaClient() {
        }
        
        public ResolverEcuacionEcuadraticaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ResolverEcuacionEcuadraticaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResolverEcuacionEcuadraticaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResolverEcuacionEcuadraticaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.ResolverEcuacionResponse ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.IResolverEcuacionEcuadratica.ResolverEcuacion(ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.ResolverEcuacionRequest request) {
            return base.Channel.ResolverEcuacion(request);
        }
        
        public void ResolverEcuacion(double primer, double segundo, double tercer, ref double x1, ref double x2) {
            ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.ResolverEcuacionRequest inValue = new ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.ResolverEcuacionRequest();
            inValue.primer = primer;
            inValue.segundo = segundo;
            inValue.tercer = tercer;
            inValue.x1 = x1;
            inValue.x2 = x2;
            ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.ResolverEcuacionResponse retVal = ((ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.IResolverEcuacionEcuadratica)(this)).ResolverEcuacion(inValue);
            x1 = retVal.x1;
            x2 = retVal.x2;
        }
        
        public System.Threading.Tasks.Task<ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.ResolverEcuacionResponse> ResolverEcuacionAsync(ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.ResolverEcuacionRequest request) {
            return base.Channel.ResolverEcuacionAsync(request);
        }
        
        public ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.CompositeType GetDataUsingDataContract(ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.CompositeType> GetDataUsingDataContractAsync(ResolverEcucacionCuadratica.Test.Wcf.SICuadratica.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}

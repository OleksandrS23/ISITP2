﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cliente.SOAPServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Utilizador", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Utilizador : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte EstadoSessaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IduserField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Pessoa_idpessoaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte EstadoSessao {
            get {
                return this.EstadoSessaoField;
            }
            set {
                if ((this.EstadoSessaoField.Equals(value) != true)) {
                    this.EstadoSessaoField = value;
                    this.RaisePropertyChanged("EstadoSessao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Iduser {
            get {
                return this.IduserField;
            }
            set {
                if ((this.IduserField.Equals(value) != true)) {
                    this.IduserField = value;
                    this.RaisePropertyChanged("Iduser");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Pessoa_idpessoa {
            get {
                return this.Pessoa_idpessoaField;
            }
            set {
                if ((this.Pessoa_idpessoaField.Equals(value) != true)) {
                    this.Pessoa_idpessoaField = value;
                    this.RaisePropertyChanged("Pessoa_idpessoa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pessoa", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class Pessoa : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPessoaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MoradaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NifField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefoneField;
        
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
        public System.DateTime Data {
            get {
                return this.DataField;
            }
            set {
                if ((this.DataField.Equals(value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPessoa {
            get {
                return this.IdPessoaField;
            }
            set {
                if ((this.IdPessoaField.Equals(value) != true)) {
                    this.IdPessoaField = value;
                    this.RaisePropertyChanged("IdPessoa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Morada {
            get {
                return this.MoradaField;
            }
            set {
                if ((object.ReferenceEquals(this.MoradaField, value) != true)) {
                    this.MoradaField = value;
                    this.RaisePropertyChanged("Morada");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Nif {
            get {
                return this.NifField;
            }
            set {
                if ((this.NifField.Equals(value) != true)) {
                    this.NifField = value;
                    this.RaisePropertyChanged("Nif");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefone {
            get {
                return this.TelefoneField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefoneField, value) != true)) {
                    this.TelefoneField = value;
                    this.RaisePropertyChanged("Telefone");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPServices.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RegistrarUser", ReplyAction="http://tempuri.org/IService/RegistrarUserResponse")]
        string RegistrarUser(Cliente.SOAPServices.Utilizador u, Cliente.SOAPServices.Pessoa p, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/RegistrarUser", ReplyAction="http://tempuri.org/IService/RegistrarUserResponse")]
        System.Threading.Tasks.Task<string> RegistrarUserAsync(Cliente.SOAPServices.Utilizador u, Cliente.SOAPServices.Pessoa p, int role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/VerificarUserinTable", ReplyAction="http://tempuri.org/IService/VerificarUserinTableResponse")]
        int VerificarUserinTable(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/VerificarUserinTable", ReplyAction="http://tempuri.org/IService/VerificarUserinTableResponse")]
        System.Threading.Tasks.Task<int> VerificarUserinTableAsync(string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/nameLogedin", ReplyAction="http://tempuri.org/IService/nameLogedinResponse")]
        string nameLogedin(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/nameLogedin", ReplyAction="http://tempuri.org/IService/nameLogedinResponse")]
        System.Threading.Tasks.Task<string> nameLogedinAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ConsultasUtente", ReplyAction="http://tempuri.org/IService/ConsultasUtenteResponse")]
        System.Data.DataTable ConsultasUtente(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ConsultasUtente", ReplyAction="http://tempuri.org/IService/ConsultasUtenteResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> ConsultasUtenteAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ConvencaoInfo", ReplyAction="http://tempuri.org/IService/ConvencaoInfoResponse")]
        System.Data.DataTable ConvencaoInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ConvencaoInfo", ReplyAction="http://tempuri.org/IService/ConvencaoInfoResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> ConvencaoInfoAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Medicos", ReplyAction="http://tempuri.org/IService/MedicosResponse")]
        System.Data.DataTable Medicos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Medicos", ReplyAction="http://tempuri.org/IService/MedicosResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> MedicosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/TipoConsulta", ReplyAction="http://tempuri.org/IService/TipoConsultaResponse")]
        System.Data.DataTable TipoConsulta();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/TipoConsulta", ReplyAction="http://tempuri.org/IService/TipoConsultaResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> TipoConsultaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Cliente.SOAPServices.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Cliente.SOAPServices.IService>, Cliente.SOAPServices.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string RegistrarUser(Cliente.SOAPServices.Utilizador u, Cliente.SOAPServices.Pessoa p, int role) {
            return base.Channel.RegistrarUser(u, p, role);
        }
        
        public System.Threading.Tasks.Task<string> RegistrarUserAsync(Cliente.SOAPServices.Utilizador u, Cliente.SOAPServices.Pessoa p, int role) {
            return base.Channel.RegistrarUserAsync(u, p, role);
        }
        
        public int VerificarUserinTable(string user) {
            return base.Channel.VerificarUserinTable(user);
        }
        
        public System.Threading.Tasks.Task<int> VerificarUserinTableAsync(string user) {
            return base.Channel.VerificarUserinTableAsync(user);
        }
        
        public string nameLogedin(int id) {
            return base.Channel.nameLogedin(id);
        }
        
        public System.Threading.Tasks.Task<string> nameLogedinAsync(int id) {
            return base.Channel.nameLogedinAsync(id);
        }
        
        public System.Data.DataTable ConsultasUtente(int id) {
            return base.Channel.ConsultasUtente(id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> ConsultasUtenteAsync(int id) {
            return base.Channel.ConsultasUtenteAsync(id);
        }
        
        public System.Data.DataTable ConvencaoInfo() {
            return base.Channel.ConvencaoInfo();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> ConvencaoInfoAsync() {
            return base.Channel.ConvencaoInfoAsync();
        }
        
        public System.Data.DataTable Medicos() {
            return base.Channel.Medicos();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> MedicosAsync() {
            return base.Channel.MedicosAsync();
        }
        
        public System.Data.DataTable TipoConsulta() {
            return base.Channel.TipoConsulta();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> TipoConsultaAsync() {
            return base.Channel.TipoConsultaAsync();
        }
    }
}

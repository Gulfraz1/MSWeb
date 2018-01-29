﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentation.SearchService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchRequest", Namespace="http://schemas.datacontract.org/2004/07/CriminalSearchService.Messages")]
    [System.SerializableAttribute()]
    public partial class SearchRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Presentation.SearchService.SearchFilter FilterField;
        
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
        public Presentation.SearchService.SearchFilter Filter {
            get {
                return this.FilterField;
            }
            set {
                if ((object.ReferenceEquals(this.FilterField, value) != true)) {
                    this.FilterField = value;
                    this.RaisePropertyChanged("Filter");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchFilter", Namespace="http://schemas.datacontract.org/2004/07/CriminalSearchService.Messages")]
    [System.SerializableAttribute()]
    public partial class SearchFilter : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeMinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal HeightMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal HeightMinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NationalityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NoOfResultsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal WeightMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal WeightMinField;
        
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
        public int AgeMax {
            get {
                return this.AgeMaxField;
            }
            set {
                if ((this.AgeMaxField.Equals(value) != true)) {
                    this.AgeMaxField = value;
                    this.RaisePropertyChanged("AgeMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AgeMin {
            get {
                return this.AgeMinField;
            }
            set {
                if ((this.AgeMinField.Equals(value) != true)) {
                    this.AgeMinField = value;
                    this.RaisePropertyChanged("AgeMin");
                }
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
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal HeightMax {
            get {
                return this.HeightMaxField;
            }
            set {
                if ((this.HeightMaxField.Equals(value) != true)) {
                    this.HeightMaxField = value;
                    this.RaisePropertyChanged("HeightMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal HeightMin {
            get {
                return this.HeightMinField;
            }
            set {
                if ((this.HeightMinField.Equals(value) != true)) {
                    this.HeightMinField = value;
                    this.RaisePropertyChanged("HeightMin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nationality {
            get {
                return this.NationalityField;
            }
            set {
                if ((object.ReferenceEquals(this.NationalityField, value) != true)) {
                    this.NationalityField = value;
                    this.RaisePropertyChanged("Nationality");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NoOfResults {
            get {
                return this.NoOfResultsField;
            }
            set {
                if ((this.NoOfResultsField.Equals(value) != true)) {
                    this.NoOfResultsField = value;
                    this.RaisePropertyChanged("NoOfResults");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sex {
            get {
                return this.SexField;
            }
            set {
                if ((this.SexField.Equals(value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal WeightMax {
            get {
                return this.WeightMaxField;
            }
            set {
                if ((this.WeightMaxField.Equals(value) != true)) {
                    this.WeightMaxField = value;
                    this.RaisePropertyChanged("WeightMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal WeightMin {
            get {
                return this.WeightMinField;
            }
            set {
                if ((this.WeightMinField.Equals(value) != true)) {
                    this.WeightMinField = value;
                    this.RaisePropertyChanged("WeightMin");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SearchResponse", Namespace="http://schemas.datacontract.org/2004/07/CriminalSearchService.Messages")]
    [System.SerializableAttribute()]
    public partial class SearchResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] ErrorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SuccessField;
        
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
        public string[] Errors {
            get {
                return this.ErrorsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorsField, value) != true)) {
                    this.ErrorsField = value;
                    this.RaisePropertyChanged("Errors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Success {
            get {
                return this.SuccessField;
            }
            set {
                if ((this.SuccessField.Equals(value) != true)) {
                    this.SuccessField = value;
                    this.RaisePropertyChanged("Success");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SearchService.ISearchService")]
    public interface ISearchService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISearchService/Search", ReplyAction="http://tempuri.org/ISearchService/SearchResponse")]
        Presentation.SearchService.SearchResponse Search(Presentation.SearchService.SearchRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISearchService/Search", ReplyAction="http://tempuri.org/ISearchService/SearchResponse")]
        System.Threading.Tasks.Task<Presentation.SearchService.SearchResponse> SearchAsync(Presentation.SearchService.SearchRequest request);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISearchServiceChannel : Presentation.SearchService.ISearchService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SearchServiceClient : System.ServiceModel.ClientBase<Presentation.SearchService.ISearchService>, Presentation.SearchService.ISearchService {
        
        public SearchServiceClient() {
        }
        
        public SearchServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SearchServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearchServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearchServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Presentation.SearchService.SearchResponse Search(Presentation.SearchService.SearchRequest request) {
            return base.Channel.Search(request);
        }
        
        public System.Threading.Tasks.Task<Presentation.SearchService.SearchResponse> SearchAsync(Presentation.SearchService.SearchRequest request) {
            return base.Channel.SearchAsync(request);
        }
    }
}
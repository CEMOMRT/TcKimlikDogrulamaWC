﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TcKimlikDogrulamaWC.TCKNService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS", ConfigurationName="TCKNService.KPSPublicSoap")]
    public interface KPSPublicSoap {
        
        // CODEGEN: http://tckimlik.nvi.gov.tr/WS ad alanındaki Ad öğe adı sıfırlanabilir olarak işaretlenmediğinden, ileti sözleşmesi oluşturuluyor
        [System.ServiceModel.OperationContractAttribute(Action="http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula", ReplyAction="*")]
        TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaResponse TCKimlikNoDogrula(TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tckimlik.nvi.gov.tr/WS/TCKimlikNoDogrula", ReplyAction="*")]
        System.Threading.Tasks.Task<TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaResponse> TCKimlikNoDogrulaAsync(TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TCKimlikNoDogrulaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TCKimlikNoDogrula", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequestBody Body;
        
        public TCKimlikNoDogrulaRequest() {
        }
        
        public TCKimlikNoDogrulaRequest(TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class TCKimlikNoDogrulaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long TCKimlikNo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Ad;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Soyad;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int DogumYili;
        
        public TCKimlikNoDogrulaRequestBody() {
        }
        
        public TCKimlikNoDogrulaRequestBody(long TCKimlikNo, string Ad, string Soyad, int DogumYili) {
            this.TCKimlikNo = TCKimlikNo;
            this.Ad = Ad;
            this.Soyad = Soyad;
            this.DogumYili = DogumYili;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TCKimlikNoDogrulaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TCKimlikNoDogrulaResponse", Namespace="http://tckimlik.nvi.gov.tr/WS", Order=0)]
        public TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaResponseBody Body;
        
        public TCKimlikNoDogrulaResponse() {
        }
        
        public TCKimlikNoDogrulaResponse(TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tckimlik.nvi.gov.tr/WS")]
    public partial class TCKimlikNoDogrulaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool TCKimlikNoDogrulaResult;
        
        public TCKimlikNoDogrulaResponseBody() {
        }
        
        public TCKimlikNoDogrulaResponseBody(bool TCKimlikNoDogrulaResult) {
            this.TCKimlikNoDogrulaResult = TCKimlikNoDogrulaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface KPSPublicSoapChannel : TcKimlikDogrulamaWC.TCKNService.KPSPublicSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KPSPublicSoapClient : System.ServiceModel.ClientBase<TcKimlikDogrulamaWC.TCKNService.KPSPublicSoap>, TcKimlikDogrulamaWC.TCKNService.KPSPublicSoap {
        
        public KPSPublicSoapClient() {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KPSPublicSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KPSPublicSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaResponse TcKimlikDogrulamaWC.TCKNService.KPSPublicSoap.TCKimlikNoDogrula(TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequest request) {
            return base.Channel.TCKimlikNoDogrula(request);
        }
        
        public bool TCKimlikNoDogrula(long TCKimlikNo, string Ad, string Soyad, int DogumYili) {
            TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequest inValue = new TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequest();
            inValue.Body = new TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequestBody();
            inValue.Body.TCKimlikNo = TCKimlikNo;
            inValue.Body.Ad = Ad;
            inValue.Body.Soyad = Soyad;
            inValue.Body.DogumYili = DogumYili;
            TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaResponse retVal = ((TcKimlikDogrulamaWC.TCKNService.KPSPublicSoap)(this)).TCKimlikNoDogrula(inValue);
            return retVal.Body.TCKimlikNoDogrulaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaResponse> TcKimlikDogrulamaWC.TCKNService.KPSPublicSoap.TCKimlikNoDogrulaAsync(TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequest request) {
            return base.Channel.TCKimlikNoDogrulaAsync(request);
        }
        
        public System.Threading.Tasks.Task<TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaResponse> TCKimlikNoDogrulaAsync(long TCKimlikNo, string Ad, string Soyad, int DogumYili) {
            TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequest inValue = new TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequest();
            inValue.Body = new TcKimlikDogrulamaWC.TCKNService.TCKimlikNoDogrulaRequestBody();
            inValue.Body.TCKimlikNo = TCKimlikNo;
            inValue.Body.Ad = Ad;
            inValue.Body.Soyad = Soyad;
            inValue.Body.DogumYili = DogumYili;
            return ((TcKimlikDogrulamaWC.TCKNService.KPSPublicSoap)(this)).TCKimlikNoDogrulaAsync(inValue);
        }
    }
}

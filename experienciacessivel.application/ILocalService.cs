using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using experienciacessivel.domain;

namespace experienciacessivel.application
{
    [ServiceContract]
    public interface ILocalService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetLocalByName/{name}")]        
        List<LocalResponse> GetLocalByName(string name);

        [OperationContract]
        [WebGet(UriTemplate = "/GetLocalByName/{name}?format=json", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        List<LocalResponse> GetLocalByNameJson(string name);
    }

    [DataContract(Namespace = "")]
    public class LocalResponse
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string[] AccessibleAttributes { get; set; }

        public LocalResponse(Local objLocal)
        {
            this.Id = objLocal.Id;
            this.Name = objLocal.Name;
            this.AccessibleAttributes = objLocal.AccessibleAttributes.Select(q => q.Name).ToArray();
        }

    }
}

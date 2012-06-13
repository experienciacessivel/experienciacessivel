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
        List<LocalResponse> GetLocalByName(string name);
    }
  
    [DataContract]
    public class LocalResponse
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public IList<AccessibleAttributes> AccessibleAttributes { get; set; }

        public LocalResponse(int Id, string Name, IList<AccessibleAttributes> AccessibleAttributes)
        {
            this.Id = Id;
            this.Name = Name;
            this.AccessibleAttributes = AccessibleAttributes;
        }

    }
}

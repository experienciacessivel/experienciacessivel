using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using experienciacessivel.infrastructure;
using experienciacessivel.domain;

namespace experienciacessivel.application
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    
    
    public class LocalService : ILocalService
    {
        [WebGet(ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "/GetLocalByName/{name}")]
        public List<LocalResponse> GetLocalByName(string name)
        {
            
            IUnitOfWork unit = new ExperienciacessivelContext();

            LocalRepository localRepository = new LocalRepository(unit);

            List<Local> locals = localRepository.GetLocalByName(name);

            List<LocalResponse> listResponse = new List<LocalResponse>();

            foreach (var loc in locals)            
                listResponse.Add(new LocalResponse(loc));            

            return listResponse;
        }
    }
}

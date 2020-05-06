using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SISAR.WebApplication
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class LocalService
    {
        [OperationContract]
        public DataSet SelectAll()
        {
            return new LocalReference.SW_Local().SelectAll();
        }

        // Agregue aquí más operaciones y márquelas con [OperationContract]
    }
}

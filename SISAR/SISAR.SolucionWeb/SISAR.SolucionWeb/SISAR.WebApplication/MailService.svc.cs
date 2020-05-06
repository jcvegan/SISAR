using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Text;

namespace SISAR.WebApplication
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class MailService
    {
        [OperationContract]
        public string SendMail(int _user,string _pass,string _email)
        {
            return new MailReference.SendMail().SendMailTo(_user, _pass, _email);
        }

        // Agregue aquí más operaciones y márquelas con [OperationContract]
    }
}

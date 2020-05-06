using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Text;
using SISAR.WebApplication.UserReference;

namespace SISAR.WebApplication
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UsuarioService
    {
        [OperationContract]
        public void DoWork()
        {
            // Agregue aquí la implementación de la operación
            return;
        }
        [OperationContract]
        public T_Usuario Authenticate(int _idUsuario, string _password)
        {
            return new UserReference.SW_Usuario().Authenticate(_idUsuario, _password);
        }
        [OperationContract]
        public string Update(T_Usuario _user)
        {
            return new UserReference.SW_Usuario().Update(_user);
        }
        [OperationContract]
        public string Register(T_Usuario _user)
        {
            return new UserReference.SW_Usuario().Insert(_user);
        }
        // Agregue aquí más operaciones y márquelas con [OperationContract]
    }
}

using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Text;
using SISAR.WebApplication.ReserveReference;

namespace SISAR.WebApplication
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ReservaService
    {
        [OperationContract]
        public string RegistrarReserva(T_Reserva _reservacion)
        {
            // Agregue aquí la implementación de la operación
            ReserveReference.SW_Reserva _reserve = new SISAR.WebApplication.ReserveReference.SW_Reserva();
            return _reserve.Insert(_reservacion);
        }
    }
}

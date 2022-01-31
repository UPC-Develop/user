using System;
using User.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace User
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IUserService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        ResponseUserEntity GetUserByUserName(String userName, Int32 active);


    }
}

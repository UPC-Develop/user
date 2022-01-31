using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using User.Entity;
using User.Repository;
using User.FaultException;

namespace User
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "UserService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione UserService.svc o UserService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class UserService : IUserService
    {



        public ResponseUserEntity GetUserByUserName(string userName, int active)
        {
            UserRepository userRepository = new UserRepository();

            ResponseUserEntity responseUserEntity = new ResponseUserEntity();

            UserEntity userEntity = new UserEntity();

            

            try
            {



                userEntity = userRepository.GetUserByUserName( userName,  active);

                if (userEntity == null)
                    throw new UserNotFoundException("No se encuentran registros.");
                else
                {
                    responseUserEntity.errorCode = string.Empty;
                    responseUserEntity.errorMessage = string.Empty;
                    responseUserEntity.isSuccess = true;
                    responseUserEntity.data = userEntity;

                }

            }
            catch (UserNotFoundException ex)
            {
                responseUserEntity.errorCode = "00001";
                responseUserEntity.errorMessage = ex.Message.ToString();
                responseUserEntity.isSuccess = false;
                responseUserEntity.data = null;

            }
            catch (Exception ex)
            {
                responseUserEntity.errorCode = "00002";
                responseUserEntity.errorMessage = ex.Message.ToString();
                responseUserEntity.isSuccess = false;
                responseUserEntity.data = null;
            }
            return responseUserEntity;
        }
    }
}

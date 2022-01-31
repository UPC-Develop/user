using System;
using System.Data;
using Dapper;
using User.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace User.Repository
{
    public class UserRepository:BaseRepository
    {
        public UserEntity GetUserByUserName(String userName, Int32 active)
        {
            var userEntity = new UserEntity();


            try
            {
                using (var db = GetSqlConnection())
                {
                    const string sql = @"Usp_Get_User_By_UserName";
                    var p = new DynamicParameters();
                    p.Add(name: "@UserName", value: active, dbType: DbType.String, direction: ParameterDirection.Input);
                    p.Add(name: "@Active", value: active, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    userEntity = db.Query<UserEntity>(sql: sql, param: p, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }

            return userEntity;
        }
    }
}
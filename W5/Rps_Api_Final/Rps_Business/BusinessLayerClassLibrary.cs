using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rps_Models;
using Rps_Repository;

namespace Rps_Business
{
    public class BusinessLayerClassLibrary
    {
        public Person Register(RegisterDto dto)
        {
            // 1. do someting to the data if necessary.
            //UserNamePasswordInDb
            Rps_RepoLayerClassLibrary repo = new Rps_RepoLayerClassLibrary();
            // 2. call a repo layer method ot chec if the username/password combo is in the DB.
            bool ret = repo.UserNamePasswordInDb(dto.UserName, dto.Password);
            if (!ret)
            {
                //create a new Person object to get a GUID id.
                Person p = Mapper.RegisterDtoToPerson(dto);

                // 3. call a repo layer method to put this data into the Db.
                int numRowsAffected = repo.RegisterNewCustomer(p);
                if (numRowsAffected == 1)
                {
                    //call another repo method that will get a person by usernames and password
                    Person p1 = repo.GetUserByUnamePword(p.UserName, p.Password);
                    return p1;
                }
            }
            return null;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rps_Models;

namespace Rps_Models
{
    public class Mapper
    {
        /// <summary>
        /// this method will take a RegisterDto object and convert it to a Person object, using the Guid that the Person object is given automatically.
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public static Person RegisterDtoToPerson(RegisterDto dto)
        {
            return new Person(dto.FirstName, dto.LastName, dto.LastOrderDate, dto.Remarks, dto.UserName, dto.Password);
        }
    }
}
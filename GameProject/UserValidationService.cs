using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationService : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName == "Zeynel Taha" && gamer.LastName == "UÇAR" && gamer.IdentityNumber == 113235664535)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}




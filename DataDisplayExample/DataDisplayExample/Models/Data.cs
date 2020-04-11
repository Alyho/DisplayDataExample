using DataDisplayExample;
using DataDisplayExample.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.DataLayer
{
    public class Data : IData
    {
        //this class does database work
        public Data()
        {
            //instantiate connection to database


        }

        public User GetUser(int userId)
        {
            //make a dtabase call to get User information/data
            if (userId == 1)
            {
                var toreturn = new User();
                toreturn.Name = "Alyssa Ho";
                toreturn.Address = "1155 Coronet Ave";
                toreturn.Email = "alyssa@gmail.com";
                toreturn.Age = 16;
                toreturn.PhoneNumber = "626-768-0273";

                return toreturn;
            }
            else if (userId == 2)
            {
                var toreturn = new User();
                toreturn.Name = "Desiree";
                toreturn.Address = "123 Main Ave";
                toreturn.Email = "desiree@yahoo.com";
                toreturn.Age = 18;
                toreturn.PhoneNumber = "626-123-4567";

                return toreturn;
            }

            return new User();
        }

        
    }
}

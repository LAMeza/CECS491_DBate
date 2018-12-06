﻿using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mock
{
    /// <summary>
    /// Class used to perform a Mock DataContext and also to store data of a User Object
    /// </summary>
    public class MockDataContext
    {
        //private int CounterID = 0;

        /// <summary>
        /// Mock DataContext used to store/edit user object data stored in a List of User objects
        /// </summary>
        public List<User> User
        {
            get
            {
                return new List<User>
                {
                    new User
                    {
                       ID = 1,
                       Name = "Bob",
                       Role = "Admin",
                       Username = "Bob2080",
                       Location = "Long Beach, CA USA",
                       Password = "Admin",
                       DOB = "12/15/1996",
                       CollectionClaims = {"View","Update", "Delete", "Create"},
                       IsAccountActivated = true
                    },
                    new User
                    {
                       ID = 2,
                       Name = "Bill",
                       Role = "System Admin",
                       Username = "Bill2080",
                       Location = "Long Beach, CA USA",
                       Password = "SystemAdmin",
                       DOB = "12/15/1987",
                       CollectionClaims = {"View","Update", "Delete", "Create", "CreateAdmin"},
                       IsAccountActivated = true

                    },
                    new User
                    {
                       ID = 3,
                       Name = "Aaron Burr",
                       Role = "Registered User",
                       Username = "VicePresident",
                       Location = "Long Beach, CA USA",
                       Password = "User1",
                       DOB = "12/15/1985",
                       CollectionClaims = {"View"},
                       IsAccountActivated = true
                    }
                };
            }
        }
    }

}

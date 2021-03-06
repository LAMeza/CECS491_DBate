﻿using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;

namespace ServiceLayer.Authorization
{
    /// <summary>
    /// Authorization management class
    /// </summary>
    public class AuthorizationManager
    {
        /// <summary>
        /// User Object that contains information of the specific user
        /// </summary>
        public User user = new User();

        /// <summary>
        /// Method that checks whether a specific user is authorized for something
        /// </summary>
        /// <param name="claim">contains claim that is going to be checked for authorization</param>
        /// <returns></returns>
        public bool CheckAccess(Claim claim)
        {
            bool access;

            try
            {
                //if (user.CollectionClaims.Contains(claim))
                if(user.CollectionClaims.Contains(claim))
                {
                    access = true;
                }
                else
                {
                    access = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return access;
        }

        /// <summary>
        /// Method that checks whether a specific user is authorized for something from the system
        /// </summary>
        /// <param name="claim">contains claim that is going to be checked for authorization</param>
        /// <returns>access = true or false</returns>
        //MIGHT HAVE TO FIX THIS 
        /*public bool CheckAccessSystem(string claim)
        {
            ConstantRoleClaims crc = new ConstantRoleClaims();
            bool access = true;
            List<string> systemClaims = crc.GetSystemClaims();


            if (systemClaims.Contains(claim))
            {
                access = true;
                Console.WriteLine("Hello3");
            }
            else
            {
                access = false;
                Console.WriteLine("Hello2");
            }

            return access;
        }*/
    }
}

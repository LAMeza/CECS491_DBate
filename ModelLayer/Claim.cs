﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Claim
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }
        public string ClaimName { get; set; }

        #region Constructors
        public Claim()
        {

        }

        public Claim(int id, string c)
        {
            ID = id;
            ClaimName = c;
        }
        #endregion
    }
}


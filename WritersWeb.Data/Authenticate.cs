﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WritersWeb.Base;

namespace WritersWeb.Data
{
    public class Authenticate : WorkingBase<Authenticate>
    {
        #region Properties

        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string GroupRights { get; set; }

        #endregion

        #region Factory Methods

        private Authenticate(Csla.Data.SafeDataReader dr)
        {
            Fetch(dr);
        }

        static internal Authenticate GetData(Csla.Data.SafeDataReader dr)
        {
            return new Authenticate(dr);
        }

        public Authenticate() { }

        #endregion

        #region Data Access

        private void Fetch(Csla.Data.SafeDataReader dr)
        {
            //IdTest = dr.GetInt32("");       //  inside "" is from sp column returned
            Username = dr.GetString("Username");
            Password = dr.GetString("Password");
            Fullname = dr.GetString("Fullname");
            GroupRights = dr.GetString("GroupRights");

            //Mark this data as persisted in the data store
            MarkOld();

            UserProfile.SetProperties(Username, Password, Fullname, GroupRights);
        }

        #endregion
    }
}

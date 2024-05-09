using RAiso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAiso.Repositories
{
    public class DatabaseSingleton
    {
        private static RAisoDatabaseEntities db = null;

        public static RAisoDatabaseEntities GetInstance()
        {
            if (db == null)
            {
                db = new RAisoDatabaseEntities();
            }
            return db;
        }
    }
}
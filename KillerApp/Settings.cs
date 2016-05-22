using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerApp
{
    class Settings
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\mac\home\documents\visual studio 2015\Projects\KillerApp\KillerApp\KillerAppDB.mdf;Integrated Security=True";

        public string ConnectionString
        {
            get { return connectionString; }
        }
    }
}

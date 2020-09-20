using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MilanovicMatej
{
    public static class BazaPodataka
    {
        public static SqlConnection konekcija()
        {
            return new SqlConnection(@"Data Source=DESKTOP-E8MTTAK;Initial Catalog=Projekt;Integrated Security=True");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class cls_Conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=YOYITO\\SQLEXPRESS01;Initial Catalog=dbs_prestamos_deportivos;Integrated security = true");
    }
}
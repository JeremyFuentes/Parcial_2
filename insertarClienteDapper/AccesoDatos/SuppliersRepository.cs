using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class SuppliersRepository
    {
        public List<Suppliers> ObtenerTodos()
        {
            using (var conexion = Database.GetSqlConnection())
            {
                String SelcetAll = "";
                SelcetAll = SelcetAll + "SELECT [SupplierID] " + "\n";
                SelcetAll = SelcetAll + "      ,[CompanyName] " + "\n";
                SelcetAll = SelcetAll + "      ,[ContactName] " + "\n";
                SelcetAll = SelcetAll + "      ,[ContactTitle] " + "\n";
                SelcetAll = SelcetAll + "      ,[Address] " + "\n";
                SelcetAll = SelcetAll + "      ,[City] " + "\n";
                SelcetAll = SelcetAll + "      ,[Region] " + "\n";
                SelcetAll = SelcetAll + "      ,[PostalCode] " + "\n";
                SelcetAll = SelcetAll + "      ,[Country] " + "\n";
                SelcetAll = SelcetAll + "      ,[Phone] " + "\n";
                SelcetAll = SelcetAll + "      ,[Fax] " + "\n";
                SelcetAll = SelcetAll + "      ,[HomePage] " + "\n";
                SelcetAll = SelcetAll + "  FROM [dbo].[Suppliers]";

                var categoria = conexion.Query<Suppliers>(SelcetAll).ToList();
                return categoria;
            }
        }

    }
}

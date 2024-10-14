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

        public int InsertarProveedor(Suppliers suppliers)
        {
            using (var conexion = Database.GetSqlConnection())
            {
                String insertar = "";
                insertar = insertar + "INSERT INTO [dbo].[Suppliers] " + "\n";
                insertar = insertar + "           ([CompanyName] " + "\n";
                insertar = insertar + "           ,[ContactName] " + "\n";
                insertar = insertar + "           ,[ContactTitle] " + "\n";
                insertar = insertar + "           ,[Address] " + "\n";
                insertar = insertar + "           ,[City]) " + "\n";
                insertar = insertar + " " + "\n";
                insertar = insertar + "     VALUES " + "\n";
                insertar = insertar + "           (@CompanyName " + "\n";
                insertar = insertar + "           ,@ContactName " + "\n";
                insertar = insertar + "           ,@ContactTitle " + "\n";
                insertar = insertar + "           ,@Address " + "\n";
                insertar = insertar + "           ,@City)";



                var insertadas = conexion.Execute(insertar, new
                {
                    CompanyName = suppliers.CompanyName, 
                    ContactName = suppliers.ContactName,
                    ContactTitle = suppliers.ContactTitle,
                    Address = suppliers.Address,
                    City = suppliers.City
                });

                return insertadas;
            }

        }

    }
}

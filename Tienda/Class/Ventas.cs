using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Class
{
    class Ventas
    {
        public static bool addNewSale(string _productName, string _productType, string _size, float price, string sex, int amount, int dia, int mes, int año)
        {
            bool canInsert = false;
            string commandText = "INSERT INTO Ventas (Producto,Tipo,Talle,Precio,Sexo,Cantidad,Dia,Mes,Año) values (@producto, @tipo,@talle,@precio,@sexo,@cantidad,@dia,@mes,@año)";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
            command.Parameters.Add("@producto", SqlDbType.VarChar, 50).Value = _productName;
            command.Parameters.Add("@tipo", SqlDbType.VarChar, 25).Value = _productType;
            command.Parameters.Add("@talle", SqlDbType.VarChar, 10).Value = _size;
            command.Parameters.Add("@precio", SqlDbType.Float).Value = price;
            command.Parameters.Add("@sexo", SqlDbType.VarChar, 25).Value = sex;
            command.Parameters.Add("@cantidad", SqlDbType.Int, 10).Value = amount;
            command.Parameters.Add("@dia", SqlDbType.Int, 10).Value = dia;
            command.Parameters.Add("@mes", SqlDbType.Int, 10).Value = mes;
            command.Parameters.Add("@año", SqlDbType.Int, 10).Value = año;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canInsert = true;
            }

            return canInsert;
        }
    }
}

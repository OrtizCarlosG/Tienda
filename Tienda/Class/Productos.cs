using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Class
{
    class Productos
    {

        private DataTable _productos;
        public DataTable getProductos()
        {
            _productos.Clear();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT Producto,Tipo,Talle,Precio,Sexo,Cantidad,RawCode FROM Productos ORDER BY Sexo";
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            sqlDataAdap.Fill(_productos);

            return _productos;
        }

        public static bool addNewProduct(string _productName, string _productType, string _size, float price, string sex, int amount)
        {
            bool canInsert = false;
            string codigo = $"7{RandomCode()}";
            while (doesProductCodeExists(codigo))
            {
                codigo = $"7{RandomCode()}";
            }
            BarcodeLib.Barcode Code = new BarcodeLib.Barcode();
            Code.Encode(BarcodeLib.TYPE.EAN13, codigo);
            string commandText = "INSERT INTO Productos (Producto,Tipo,Talle,Precio,Sexo,Cantidad,Codigo,RawCode) values (@producto, @tipo,@talle,@precio,@sexo,@cantidad,@codigo,@rawcode)";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
            command.Parameters.Add("@producto", SqlDbType.VarChar, 50).Value = _productName;
            command.Parameters.Add("@tipo", SqlDbType.VarChar, 25).Value = _productType;
            command.Parameters.Add("@talle", SqlDbType.VarChar, 10).Value = _size;
            command.Parameters.Add("@precio", SqlDbType.Float).Value = price;
            command.Parameters.Add("@sexo", SqlDbType.VarChar, 25).Value = sex;
            command.Parameters.Add("@cantidad", SqlDbType.Int, 10).Value = amount;
            command.Parameters.Add("@codigo", SqlDbType.VarChar, 100).Value = codigo;
            command.Parameters.Add("@rawcode", SqlDbType.VarChar, 100).Value = Code.RawData;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canInsert = true;
            }
            return canInsert;
        }

        public static void updateProductData(string oldName, string newName, string oldType, string newType, string oldSize, string newSize, float oldPrice, float newPrice, string oldSex, string newSex, int oldAmount, int newAmount)
        {
            string commandText = "UPDATE Productos SET Producto = @producto, Tipo = @tipo, Talle = @talle, Precio = @precio, Sexo = @sexo, Cantidad = @cantidad WHERE Producto = @oldProd AND Tipo = @oldType AND Talle = @oldSize AND Precio = @oldPrice AND Sexo = @oldSex AND Cantidad = @oldAmount";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
            command.Parameters.Add("@producto", SqlDbType.VarChar, 50).Value = newName;
            command.Parameters.Add("@tipo", SqlDbType.VarChar, 25).Value = newType;
            command.Parameters.Add("@talle", SqlDbType.VarChar, 10).Value = newSize;
            command.Parameters.Add("@precio", SqlDbType.Float, 10).Value = newPrice;
            command.Parameters.Add("@sexo", SqlDbType.VarChar, 25).Value = newSex;
            command.Parameters.Add("@cantidad", SqlDbType.Int, 10).Value = newAmount;
            command.Parameters.Add("@oldProd", SqlDbType.VarChar, 50).Value = oldName;
            command.Parameters.Add("@oldType", SqlDbType.VarChar, 25).Value = oldType;
            command.Parameters.Add("@oldSize", SqlDbType.VarChar, 10).Value = oldSize;
            command.Parameters.Add("@oldPrice", SqlDbType.Float, 10).Value = oldPrice;
            command.Parameters.Add("@oldSex", SqlDbType.VarChar, 25).Value = oldSex;
            command.Parameters.Add("@oldAmount", SqlDbType.Int, 10).Value = oldAmount;
            command.ExecuteNonQuery();
        }
        public static bool DeleteProduct(string productName, string productType, string size, float price, string sex, int amount )
        {
            bool canInsert = false;
            string commandText = "DELETE FROM Productos WHERE Producto = @producto AND Tipo = @tipo AND Talle = @talle AND Precio = @precio AND Sexo = @sexo AND Cantidad = @cantidad";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
            command.Parameters.Add("@producto", SqlDbType.VarChar, 50).Value = productName;
            command.Parameters.Add("@tipo", SqlDbType.VarChar, 25).Value = productType;
            command.Parameters.Add("@talle", SqlDbType.VarChar, 10).Value = size;
            command.Parameters.Add("@precio", SqlDbType.Float, 10).Value = price;
            command.Parameters.Add("@sexo", SqlDbType.VarChar, 25).Value = sex;
            command.Parameters.Add("@cantidad", SqlDbType.Int, 10).Value = amount;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canInsert = true;
            }

            return canInsert;
        }
        public static bool doesProductExists(string _productName, string _productType)
        {
            bool exists = false;
            string commandText = "SELECT * FROM Productos WHERE Producto = @producto AND Tipo = @tipo";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
            command.Parameters.Add("@producto", SqlDbType.VarChar, 50).Value = _productName;
            command.Parameters.Add("@tipo", SqlDbType.VarChar, 25).Value = _productType;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                exists = true;
            }
            return exists;
        }

        public static bool doesProductCodeExists(string code)
        {
            bool exists = false;
            string commandText = "SELECT * FROM Productos WHERE Codigo = @codigo";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
            command.Parameters.Add("@codigo", SqlDbType.VarChar, 100).Value = code;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                exists = true;
            }
            return exists;
        }

        public static bool doesProductRawCodeExists(string code)
        {
            bool exists = false;
            string commandText = "SELECT * FROM Productos WHERE RawCode = @codigo";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
            command.Parameters.Add("@codigo", SqlDbType.VarChar, 100).Value = code;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                exists = true;
            }
            return exists;
        }




        public static string getProductCode(string productName, string producType, string productSize, float productPrice)
        {
            string code = "";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Productos WHERE Producto = @producto AND Tipo = @tipo AND Talle = @talle AND Precio = @precio";
            sqlCmd.Parameters.Add("@producto", SqlDbType.VarChar, 50).Value = productName;
            sqlCmd.Parameters.Add("@tipo", SqlDbType.VarChar, 25).Value = producType;
            sqlCmd.Parameters.Add("@talle", SqlDbType.VarChar, 10).Value = productSize;
            sqlCmd.Parameters.Add("@precio", SqlDbType.Float).Value = productPrice;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    code = reader[7].ToString();
                }
            }
            return code;
        }

        public static string getProductRawCode(string productName, string producType, string productSize)
        {
            string code = "";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Productos WHERE Producto = @producto AND Tipo = @tipo AND Talle = @talle";
            sqlCmd.Parameters.Add("@producto", SqlDbType.VarChar, 50).Value = productName;
            sqlCmd.Parameters.Add("@tipo", SqlDbType.VarChar, 25).Value = producType;
            sqlCmd.Parameters.Add("@talle", SqlDbType.VarChar, 10).Value = productSize;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    code = reader[7].ToString();
                }
            }
            return code;
        }

        public string getProductNameFromCode(string code)
        {
            string name = "";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Productos WHERE RawCode = @codigo";
            sqlCmd.Parameters.Add("@codigo", SqlDbType.VarChar, 100).Value = code;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    name = reader[1].ToString();
                }
            }
            return name;
        }

        public string getProductTypeFromCode(string code)
        {
            string name = "";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Productos WHERE RawCode = @codigo";
            sqlCmd.Parameters.Add("@codigo", SqlDbType.VarChar, 100).Value = code;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    name = reader[2].ToString();
                }
            }
            return name;
        }

        public string getProductSizeFromCode(string code)
        {
            string size = "";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Productos WHERE RawCode = @codigo";
            sqlCmd.Parameters.Add("@codigo", SqlDbType.VarChar, 100).Value = code;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    size = reader[3].ToString();
                }
            }
            return size;
        }

        public float getProductPriceFromCode(string code)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Productos WHERE RawCode = @codigo";
            sqlCmd.Parameters.Add("@codigo", SqlDbType.VarChar, 100).Value = code;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = float.Parse(reader[4].ToString());
                }
            }
            return price;
        }

        public string getProductSexFromCode(string code)
        {
            string sex = "";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Productos WHERE RawCode = @codigo";
            sqlCmd.Parameters.Add("@codigo", SqlDbType.VarChar, 100).Value = code;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    sex = reader[5].ToString();
                }
            }
            return sex;
        }

        public float getProductsTotalPrice()
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Productos";
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price += float.Parse(reader[4].ToString()) * int.Parse(reader[6].ToString());
                }
            }
            return price;
        }

        public int getProductAmount(string productName, string type, string size, float productPrice, string sex)
        {
            int amount = 0;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Productos WHERE Producto = @producto AND Tipo = @tipo AND Talle = @talle AND Precio = @precio AND Sexo = @sexo";
            sqlCmd.Parameters.Add("@producto", SqlDbType.VarChar, 50).Value = productName;
            sqlCmd.Parameters.Add("@tipo", SqlDbType.VarChar, 25).Value = type;
            sqlCmd.Parameters.Add("@talle", SqlDbType.VarChar, 10).Value = size;
            sqlCmd.Parameters.Add("@precio", SqlDbType.Float).Value = productPrice;
            sqlCmd.Parameters.Add("@sexo", SqlDbType.VarChar, 25).Value = sex;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    amount = int.Parse(reader[6].ToString());
                }
            }
            return amount;
        }

        public static void updateProductStock(string product, string type, string size, float price, string sex, int newAmount)
        {
            if (doesProductExists(product, type))
            {
                string commandText = "UPDATE Productos SET Cantidad = @cantidad WHERE Producto = @producto AND Tipo = @tipo AND Talle = @talle AND Sexo = @sexo AND Precio = @precio";
                SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
                command.Parameters.Add("@producto", SqlDbType.VarChar, 50).Value = product;
                command.Parameters.Add("@tipo", SqlDbType.VarChar, 25).Value = type;
                command.Parameters.Add("@talle", SqlDbType.VarChar, 10).Value = size;
                command.Parameters.Add("@sexo", SqlDbType.VarChar, 25).Value = sex;
                command.Parameters.Add("@precio", SqlDbType.Float).Value = price;
                command.Parameters.Add("@cantidad", SqlDbType.Int, 10).Value = newAmount;
                command.ExecuteNonQuery();
            }
        }
        public Productos()
        {
            _productos = new DataTable();
        }

        public static string RandomCode()
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string( Enumerable.Repeat(chars, 12)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Class
{
    class Finanzas
    {
        private DataTable _detalles;
        public Finanzas()
        {
            _detalles = new DataTable();
        }
        public DataTable getFinancesDetailsOfDay(int day, int month, int year)
        {
            _detalles.Clear();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT id,Detalle,Tipo,Monto,AbonadoCon FROM Finanzas WHERE Dia = @day AND Mes = @month AND Año = @year";
            sqlCmd.Parameters.Add("@day", SqlDbType.Int, 10).Value = day;
            sqlCmd.Parameters.Add("@month", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@year", SqlDbType.Int, 10).Value = year;
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            sqlDataAdap.Fill(_detalles);

            return _detalles;
        }

        public DataTable getFinancesDetailsOfDate(int month, int year)
        {
            _detalles.Clear();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT id,Detalle,Tipo,Monto,Dia,AbonadoCon FROM Finanzas WHERE Mes = @month AND Año = @year";
            sqlCmd.Parameters.Add("@month", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@year", SqlDbType.Int, 10).Value = year;
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            sqlDataAdap.Fill(_detalles);

            return _detalles;
        }

        public DataTable getFinancesDetailsOfDate(int year)
        {
            _detalles.Clear();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT id,Detalle,Tipo,Monto,Dia,Mes,AbonadoCon FROM Finanzas WHERE Año = @year";
            sqlCmd.Parameters.Add("@year", SqlDbType.Int, 10).Value = year;
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            sqlDataAdap.Fill(_detalles);

            return _detalles;
        }
        public DataTable getFinancesDetailsOfDate(int day, int month, int year)
        {
            _detalles.Clear();
            _detalles.Columns.Clear();
            _detalles.Columns.Add("id", typeof(int));
            _detalles.Columns.Add("Detalle", typeof(String));
            _detalles.Columns.Add("Tipo", typeof(String));
            _detalles.Columns.Add("AbonadoCon", typeof(String));
            _detalles.Columns.Add("Monto", typeof(float));
            _detalles.Columns.Add("Dia", typeof(Int32));
            DateTime dateValue = new DateTime(year, month, day);
            int dow = (int)dateValue.DayOfWeek;
            while (dow > 1)
            {
                dateValue = dateValue.AddDays(-1);
                dow = (int)dateValue.DayOfWeek;
            }
            for (int i = 0; i < 6; i++)
            {
                if (dow >= 1 && dow < 6)
                {
                    day = dateValue.Day;
                    dow = (int)dateValue.DayOfWeek;
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = Globals.getSQLCon().cnn;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "SELECT id,Detalle,Tipo,Monto,Dia,AbonadoCon FROM Finanzas WHERE Dia = @day AND Mes = @month AND Año = @year";
                    sqlCmd.Parameters.Add("@day", SqlDbType.Int, 10).Value = day;
                    sqlCmd.Parameters.Add("@month", SqlDbType.Int, 10).Value = month;
                    sqlCmd.Parameters.Add("@year", SqlDbType.Int, 10).Value = year;
                    var value = sqlCmd.ExecuteScalar();
                    if (value != null)
                    {
                        SqlDataReader reader = sqlCmd.ExecuteReader();
                        while (reader.Read())
                        {
                            int _id = int.Parse(reader[0].ToString());
                            string _detalle = reader[1].ToString();
                            string _tipo = reader[2].ToString();
                            float _monto = float.Parse(reader[3].ToString());
                            int _dia = int.Parse(reader[4].ToString());
                            string _abonado = reader[5].ToString();
                            _detalles.Rows.Add(new Object[]{
                            _id,
                            _detalle,
                            _tipo,
                            _abonado,
                            _monto,
                            _dia
                            });
                            _detalles.AcceptChanges();
                        }
                    }
                    dateValue = dateValue.AddDays(1);
                }
            }
            return _detalles;
        }

        public DataTable getLostsOfDayForm(int day, int month, int year)
        {
            _detalles.Clear();
            _detalles.Columns.Clear();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT id,Detalle,Monto FROM Finanzas WHERE Dia = @dia AND Mes = @month AND Año = @year AND Tipo = 'GASTO'";
            sqlCmd.Parameters.Add("@dia", SqlDbType.Int, 10).Value = day;
            sqlCmd.Parameters.Add("@month", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@year", SqlDbType.Int, 10).Value = year;
            SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

            sqlDataAdap.Fill(_detalles);

            return _detalles;
        }

        public static bool addNewFinanceDetail(string detalle, string tipo, float monto, int dia, int mes, int año, string abonado)
        {
            bool canInsert = false;
            string commandText = "INSERT INTO Finanzas (Detalle,Tipo,Monto,Dia,Mes,Año,AbonadoCon) values (@detalle, @tipo,@monto,@dia,@mes,@año,@abonado)";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
            command.Parameters.Add("@detalle", SqlDbType.VarChar, 150).Value = detalle;
            command.Parameters.Add("@tipo", SqlDbType.VarChar, 25).Value = tipo;
            command.Parameters.Add("@monto", SqlDbType.Float).Value = monto;
            command.Parameters.Add("@dia", SqlDbType.Int, 10).Value = dia;
            command.Parameters.Add("@mes", SqlDbType.Int, 10).Value = mes;
            command.Parameters.Add("@año", SqlDbType.Int, 10).Value = año;
            command.Parameters.Add("@abonado", SqlDbType.VarChar, 50).Value = abonado;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canInsert = true;
            }

            return canInsert;
        }

        public static void UpdateFinanceDetail(int _id, string _detalle, float _monto)
        {
            string commandText = "UPDATE Finanzas SET Detalle = @detalle, Monto = @monto WHERE id = @id";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
            command.Parameters.Add("@detalle", SqlDbType.VarChar, 50).Value = _detalle;
            command.Parameters.Add("@monto", SqlDbType.Float, 10).Value = _monto;
            command.Parameters.Add("@id", SqlDbType.Int, 10).Value = _id;
            command.ExecuteNonQuery();
        }

        public static bool DeleteFinanza(int id)
        {
            bool canInsert = false;
            string commandText = "DELETE FROM Finanzas WHERE id = @id";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
            command.Parameters.Add("@id", SqlDbType.Int, 15).Value = id;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canInsert = true;
            }

            return canInsert;
        }

        public static bool DeleteFinance(int id)
        {
            bool canInsert = false;
            string commandText = "DELETE FROM Finanzas WHERE id=@id";
            SqlCommand command = new SqlCommand(commandText, Globals.getSQLCon().cnn);
            command.Parameters.Add("@id", SqlDbType.Int, 10).Value = id;
            var value = command.ExecuteScalar();
            if (value != null)
            {
                canInsert = true;
            }

            return canInsert;
        }

        public float getSellsOfDayEfectivo(int day, int month, int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Dia = @dia AND Mes = @mes AND Año = @año AND AbonadoCon = 'Efectivo'";
            sqlCmd.Parameters.Add("@dia", SqlDbType.Int, 10).Value = day;
            sqlCmd.Parameters.Add("@mes", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price +  float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        public float getSellsOfDayTarjeta(int day, int month, int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Dia = @dia AND Mes = @mes AND Año = @año AND AbonadoCon = 'Tarjeta'";
            sqlCmd.Parameters.Add("@dia", SqlDbType.Int, 10).Value = day;
            sqlCmd.Parameters.Add("@mes", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        public float getSellsOfDayCuentaDNI(int day, int month, int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Dia = @dia AND Mes = @mes AND Año = @año AND AbonadoCon = 'Cuenta DNI'";
            sqlCmd.Parameters.Add("@dia", SqlDbType.Int, 10).Value = day;
            sqlCmd.Parameters.Add("@mes", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        public float getSellsOfDayMercadoPago(int day, int month, int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Dia = @dia AND Mes = @mes AND Año = @año AND AbonadoCon = 'MercadoPago'";
            sqlCmd.Parameters.Add("@dia", SqlDbType.Int, 10).Value = day;
            sqlCmd.Parameters.Add("@mes", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        public float getLostsOfDay(int day, int month, int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'GASTO' AND Dia = @dia AND Mes = @mes AND Año = @año";
            sqlCmd.Parameters.Add("@dia", SqlDbType.Int, 10).Value = day;
            sqlCmd.Parameters.Add("@mes", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }


        // MES
        public float getSellsOfMonthEfectivo(int month, int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Mes = @mes AND Año = @año AND AbonadoCon = 'Efectivo'";
            sqlCmd.Parameters.Add("@mes", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }


        public float getSellsOfMonthTarjeta(int month, int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Mes = @mes AND Año = @año AND AbonadoCon = 'Tarjeta'";
            sqlCmd.Parameters.Add("@mes", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        public float getSellsOfMonthDNI(int month, int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Mes = @mes AND Año = @año AND AbonadoCon = 'Cuenta DNI'";
            sqlCmd.Parameters.Add("@mes", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        public float getSellsOfMonthMercadoPago(int month, int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Mes = @mes AND Año = @año AND AbonadoCon = 'MercadoPago'";
            sqlCmd.Parameters.Add("@mes", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        public float getLostsOfMonth(int month, int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'GASTO' AND Mes = @mes AND Año = @año";
            sqlCmd.Parameters.Add("@mes", SqlDbType.Int, 10).Value = month;
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        // AÑO
        public float getSellsOfYear(int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Año = @año AND AbonadoCon = 'Efectivo'";
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        public float getSellsOfYearTarjeta(int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Año = @año AND AbonadoCon = 'Tarjeta'";
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        public float getSellsOfYearDNI(int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Año = @año AND AbonadoCon = 'Cuenta DNI'";
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        public float getSellsOfYearMercadoPago(int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'INGRESO' AND Año = @año AND AbonadoCon = 'MercadoPago'";
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        public float getLostsOfYear(int year)
        {
            float price = 0f;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'GASTO' AND Año = @año";
            sqlCmd.Parameters.Add("@año", SqlDbType.Int, 10).Value = year;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    price = price + float.Parse(reader[3].ToString());
                }
            }
            return price;
        }

        // SEMANAL
        public float getSellsOfWeek(int dia, int mes, int año)
        {
            float price = 0;
            DateTime dateValue = new DateTime(año, mes, dia);
            int dow = (int)dateValue.DayOfWeek;
            while (dow > 1)
            {
                dateValue = dateValue.AddDays(-1);
                dow = (int)dateValue.DayOfWeek;
            }
            for (int i = 0; i < 6; i++)
            {
                if (dow >= 1 && dow < 6)
                {
                    dia = dateValue.Day;
                    dow = (int)dateValue.DayOfWeek;
                    price = price + getSellsOfDayEfectivo(dia, mes, año);
                    dateValue = dateValue.AddDays(1);

                }
            }
            return price;
        }

        public float getSellsOfWeekTarjeta(int dia, int mes, int año)
        {
            float price = 0;
            DateTime dateValue = new DateTime(año, mes, dia);
            int dow = (int)dateValue.DayOfWeek;
            while (dow > 1)
            {
                dateValue = dateValue.AddDays(-1);
                dow = (int)dateValue.DayOfWeek;
            }
            for (int i = 0; i < 6; i++)
            {
                if (dow >= 1 && dow < 6)
                {
                    dia = dateValue.Day;
                    dow = (int)dateValue.DayOfWeek;
                    price = price + getSellsOfDayTarjeta(dia, mes, año);
                    dateValue = dateValue.AddDays(1);

                }
            }
            return price;
        }

        public float getSellsOfWeekDNI(int dia, int mes, int año)
        {
            float price = 0;
            DateTime dateValue = new DateTime(año, mes, dia);
            int dow = (int)dateValue.DayOfWeek;
            while (dow > 1)
            {
                dateValue = dateValue.AddDays(-1);
                dow = (int)dateValue.DayOfWeek;
            }
            for (int i = 0; i < 6; i++)
            {
                if (dow >= 1 && dow < 6)
                {
                    dia = dateValue.Day;
                    dow = (int)dateValue.DayOfWeek;
                    price = price + getSellsOfDayCuentaDNI(dia, mes, año);
                    dateValue = dateValue.AddDays(1);

                }
            }
            return price;
        }

        public float getSellsOfWeekMercadoPago(int dia, int mes, int año)
        {
            float price = 0;
            DateTime dateValue = new DateTime(año, mes, dia);
            int dow = (int)dateValue.DayOfWeek;
            while (dow > 1)
            {
                dateValue = dateValue.AddDays(-1);
                dow = (int)dateValue.DayOfWeek;
            }
            for (int i = 0; i < 6; i++)
            {
                if (dow >= 1 && dow < 6)
                {
                    dia = dateValue.Day;
                    dow = (int)dateValue.DayOfWeek;
                    price = price + getSellsOfDayMercadoPago(dia, mes, año);
                    dateValue = dateValue.AddDays(1);

                }
            }
            return price;
        }

        public float getLostsOfWeek(int dia, int mes, int año)
        {
            float price = 0;
            DateTime dateValue = new DateTime(año, mes, dia);
            int dow = (int)dateValue.DayOfWeek;
            while (dow > 1)
            {
                dateValue = dateValue.AddDays(-1);
                dow = (int)dateValue.DayOfWeek;
            }
            for (int i = 0; i < 7; i++)
            {
                if (dow >= 1 && dow < 6)
                {
                    dia = dateValue.Day;
                    dow = (int)dateValue.DayOfWeek;
                    price = price + getLostsOfDay(dia, mes, año);
                    dateValue = dateValue.AddDays(1);
                }
            }
            return price;
        }

        // GASTOS
        public string getLostDetailFromID(int id)
        {
            string gasto = "";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'GASTO' AND id = @id";
            sqlCmd.Parameters.Add("@id", SqlDbType.Int, 10).Value = id;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    gasto = reader.GetString(1);
                }
            }
            return gasto;
        }

        public float getLostAmountFromID(int id)
        {
            float gasto = 0;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = Globals.getSQLCon().cnn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM Finanzas WHERE Tipo = 'GASTO' AND id = @id";
            sqlCmd.Parameters.Add("@id", SqlDbType.Int, 10).Value = id;
            var value = sqlCmd.ExecuteScalar();
            if (value != null)
            {
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    gasto = float.Parse(reader[3].ToString());
                }
            }
            return gasto;
        }
    }
}

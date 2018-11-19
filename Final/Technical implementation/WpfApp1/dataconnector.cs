using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WpfApp1
{
    public static class Global
    {
        public static DatabaseConnectors database = new DatabaseConnectors("green_ict_application");
        public static InformationSchema informationSchema = new InformationSchema();
        public static string userID;
        public static string[] RemoveArrayWIndex(string[] myArray, int index)
        {
            List<string> myList = myArray.ToList();
            myList.RemoveAt(index);
            myArray = myList.ToArray();
            return myArray;
        }

        //Adjust time input to format 0:00, 0:15, 0:30, 0:45:
        public static string TimeAdjuster(string inputTime)
        {
            int hour;
            int minute;
            //Take hour and minute value:
            if (inputTime.Length == 8) 
            {
                hour = int.Parse(inputTime.Substring(0, 2));
                minute = int.Parse(inputTime.Substring(3, 2));
            }
            else
            {
                hour = int.Parse(inputTime.Substring(0, 1));
                minute = int.Parse(inputTime.Substring(2, 2));
            }
            //adjust minutes:
            if (minute <= 7) 
            {
                minute = 0;
            }
            else if (minute > 8 && minute <= 22)
            {
                minute = 15;
            }
            else if (minute <= 37)
            {
                minute = 30;
            }
            else if (minute <= 52)
            {
                minute = 45;
            }
            else
            {
                minute = 0;
                hour++;
            }
            //Check if AM or PM:
            if (inputTime.Contains("PM") && hour != 12) 
            {
                hour += 12;
            }
            if (inputTime.Contains("AM") && hour == 12)
            {
                hour = 0;
            }
            
            inputTime = hour + ":" + minute;
            if (minute == 0)
                inputTime += "0";
            return inputTime;
        }
        public static string EndTimeAdjuster(string inputTime)
        {
            int hour;
            int minute;
            //Take hour and minute value:
            if (inputTime.Length == 8)
            {
                hour = int.Parse(inputTime.Substring(0, 2));
                minute = int.Parse(inputTime.Substring(3, 2));
            }
            else
            {
                hour = int.Parse(inputTime.Substring(0, 1));
                minute = int.Parse(inputTime.Substring(2, 2));
            }
            //adjust minutes:
            if (minute < 15)
            {
                minute = 0;
            }
            else if (minute <= 29)
            {
                minute = 15;
            }
            else if (minute <= 44)
            {
                minute = 30;
            }
            else 
            {
                minute = 45;
            }
            //Check if AM or PM:
            if (inputTime.Contains("PM") && hour != 12)
            {
                hour += 12;
            }
            if (inputTime.Contains("AM") && hour == 12)
            {
                hour = 0;
            }

            inputTime = hour + ":" + minute;
            if (minute == 0)
                inputTime += "0";
            return inputTime;
        }
        public static string Add15Minutes(string inputTime)
        {
            int hour;
            int minute;
            if (inputTime.Length == 5) //Take hour and minute value:
            {
                hour = int.Parse(inputTime.Substring(0, 2));
                minute = int.Parse(inputTime.Substring(3, 2));
            }
            else
            {
                hour = int.Parse(inputTime.Substring(0, 1));
                minute = int.Parse(inputTime.Substring(2, 2));
            }

            switch (minute)
            {
                case 0:
                    {
                        minute = 15;
                        break;
                    }
                case 15:
                    {
                        minute = 30;
                        break;
                    }
                case 30:
                    {
                        minute = 45;
                        break;
                    }
                case 45:
                    {
                        minute = 0;
                        hour++;
                        break;
                    }
            }
            inputTime = hour + ":" + minute;
            if (minute == 0)
                inputTime += "0";

            return inputTime;
        }
        public static int GetHour(string inputTime)
        {
            if (inputTime.Length == 5) //Take hour and minute value:
            {
                return int.Parse(inputTime.Substring(0, 2));;
            }
            else
            {
                return int.Parse(inputTime.Substring(0, 1));
            }
        }
        public static int GetMinute(string inputTime)
        {
            if (inputTime.Length == 5) //Take hour and minute value:
            {
                return int.Parse(inputTime.Substring(3, 2));
            }
            else
            {
                return int.Parse(inputTime.Substring(2, 2));
            }
        }
        public static string StringFromArray(string[] myArray)
        {
            string myString = "";
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i != myArray.Length -1)
                {
                    myString += myArray[i] + " - ";
                }
                else
                {
                    myString += myArray[i];
                }
            }
            return myString;
        }
        public static void UpdateProfile(string userName, string userMail, string realName)
        {
            Global.database.Update("user_table", "user_name", userName, "user_table_id = " + Global.userID);
            Global.database.Update("user_table", "email", userMail, "user_table_id = " + Global.userID);
            Global.database.Update("user_table", "real_name", realName, "user_table_id = " + Global.userID);
        }
    }
    public class Time
    {
        public string id { get; set; }
        public string IDs { get; set; }
        public string StartTimes { get; set; }
        public string Date { get; set; }
        public bool Selected { get; set; }
    }
    public class Appointment
    {
        public string realID { get; set; }
        public string ID { get; set; }
        public string ProductName { get; set; }
        public string ServicePerson { get; set; }
        public string ClientName { get; set; }
        public string Place { get; set; }
        public string StartTime { get; set; }
        public string Date { get; set; }
        public bool IsSelected { get; set; }
    }
    public class Place
    {
        public string realID { get; set; }
        public string ID { get; set; }
        public string AppointmentPlace { get; set; }
        public string Room { get; set; }
        public string IsSelected { get; set; }
    }
    public class Product
    {
        public string ID { get; set; }
        public string RealID { get; set; }
        public string ProductName { get; set; }
        public string Duration { get; set; }
        public string Place { get; set; }
        public bool IsSelected { get; set; }
    }
    public class Users
    {
        public string ID { get; set; }
        public string RealName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool Checker { get; set; }
    }
    public class DatabaseConnectors
    {
        private string myConnectionString;
        private MySqlConnection connection;
        private MySqlCommand command;

        public DatabaseConnectors(string databaseName)
        {
            myConnectionString = "Server=localhost;Database=" + databaseName + ";Uid=Tom2lua;Pwd=Hexastudio123;";
            connection = new MySqlConnection(myConnectionString);
            command = connection.CreateCommand();
        }
        public void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void CloseConnection()
        {
            connection.Close();
        }
        private string WhereCheck(string command, string whereStatement)
        {
            if (whereStatement != null)
            {
                command += " WHERE " + whereStatement;
            }
            return command;
        }
        private string SelectCommand(string type, string table, string column, string whereStatement)
        {
            string text = "";
            switch (type)
            {
                case "S":
                    text += "SELECT " + column + " FROM " + table;
                    break;
                case "SD":
                    text += "SELECT DISTINCT " + column + " FROM " + table;
                    break;
            }
            text = WhereCheck(text, whereStatement);
            return text;
        }
        private string UpdateCommand(string table, string column, string inputData, string whereStatement)
        {
            string text = "";
            text = "UPDATE " + table + " SET " + column + " = " + "'" + inputData + "'";
            text = WhereCheck(text, whereStatement);
            return text;
        }
        private string InsertCommand(string table, string[] columns, string[] inputDatas)
        {
            string command = "INSERT INTO " + table + " (";
            for (int i = 0; i < columns.Length; i++)
            {
                if (i == columns.Length - 1)
                {
                    command += columns[i];
                }
                else
                {
                    command += columns[i] + ", ";
                }
            }
            command += ") VALUES (";
            for (int i = 0; i < inputDatas.Length; i++)
            {
                if (i != inputDatas.Length - 1)
                {
                    command += "'" + inputDatas[i] + "', ";
                }
                else
                {
                    command += "'" + inputDatas[i] + "'";
                }
            }
            command += ")";
            return command;
        }
        private string DeleteCommand(string table, string whereStatement)
        {
            string text = "DELETE FROM " + table;
            text = WhereCheck(text, whereStatement);
            return text;
        }
        public string[] Select(string type, string table, string column, string whereStatement)
        {
            string data = "";
            string[] datas;
            command.CommandText = SelectCommand(type, table, column, whereStatement);
            OpenConnection();
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                data += dataReader[column].ToString() + ",";
            }
            datas = data.Split(',');
            CloseConnection();
            datas = Global.RemoveArrayWIndex(datas, datas.Length - 1);
            return datas;
        }
        public string[] Select(string type, string table, string[] column, string whereStatement)
        {
            string data = "";
            string[] datas;
            string myString = "";

            for (int i = 0; i < column.Length; i++)
            {
                myString += column[i];
                if (i != column.Length - 1)
                {
                    myString += ", ";
                }       
            }
            command.CommandText = SelectCommand(type, table, myString, whereStatement);
            OpenConnection();
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                for (int i = 0; i < column.Length; i++)
                {
                    data += dataReader[column[i]].ToString() + ",";
                }
            }
            datas = data.Split(',');
            CloseConnection();
            datas = Global.RemoveArrayWIndex(datas, datas.Length - 1);
            return datas;
        }
        public string SelectSingle(string type, string table, string column, string whereStatement)
        {
            string data = "";
            string[] datas;
            command.CommandText = SelectCommand(type, table, column, whereStatement);
            OpenConnection();
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                data += dataReader[column].ToString() + ",";
            }
            datas = data.Split(',');
            CloseConnection();
            return datas[0];
        }
        public void Update(string table, string columns, string inputDatas, string whereStatement)
        {
            command.CommandText = UpdateCommand(table, columns, inputDatas, whereStatement);
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public void Insert(string table, string[] columns, string[] inputDatas)
        {
            command.CommandText = InsertCommand(table, columns, inputDatas);
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public void Delete(string table, string whereStatement)
        {
            command.CommandText = DeleteCommand(table, whereStatement);

            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
    public class InformationSchema : DatabaseConnectors
    {
        public InformationSchema() : base("information_schema") { }
        public string[] GetTable()
        {
            string[] tables = new string[5];
            tables = Select("SD", "COLUMNS", "TABLE_NAME", "TABLE_SCHEMA = 'green_ict_application'");
            return tables;
        }
        public string[] GetColumn(string table)
        {
            string[] columns;
            columns = Select("S", "COLUMNS", "COLUMN_NAME", "TABLE_NAME = '" + table + "'");
            columns = Global.RemoveArrayWIndex(columns, 0);
            return columns;
        }
    }
}

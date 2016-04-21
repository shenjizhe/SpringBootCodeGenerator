using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System;
using SpringBootCodeFactory.code.area;
using SpringBootCodeFactory.code.entity;

namespace SpringBootCodeFactory.code.util
{
    public class MySqlHelper
    {
        MySqlConnection mycon = null;
        public MySqlHelper(string url, string dbname, string user,string port, string password)
        {
            string constr = "server=" + url + ";User Id=" + user + ";password=" + password + ";Database=" + dbname + ";port=" +port ;
            mycon = new MySqlConnection(constr);

        }
        public MySqlHelper(DataSource source)
            : this(source.DBUrl, source.DBName, source.UserName,source.Port, source.Pass)
        {
        }

        public void excute(string sql)
        {
            mycon.Open();
            MySqlCommand mycmd = new MySqlCommand(sql, mycon);
            if (mycmd.ExecuteNonQuery() > 0)
            {

            }
            mycon.Close();
        }

        public string SearchTableInfo(string tableName)
        {
            try
            {
                string sql1 = "use information_schema";
                string sql2 = "select table_comment from TABLES where TABLE_NAME='" + tableName + "'";

                mycon.Open();
                MySqlCommand mycmd = new MySqlCommand(sql1, mycon);
                mycmd.ExecuteNonQuery();
                mycmd = new MySqlCommand(sql2, mycon);
                MySqlDataReader reader = mycmd.ExecuteReader();
                while (reader.Read())
                {
                    string text = reader.GetString(0);
                    return text;
                }
            }
            catch (Exception ex)
            {
                object obj = ex;
            }
            finally
            {
                mycon.Close();
            }
            return null;
        }

        public List<region> select()
        {
            string sql = "select * from region_code";
            List<region> columns = new List<region>();
            try
            {
                mycon.Open();
                MySqlCommand mycmd = new MySqlCommand(sql, mycon);
                MySqlDataReader reader = mycmd.ExecuteReader();

                List<List<string>> itemList = new List<List<string>>();
                int count = 0;
                while (reader.Read())
                {


                    count++;
                    try
                    {
                        string code = reader.GetString("code");
                        string name = reader.GetString("name");
                        region reg = new region(code, name);
                        columns.Add(reg);
                    }
                    catch (System.Exception)
                    {
                        columns.Add(null);

                    }

                }
                return columns;
            }
            finally
            {
                mycon.Close();
            }
        }

        public List<List<string>> select(string sql)
        {
            try
            {
                mycon.Open();
                MySqlCommand mycmd = new MySqlCommand(sql, mycon);
                MySqlDataReader reader = mycmd.ExecuteReader();

                List<List<string>> itemList = new List<List<string>>();
                while (reader.Read())
                {
                    List<string> columns = new List<string>();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        try
                        {
                            columns.Add(reader.GetString(i));
                        }
                        catch (System.Exception)
                        {
                            columns.Add(null);

                        }
                    }
                    itemList.Add(columns);

                }
                return itemList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                mycon.Close();
            }
        }
    }
}

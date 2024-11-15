﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team
{
    internal class Program
    {
        public static connect conn = new connect();
        public static void GetAllData()
        {
            conn.Connection.Open();

            string sql = "SELECT * FROM `player`";

            MySqlCommand cmd = new MySqlCommand(sql, conn.Connection);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                var player = new
                {
                    Id = dr.GetInt32(0),
                    Name = dr.GetString(1),
                    Height = dr.GetInt32(2),
                    Weight = dr.GetInt32(3),
                    CreatedTime = dr.GetDateTime(4),
                };


                

                Console.WriteLine($"Játékos adatok: {player.Name}, {player.CreatedTime}");
            }
            dr.Close();
            conn.Connection.Close();
            
            }
            public static void Main(string[] args)
        {
            GetAllData();
        }
    }
}
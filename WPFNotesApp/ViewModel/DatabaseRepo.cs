﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WPFNotesApp.ViewModel
{
    class DatabaseRepo
    {
        private static string dbFile = Path.Combine(Environment.CurrentDirectory, "WPFnotesDb.db3");

        public static bool Insert<T>(T item)
        {
            bool result = false;

            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int numOfRows = conn.Insert(item);
                if (numOfRows > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool Update<T>(T item)
        {
            bool result = false;

            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int numOfRows = conn.Update(item);
                if (numOfRows > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool Delete<T>(T item)
        {
            bool result = false;

            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                conn.CreateTable<T>();
                int numOfRows = conn.Delete(item);
                if (numOfRows > 0)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}

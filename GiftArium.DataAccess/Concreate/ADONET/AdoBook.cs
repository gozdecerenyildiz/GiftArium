using GiftArium.DataAccess.Abstarct;
using GiftArium.Entity.POCO;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace GiftArium.DataAccess.Concreate.ADONET
{
    internal class AdoBook : IBookDAL
    {
        private readonly SqlConnection sql;
        private readonly SqlCommand command;
        public bool Add(Book entity)
        {
            using (sql)
            {
                using (command)
                {
                    sql.ConnectionString = "Server=.\\MSSQLSERVER;Database=GiftAriumDB;Trusted_Connection=True;";
                    command.Connection = sql;
                    sql.Open();
                    command.CommandText = $"insert into Books({nameof(Book.Active)},{nameof(Book.Deleted)},{nameof(Book.CreatedTime)},{nameof(Book.UpdatedTime)},{nameof(Book.PageCount)},{nameof(Book.Price)},{nameof(Book.PublishDate)},{nameof(Book.Description)},{nameof(Book.Title)},{nameof(Book.Tags)})values ({entity.Active},{entity.Deleted},{entity.CreatedTime},{entity.UpdatedTime},{entity.CreatedTime},{entity.PageCount},{entity.Price},{entity.PublishDate},{entity.Description},{entity.Title},{entity.Tags})";
                    int sonuc = command.ExecuteNonQuery();
                    sql.Close();
                    if (sonuc > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            
        }

        public bool Delete(Book entity)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> Get()
        {
            throw new NotImplementedException();
        }

        public bool Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}

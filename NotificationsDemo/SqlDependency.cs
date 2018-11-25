using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotificationsDemo.Data;
using TableDependency.SqlClient;

namespace NotificationsDemo
{
    public static  class SqlDependency
    {

       public  static SqlTableDependency<Item> dependency = new SqlTableDependency<Item>(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, "Items");




       

    }
}

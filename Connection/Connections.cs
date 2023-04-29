using LinqToDB;
using LinqToDB.Data;
using LinqToDB.DataProvider;
using LinqToDB.DataProvider.MySql;
using LinqToDB.DataProvider.SqlServer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Connection
{
    public class Connections : DataConnection
    {

        /*public Connections() : base(new LinqToDB.DataProvider.MySql.MySqlDataProvider(),
        "Server=localhost;Port=3306;Database=sales_system;Uid=root;Pwd='';charset=utf8;SslMode=none")
        {

        }*/

        /*public Connections() : base(new MySqlDataProvider(),
        "Server=localhost;Port=3306;Database=sales_system;Uid=root;Pwd=H@neywell123;charset=utf8;SslMode=none")
        {

        }*/


        /*public Connections() : base (new SqlServerDataProvider("", SqlServerVersion.v2012), "Data Source=JESUSRENDON\\SQLEXPRESS;Database=sales_system;Integrated Security=True;")
         { }*/

        /*public Connections() : base(new SqlServerDataProvider("", SqlServerVersion.v2012), "Server=JESUSRENDON\\SQLEXPRESS;Database=sales_system;Integrated Security=True;")
        { }*/

        public Connections() : base(new SqlServerDataProvider("", SqlServerVersion.v2012), "Server=JESUSRENDON\\SQLEXPRESS;Database=sales_system;Trusted_Connection=true;MultipleActiveResultSets=true;")
        { }

        public ITable<tuser> Users => GetTable<tuser>();
        
    }
}

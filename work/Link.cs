using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace work
{
    internal class Link
    {
        SqlConnection sc;
        public SqlConnection connect()//连接
        {
            string str = @"Data Source=YUE;Initial Catalog =Supermarket;User ID = sa;Password=L129218219;";//Integrated Security=True"
            sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }
        public SqlCommand command(string sql)//指令
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }
        public SqlDataReader read(string sql)//读取
        {
            return command(sql).ExecuteReader();
        }
        public int Excute(string sql)//更新
        {
            return command(sql).ExecuteNonQuery();
        }
        public void Close()
        {
            sc.Close();
        }
    }
}

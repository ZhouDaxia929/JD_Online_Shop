using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JD_Online_Shop_Dal {
    class DBHelper {
        DbProviderFactory factor;
        string connString;
        DbConnection conn;
        DbCommand cmd;
        DbDataAdapter adapter;
        public string ProviderName { get; set; }
        public DBHelper(string provider) {
            factor = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings[provider].ProviderName);
            connString = ConfigurationManager.ConnectionStrings[provider].ToString();
            ProviderName = ConfigurationManager.ConnectionStrings[provider].ProviderName;
            conn = factor.CreateConnection();
            conn.ConnectionString = connString;
            cmd = factor.CreateCommand();
            cmd.Connection = conn;
            adapter = factor.CreateDataAdapter();
        }

        //连接数据库
        public bool Connection () {
            try {
                conn.Open();
                return true;
            }
            catch {
                return false;
            }
        }

        //断开连接
        public void DisConnection () {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        //数据更新操作，返回影响记录数量
        public long Update(string sSql) {
            long nRow = 0;
            if(conn.State != ConnectionState.Open)
                if (!this.Connection()) {
                    nRow = -1;
                    return nRow;
                }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sSql;
            try {
                nRow = cmd.ExecuteNonQuery();
            }
            catch {
                nRow = 0;
            }
            return nRow;
        }


        //数据检索
        public DbDataReader DataRead(string sSql) {
            DbDataReader reader = null;
            if(conn.State != ConnectionState.Open)
                if (!this.Connection()) {
                    reader = null;
                    return reader;
                }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sSql;
            try {
                reader = cmd.ExecuteReader();
            }
            catch {
                reader = null;
            }
            return reader;
        }

        //执行查询，返回一个DataTable
        public DataTable FillTable(string sSql) {
            DataTable table = new DataTable();
            if(conn.State != ConnectionState.Open)
                if (!this.Connection()) {
                    table = null;
                    return table;
                }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sSql;
            adapter.SelectCommand = cmd;
            try {
                adapter.Fill(table);
            }
            catch {
                table = null;
            }
            return table;
        }

        //执行查询，返回一个DataSet
        public DataSet FillSet(string sSql, string table) {
            DataSet dataSet = new DataSet();
            if (conn.State != ConnectionState.Open)
                if (!this.Connection()) {
                    dataSet = null;
                    return dataSet;
                }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sSql;
            adapter.SelectCommand = cmd;
            try {
                adapter.Fill(dataSet, table);
            }
            catch {
                dataSet = null;
            }
            return dataSet;
        }

        //注册操作
        public long Insert(string email, string name, string pwd, string phone, Byte[] pic) {
            long nRow = 0;
            if (conn.State != ConnectionState.Open)
                if (!this.Connection()) {
                    nRow = -1;
                    return nRow;
                }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Customer(Email, Name, Pwd, Phone, Pic) values (" + "'" + email + "',"
                + "'" + name + "'," + "'" + pwd + "'," + "'null'," + "@img)";
            SqlParameter prm = new SqlParameter("@img", SqlDbType.Image, pic.Length);
            prm.Value = pic;
            cmd.Parameters.Add(prm);
            try {
                nRow = cmd.ExecuteNonQuery();
            }
            catch {
                nRow = 0;
            }
            return nRow;
        }

        //商城商品初始化
        public long GoodsInitialize(string goodId, string goodName, int goodNum, string goodPrice, string goodUrl, string goodPicUrl, Byte[] goodPic, string goodDetils) {
            long nRow = 0;
            if (conn.State != ConnectionState.Open)
                if (!this.Connection()) {
                    nRow = -1;
                    return nRow;
                }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Good(goodId, goodName, goodNum, goodPrice, goodUrl, goodPicUrl, goodPic, goodDetils) values ("
                + "'" + goodId + "',"
                + "'" + goodName + "',"
                + "'" + goodNum + "',"
                + "'" + goodPrice + "',"
                + "'" + goodUrl + "',"
                + "'" + goodPicUrl + "',@img,"
                + "'" + goodDetils + "')";
            SqlParameter prm = new SqlParameter("@img", SqlDbType.Image, goodPic.Length);
            prm.Value = goodPic;
            cmd.Parameters.Add(prm);
            try {
                nRow = cmd.ExecuteNonQuery();
            }
            catch {
                nRow = 0;
            }
            return nRow;
        }

        public long AllUpdate(string sSql, Byte[] pic) {
            long nRow = 0;
            if (conn.State != ConnectionState.Open)
                if (!this.Connection()) {
                    nRow = -1;
                    return nRow;
                }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sSql;
            SqlParameter prm = new SqlParameter("@img", SqlDbType.Image, pic.Length);
            prm.Value = pic;
            cmd.Parameters.Add(prm);
            try {
                nRow = cmd.ExecuteNonQuery();
            }
            catch {
                nRow = 0;
            }
            return nRow;
        }

        //执行存贮过程,proc为存贮过程名，pParam为参数列表,该列表可以带回一些输出参数的值,返回值为存贮过程返回值
        public int ExexcuteProcedure(string proc, ref List<DbParameter> pams) {
            int result = -1; //返回值
            if(conn.State != ConnectionState.Open)
                if (!this.Connection()) {
                    result = -1;
                    return result;
                }
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = proc;
            for (int i = 0; i < pams.Count; i++)
                cmd.Parameters.Add(pams[i]);
            try {
                result = cmd.ExecuteNonQuery();
                result = (int)cmd.Parameters["@return"].Value;
            }
            catch {
                result = -1;
            }
            return result;
        }
    }
}

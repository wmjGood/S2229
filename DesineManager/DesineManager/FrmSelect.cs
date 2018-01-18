using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesineManager
{
    public partial class FrmSelect : Form
    {
        public FrmSelect()
        {
            InitializeComponent();
        }

        private void FrmSelect_Load(object sender, EventArgs e)
        {
            //窗体加载时DataGradView显示所有数据，调用SelectRoom()方法
            SelectRoom();
        }

        Helper help = new Helper();
        DataSet ds = new DataSet();
        SqlDataAdapter adapter;
        //查询数据库中信息，填充到DataGradView中
        public void SelectRoom() {
            //查询所有信息
            string sql = "select * from DesineRecord";
            //创建SqlDataAdapter适配器，连接sql语句和数据库
            adapter = new SqlDataAdapter(sql,help.Con);
            //判断DataSet表中是否有数据，如果有数据就先清空
            if(ds.Tables["Desine"]!=null){
                ds.Tables["Desine"].Clear();
            }
            //填充DataSet
            adapter.Fill(ds,"Desine");
            //绑定数据源
            dgvDesineRoom.DataSource=ds.Tables["Desine"];
        }
    }
}

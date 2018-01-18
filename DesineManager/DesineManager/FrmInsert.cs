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
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }

       //确定按钮
        private void btnSave_Click(object sender, EventArgs e)
        {
            //判断如果文本框某一个为空，就提示
            if (isnull())
            {
                //调用InsertRoom()方法向数据库中添加数据
                InsertRoom();
            }
            else {
                MessageBox.Show("所有文本框不能为空，请确认填写", "提示");
            }
        }

        Helper help = new Helper();

        //向数据库增加数据
        public void InsertRoom() {
            string time = txtTime.Text;
            string room = txtRoom.Text;
            string reason = txtReason.Text;
            string name = txtName.Text;
            string note = txtNote.Text;
            try
            {
                //查询的SQL语句
                string sql = string.Format("insert dbo.DesineRecord(DestineDate,DestineMan,DesineReason,BoardroomName,NoteMan)values('{0}','{1}','{2}','{3}','{4}')", time, name, reason, room, note);
                //用SqlCommand连接SQL语句和数据库
                SqlCommand comm = new SqlCommand(sql, help.Con);
               //打开数据库连接
                help.Open();
                //用int类型变量接收SqlCommand对象ExecuteNonQuery()方法返回的值
                int count = comm.ExecuteNonQuery();
                //判断如果返回的行数>0,就提示提交成功，否则，提交失败
                if (count > 0)
                {
                    MessageBox.Show("提交成功");
                }
                else {

                    MessageBox.Show("提交失败");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        //非空验证
        public bool isnull() {
            //判断文本框中是否有数据
            bool isOk = true;
            if (txtTime.Text.Trim() == null || txtTime.Text.Trim() == "") {
                isOk = false;
            } 
            if (txtRoom.Text.Trim() == null || txtRoom.Text.Trim() == "") {
                isOk = false;
            }
            if (txtReason.Text.Trim() == null || txtReason.Text.Trim() == "")
            {
                isOk = false;
            }
            if (txtNote.Text.Trim() == null || txtNote.Text.Trim() == "")
            {
                isOk = false;
            } 
            if (txtName.Text.Trim() == null || txtName.Text.Trim() == "")
            {
                isOk = false;
            }
            return isOk;
        }

        //点击清空按钮就会清空文本框中的数据
        private void btnClear_Click(object sender, EventArgs e)
        {
            //foreach循坏遍历清空文本框中的数据
            foreach(Control control in this.Controls){
                //判断如果文本框中有数据，点击清空按钮就会清空文本框中的数据
              if(control is TextBox){

                  txtTime.Clear();
                  txtRoom.Clear();
                  txtReason.Clear();
                  txtNote.Clear();
                  txtName.Clear();
              }
            }
        }

        //点击取消按钮，窗体就会关闭
        private void btnRenal_Click(object sender, EventArgs e)
        {
            this.Close();//关闭FrmInsert窗体
        }

       
    }
}

/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cbchoice
{
    public partial class Form1 : Form
    {
        // 초기 콤보박스 데이터 설정
        string[] SList = new string[]{"김밥", "샐러드김밥", "야채김밥",
            "소고기김밥" ,"계란김밥", "라볶이"};
        string orgStr = ""; // 선택 결과 저장

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e) {
            for (int i=0; i < this.SList.Length; i++){
                this.cblist.Items.Add(this.SList[i]);
            }
            this.orgStr = this.lblResult.Text;
            if (this.cblist.Items.Count > 0) { 
            this.cblist.SelectedIndex = 0;
            }
        }

        private void Cblist_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.orgStr + this.cblist.Text;
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            if (this.txtlist.Text == "")
            {
                MessageBox.Show("추가 할 항목을 선택하세요", "알림"
               , MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.txtlist.Focus();
            }
            else {
                this.cblist.Items.Add(this.txtlist.Text);
                this.txtlist.Focus();
            }
        }
       
    }
}
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {
        String[] SList = new string[]
        {
            "짜장면", "짬뽕", "탕수육", "라조기"
        };
        String OrgStr = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < this.SList.Length; i++)
            {
                this.cbList.Items.Add(this.SList[i]);
            }
            this.OrgStr = this.lblResult.Text;
            if (this.cbList.Items.Count > 0)
            {
                this.cbList.SelectedIndex = 0;
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.cbList.Text;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CheckInput();
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CheckInput();
            }
        }
        private void CheckInput()
        {
            if (this.txtList.Text == "")
            {
                MessageBox.Show("추가할 항목을 선택하세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();
            }
            else
            {
                this.cbList.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
                this.txtList.Focus();
            }
        }
    }
}
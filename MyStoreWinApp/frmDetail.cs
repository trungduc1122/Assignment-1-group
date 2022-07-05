using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmDetail : Form
    {
        public frmDetail()
        {
            InitializeComponent();
        }

        public IMemberRepository memberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject info;
        private void button3_Click(object sender, EventArgs e) => Close();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = txtID.Text,
                    MemberName=txtName.Text,
                    Email=txtEmail.Text,
                    City=txtCity.Text,
                    Country=txtCountry.Text
                };
                if (InsertOrUpdate == false)
                {
                    memberRepository.updateMember(member);
                }
                else
                {
                    memberRepository.addMember(member);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "add" : "update");
            }
        }

        private void frmDetail_Load(object sender, EventArgs e)
        {
            txtID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtID.Text = info.MemberID.ToString();
                txtName.Text = info.MemberName.ToString();
                txtEmail.Text = info.Email.ToString();
                txtPassword.Text = info.Password.ToString();
                txtCity.Text = info.City.ToString();
                txtCountry.Text=info.Country.ToString();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reserve
{
    public partial class reserve_send : Form
    {
        public string ReservedMessage { get; set; }
        public TimeSpan ReservedTime { get; set; }

        public reserve_send()
        {
            InitializeComponent();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(sendText.Text))
            {
                ReservedMessage = sendText.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("메시지를 입력하고 시간을 선택해주세요");
            }
        }

        private void reserve_introduce_Click(object sender, EventArgs e)
        {

        }



        private void sendText_TextChanged(object sender, EventArgs e)
        {

        }

        private void reserve_send_Load(object sender, EventArgs e)
        {

        }
    }
}

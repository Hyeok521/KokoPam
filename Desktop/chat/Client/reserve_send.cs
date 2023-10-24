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

            //
            this.reserve.Items.AddRange(new string[] { "10초 후", "30초 후", "1분 후" }); // 예약 시간 선택 항목 추가
            //
        }

        private void reserve_introduce_Click(object sender, EventArgs e)
        {

        }



        private void sendText_TextChanged(object sender, EventArgs e)
        {
            //
            this.ReservedMessage = this.sendText.Text;
            //
        }

        private void reserve_send_Load(object sender, EventArgs e)
        {

        }

        private void reserve_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.reserve.SelectedItem.ToString())
            {
                case "10초 후":
                    this.ReservedTime = TimeSpan.FromSeconds(10);
                    break;
                case "30초 후":
                    this.ReservedTime = TimeSpan.FromSeconds(30);
                    break;
                case "1분 후":
                    this.ReservedTime = TimeSpan.FromMinutes(1);
                    break;
            }
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            // 모든 입력이 올바른지 확인하고, 그렇다면 'DialogResult.OK'를 설정하여 폼을 닫습니다.
            if (!string.IsNullOrWhiteSpace(this.ReservedMessage) && this.ReservedTime != default(TimeSpan))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("메시지 및 예약 시간을 입력해주세요.");
            }
            //
        }

        private void means_Click(object sender, EventArgs e)
        {

        }
    }
}

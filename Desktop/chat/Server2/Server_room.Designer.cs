namespace Server2
{
    partial class Server_room
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server_room));
            textBox1 = new TextBox();
            btnServerOn = new Button();
            btnServerOff = new Button();
            listBoxClient = new ListBox();
            btnDisconnectClient = new Button();
            label1 = new Label();
            label2 = new Label();
            PortNumTxtbox = new TextBox();
            btnXml = new Button();
            IPAddressTxtbox = new MaskedTextBox();
            room_send = new Button();
            room_message = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(31, 99);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(427, 270);
            textBox1.TabIndex = 0;
            // 
            // btnServerOn
            // 
            btnServerOn.BackColor = Color.Transparent;
            btnServerOn.FlatStyle = FlatStyle.Popup;
            btnServerOn.Location = new Point(476, 26);
            btnServerOn.Margin = new Padding(3, 4, 3, 4);
            btnServerOn.Name = "btnServerOn";
            btnServerOn.Size = new Size(97, 29);
            btnServerOn.TabIndex = 1;
            btnServerOn.Text = "Server ON";
            btnServerOn.UseVisualStyleBackColor = false;
            btnServerOn.Click += btnServerOn_Click;
            // 
            // btnServerOff
            // 
            btnServerOff.BackColor = Color.Transparent;
            btnServerOff.FlatStyle = FlatStyle.Popup;
            btnServerOff.Location = new Point(579, 26);
            btnServerOff.Margin = new Padding(3, 4, 3, 4);
            btnServerOff.Name = "btnServerOff";
            btnServerOff.Size = new Size(97, 29);
            btnServerOff.TabIndex = 2;
            btnServerOff.Text = "Server OFF";
            btnServerOff.UseVisualStyleBackColor = false;
            btnServerOff.Click += btnServerOff_Click;
            // 
            // listBoxClient
            // 
            listBoxClient.BorderStyle = BorderStyle.None;
            listBoxClient.FormattingEnabled = true;
            listBoxClient.ItemHeight = 15;
            listBoxClient.Location = new Point(476, 99);
            listBoxClient.Margin = new Padding(3, 4, 3, 4);
            listBoxClient.Name = "listBoxClient";
            listBoxClient.SelectionMode = SelectionMode.MultiExtended;
            listBoxClient.Size = new Size(200, 270);
            listBoxClient.TabIndex = 4;
            // 
            // btnDisconnectClient
            // 
            btnDisconnectClient.BackColor = Color.Transparent;
            btnDisconnectClient.FlatStyle = FlatStyle.Popup;
            btnDisconnectClient.Location = new Point(476, 399);
            btnDisconnectClient.Margin = new Padding(3, 4, 3, 4);
            btnDisconnectClient.Name = "btnDisconnectClient";
            btnDisconnectClient.Size = new Size(200, 29);
            btnDisconnectClient.TabIndex = 5;
            btnDisconnectClient.Text = "클라이언트 연결해제";
            btnDisconnectClient.UseVisualStyleBackColor = false;
            btnDisconnectClient.Click += btnDisconnectClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 6;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(245, 32);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "비밀번호";
            // 
            // PortNumTxtbox
            // 
            PortNumTxtbox.BorderStyle = BorderStyle.None;
            PortNumTxtbox.Location = new Point(308, 26);
            PortNumTxtbox.Margin = new Padding(3, 4, 3, 4);
            PortNumTxtbox.Name = "PortNumTxtbox";
            PortNumTxtbox.Size = new Size(150, 16);
            PortNumTxtbox.TabIndex = 9;
            PortNumTxtbox.KeyPress += PortNumTxtbox_KeyPress;
            // 
            // btnXml
            // 
            btnXml.BackColor = Color.Transparent;
            btnXml.FlatStyle = FlatStyle.Popup;
            btnXml.Location = new Point(476, 62);
            btnXml.Margin = new Padding(3, 4, 3, 4);
            btnXml.Name = "btnXml";
            btnXml.Size = new Size(200, 29);
            btnXml.TabIndex = 10;
            btnXml.Text = "make XML";
            btnXml.UseVisualStyleBackColor = false;
            btnXml.Click += btnXml_Click;
            // 
            // IPAddressTxtbox
            // 
            IPAddressTxtbox.BackColor = SystemColors.Window;
            IPAddressTxtbox.BorderStyle = BorderStyle.None;
            IPAddressTxtbox.Location = new Point(67, 26);
            IPAddressTxtbox.Margin = new Padding(3, 4, 3, 4);
            IPAddressTxtbox.Name = "IPAddressTxtbox";
            IPAddressTxtbox.ReadOnly = true;
            IPAddressTxtbox.Size = new Size(152, 16);
            IPAddressTxtbox.TabIndex = 11;
            // 
            // room_send
            // 
            room_send.BackColor = Color.Transparent;
            room_send.FlatStyle = FlatStyle.Popup;
            room_send.Location = new Point(369, 399);
            room_send.Name = "room_send";
            room_send.Size = new Size(75, 29);
            room_send.TabIndex = 12;
            room_send.Text = "보내기";
            room_send.UseVisualStyleBackColor = false;
            room_send.Click += room_send_Click;
            // 
            // room_message
            // 
            room_message.Location = new Point(31, 399);
            room_message.Name = "room_message";
            room_message.Size = new Size(317, 23);
            room_message.TabIndex = 13;
            room_message.TextChanged += textBox2_TextChanged_1;
            // 
            // Server_room
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 450);
            Controls.Add(room_message);
            Controls.Add(room_send);
            Controls.Add(IPAddressTxtbox);
            Controls.Add(btnXml);
            Controls.Add(PortNumTxtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDisconnectClient);
            Controls.Add(listBoxClient);
            Controls.Add(btnServerOff);
            Controls.Add(btnServerOn);
            Controls.Add(textBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Server_room";
            Text = "코코팜톡_서버";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnServerOn;
        private Button btnServerOff;
        private ListBox listBoxClient;
        private Button btnDisconnectClient;
        private Label label1;
        private Label label2;
        private TextBox PortNumTxtbox;
        private Button btnXml;
        private MaskedTextBox IPAddressTxtbox;
        private Button room_send;
        private TextBox room_message;
    }
}


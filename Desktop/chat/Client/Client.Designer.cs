namespace Client
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            btnSendText = new Button();
            textBox1 = new TextBox();
            textBoxMessage = new TextBox();
            textBoxNickName = new TextBox();
            btnConnect = new Button();
            label1 = new Label();
            btnDisconnect = new Button();
            label3 = new Label();
            PortNumTxtbox = new TextBox();
            btnXml = new Button();
            label2 = new Label();
            MIPAddressTxtbox = new MaskedTextBox();
            emoticon = new Button();
            reserve = new Button();
            SuspendLayout();
            // 
            // btnSendText
            // 
            btnSendText.BackColor = Color.Transparent;
            btnSendText.FlatStyle = FlatStyle.Popup;
            btnSendText.Location = new Point(314, 389);
            btnSendText.Margin = new Padding(3, 2, 3, 2);
            btnSendText.Name = "btnSendText";
            btnSendText.Size = new Size(103, 28);
            btnSendText.TabIndex = 0;
            btnSendText.Text = "보내기";
            btnSendText.UseVisualStyleBackColor = false;
            btnSendText.Click += btnSendText_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(35, 176);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(267, 191);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBoxMessage
            // 
            textBoxMessage.BackColor = SystemColors.Window;
            textBoxMessage.BorderStyle = BorderStyle.FixedSingle;
            textBoxMessage.Location = new Point(35, 389);
            textBoxMessage.Margin = new Padding(3, 2, 3, 2);
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(267, 23);
            textBoxMessage.TabIndex = 2;
            textBoxMessage.TextChanged += textBoxMessage_TextChanged;
            textBoxMessage.KeyPress += textBoxMessage_KeyUp;
            // 
            // textBoxNickName
            // 
            textBoxNickName.BackColor = SystemColors.Window;
            textBoxNickName.BorderStyle = BorderStyle.None;
            textBoxNickName.Location = new Point(84, 91);
            textBoxNickName.Margin = new Padding(3, 2, 3, 2);
            textBoxNickName.Name = "textBoxNickName";
            textBoxNickName.Size = new Size(149, 16);
            textBoxNickName.TabIndex = 3;
            textBoxNickName.TextChanged += textBoxNickName_TextChanged;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.Transparent;
            btnConnect.FlatStyle = FlatStyle.Popup;
            btnConnect.Location = new Point(314, 91);
            btnConnect.Margin = new Padding(3, 2, 3, 2);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(149, 28);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "서버 연결";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(37, 98);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "name";
            label1.Click += label1_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.BackColor = Color.Transparent;
            btnDisconnect.FlatStyle = FlatStyle.Popup;
            btnDisconnect.Location = new Point(314, 116);
            btnDisconnect.Margin = new Padding(3, 2, 3, 2);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(149, 28);
            btnDisconnect.TabIndex = 6;
            btnDisconnect.Text = "연결 해제";
            btnDisconnect.UseVisualStyleBackColor = false;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(247, 41);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 9;
            label3.Text = "비밀번호";
            // 
            // PortNumTxtbox
            // 
            PortNumTxtbox.BackColor = SystemColors.Window;
            PortNumTxtbox.BorderStyle = BorderStyle.None;
            PortNumTxtbox.Location = new Point(314, 38);
            PortNumTxtbox.Margin = new Padding(3, 4, 3, 4);
            PortNumTxtbox.Name = "PortNumTxtbox";
            PortNumTxtbox.Size = new Size(149, 16);
            PortNumTxtbox.TabIndex = 10;
            PortNumTxtbox.KeyPress += PortNumTxtbox_KeyPress;
            // 
            // btnXml
            // 
            btnXml.BackColor = Color.Transparent;
            btnXml.FlatStyle = FlatStyle.Popup;
            btnXml.Location = new Point(314, 142);
            btnXml.Margin = new Padding(3, 4, 3, 4);
            btnXml.Name = "btnXml";
            btnXml.Size = new Size(149, 28);
            btnXml.TabIndex = 11;
            btnXml.Text = "read XML";
            btnXml.UseVisualStyleBackColor = false;
            btnXml.Click += btnXml_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(37, 41);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 7;
            label2.Text = "IP";
            // 
            // MIPAddressTxtbox
            // 
            MIPAddressTxtbox.BackColor = SystemColors.Window;
            MIPAddressTxtbox.BorderStyle = BorderStyle.None;
            MIPAddressTxtbox.Location = new Point(84, 39);
            MIPAddressTxtbox.Margin = new Padding(3, 4, 3, 4);
            MIPAddressTxtbox.Name = "MIPAddressTxtbox";
            MIPAddressTxtbox.Size = new Size(149, 16);
            MIPAddressTxtbox.TabIndex = 12;
            MIPAddressTxtbox.MaskInputRejected += MIPAddressTxtbox_MaskInputRejected;
            // 
            // emoticon
            // 
            emoticon.BackColor = Color.Transparent;
            emoticon.FlatStyle = FlatStyle.Popup;
            emoticon.Location = new Point(423, 389);
            emoticon.Margin = new Padding(3, 2, 3, 2);
            emoticon.Name = "emoticon";
            emoticon.Size = new Size(40, 28);
            emoticon.TabIndex = 13;
            emoticon.Text = "^_^";
            emoticon.UseVisualStyleBackColor = false;
            emoticon.Click += emoticon_Click;
            // 
            // reserve
            // 
            reserve.BackColor = Color.Transparent;
            reserve.FlatStyle = FlatStyle.Popup;
            reserve.Location = new Point(314, 339);
            reserve.Margin = new Padding(3, 2, 3, 2);
            reserve.Name = "reserve";
            reserve.Size = new Size(149, 28);
            reserve.TabIndex = 14;
            reserve.Text = "예약 메세지";
            reserve.UseVisualStyleBackColor = false;
            reserve.Click += reserve_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(501, 441);
            Controls.Add(reserve);
            Controls.Add(emoticon);
            Controls.Add(MIPAddressTxtbox);
            Controls.Add(btnXml);
            Controls.Add(PortNumTxtbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDisconnect);
            Controls.Add(label1);
            Controls.Add(btnConnect);
            Controls.Add(textBoxNickName);
            Controls.Add(textBoxMessage);
            Controls.Add(textBox1);
            Controls.Add(btnSendText);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Client";
            Text = "코코팜톡";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSendText;
        private TextBox textBox1;
        private TextBox textBoxMessage;
        private TextBox textBoxNickName;
        private Button btnConnect;
        private Label label1;
        private Button btnDisconnect;
        private Label label3;
        private TextBox PortNumTxtbox;
        private Button btnXml;
        private Label label2;
        private MaskedTextBox MIPAddressTxtbox;
        private Button emoticon;
        private Button reserve;
    }
}


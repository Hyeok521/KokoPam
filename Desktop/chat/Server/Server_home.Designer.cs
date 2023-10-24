namespace Server
{
    partial class Server_home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server_home));
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
            button1 = new Button();
            Box1 = new TextBox();
            Box2 = new TextBox();
            Box3 = new TextBox();
            Box4 = new TextBox();
            button2 = new Button();
            server_message = new TextBox();
            server_send = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(231, 179);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(227, 216);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnServerOn
            // 
            btnServerOn.BackColor = Color.Transparent;
            btnServerOn.FlatStyle = FlatStyle.Popup;
            btnServerOn.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnServerOn.Location = new Point(476, 26);
            btnServerOn.Margin = new Padding(3, 4, 3, 4);
            btnServerOn.Name = "btnServerOn";
            btnServerOn.Size = new Size(97, 36);
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
            btnServerOff.Size = new Size(97, 36);
            btnServerOff.TabIndex = 2;
            btnServerOff.Text = "Server OFF";
            btnServerOff.UseVisualStyleBackColor = false;
            btnServerOff.Click += btnServerOff_Click;
            // 
            // listBoxClient
            // 
            listBoxClient.BorderStyle = BorderStyle.FixedSingle;
            listBoxClient.FormattingEnabled = true;
            listBoxClient.ItemHeight = 15;
            listBoxClient.Location = new Point(476, 179);
            listBoxClient.Margin = new Padding(3, 4, 3, 4);
            listBoxClient.Name = "listBoxClient";
            listBoxClient.SelectionMode = SelectionMode.MultiExtended;
            listBoxClient.Size = new Size(200, 212);
            listBoxClient.TabIndex = 4;
            listBoxClient.SelectedIndexChanged += listBoxClient_SelectedIndexChanged;
            // 
            // btnDisconnectClient
            // 
            btnDisconnectClient.BackColor = Color.Transparent;
            btnDisconnectClient.FlatStyle = FlatStyle.Popup;
            btnDisconnectClient.Location = new Point(476, 118);
            btnDisconnectClient.Margin = new Padding(3, 4, 3, 4);
            btnDisconnectClient.Name = "btnDisconnectClient";
            btnDisconnectClient.Size = new Size(200, 36);
            btnDisconnectClient.TabIndex = 5;
            btnDisconnectClient.Text = "Disconnect Client";
            btnDisconnectClient.UseVisualStyleBackColor = false;
            btnDisconnectClient.Click += btnDisconnectClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 32);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 6;
            label1.Text = "IP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(231, 32);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 7;
            label2.Text = "방 비밀번호";
            // 
            // PortNumTxtbox
            // 
            PortNumTxtbox.BorderStyle = BorderStyle.None;
            PortNumTxtbox.Location = new Point(308, 32);
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
            btnXml.Location = new Point(476, 70);
            btnXml.Margin = new Padding(3, 4, 3, 4);
            btnXml.Name = "btnXml";
            btnXml.Size = new Size(200, 36);
            btnXml.TabIndex = 10;
            btnXml.Text = "make XML";
            btnXml.UseVisualStyleBackColor = false;
            btnXml.Click += btnXml_Click;
            // 
            // IPAddressTxtbox
            // 
            IPAddressTxtbox.BackColor = SystemColors.Window;
            IPAddressTxtbox.BorderStyle = BorderStyle.None;
            IPAddressTxtbox.Location = new Point(64, 34);
            IPAddressTxtbox.Margin = new Padding(3, 4, 3, 4);
            IPAddressTxtbox.Name = "IPAddressTxtbox";
            IPAddressTxtbox.ReadOnly = true;
            IPAddressTxtbox.Size = new Size(152, 16);
            IPAddressTxtbox.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(33, 99);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 13;
            button1.Text = "방 생성";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Box1
            // 
            Box1.BackColor = SystemColors.Window;
            Box1.BorderStyle = BorderStyle.FixedSingle;
            Box1.Location = new Point(33, 179);
            Box1.Margin = new Padding(3, 2, 3, 2);
            Box1.Multiline = true;
            Box1.Name = "Box1";
            Box1.ReadOnly = true;
            Box1.Size = new Size(171, 32);
            Box1.TabIndex = 14;
            Box1.TextChanged += Box1_TextChanged;
            // 
            // Box2
            // 
            Box2.BackColor = SystemColors.Window;
            Box2.BorderStyle = BorderStyle.FixedSingle;
            Box2.Location = new Point(33, 241);
            Box2.Margin = new Padding(3, 2, 3, 2);
            Box2.Multiline = true;
            Box2.Name = "Box2";
            Box2.ReadOnly = true;
            Box2.Size = new Size(171, 34);
            Box2.TabIndex = 16;
            Box2.TextChanged += Box2_TextChanged;
            // 
            // Box3
            // 
            Box3.BackColor = SystemColors.Window;
            Box3.BorderStyle = BorderStyle.FixedSingle;
            Box3.Location = new Point(33, 305);
            Box3.Margin = new Padding(3, 2, 3, 2);
            Box3.Multiline = true;
            Box3.Name = "Box3";
            Box3.ReadOnly = true;
            Box3.Size = new Size(171, 34);
            Box3.TabIndex = 17;
            // 
            // Box4
            // 
            Box4.BackColor = SystemColors.Window;
            Box4.BorderStyle = BorderStyle.FixedSingle;
            Box4.Location = new Point(33, 361);
            Box4.Margin = new Padding(3, 2, 3, 2);
            Box4.Multiline = true;
            Box4.Name = "Box4";
            Box4.ReadOnly = true;
            Box4.Size = new Size(171, 34);
            Box4.TabIndex = 18;
            Box4.TextChanged += Box4_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(129, 99);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(75, 36);
            button2.TabIndex = 19;
            button2.Text = "방 닫기";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // server_message
            // 
            server_message.Location = new Point(231, 428);
            server_message.Name = "server_message";
            server_message.Size = new Size(342, 23);
            server_message.TabIndex = 20;
            server_message.TextChanged += textBox2_TextChanged_1;
            // 
            // server_send
            // 
            server_send.BackColor = Color.Transparent;
            server_send.FlatStyle = FlatStyle.Popup;
            server_send.Location = new Point(579, 428);
            server_send.Name = "server_send";
            server_send.Size = new Size(97, 23);
            server_send.TabIndex = 21;
            server_send.Text = "보내기";
            server_send.UseVisualStyleBackColor = false;
            server_send.Click += server_send_Click;
            // 
            // Server_home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 479);
            Controls.Add(server_send);
            Controls.Add(server_message);
            Controls.Add(button2);
            Controls.Add(Box4);
            Controls.Add(Box3);
            Controls.Add(Box2);
            Controls.Add(Box1);
            Controls.Add(button1);
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
            Name = "Server_home";
            Text = "home";
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
        private Button button1;
        private TextBox Box1;
        private TextBox Box2;
        private TextBox Box3;
        private TextBox Box4;
        private Button button2;
        private TextBox server_message;
        private Button server_send;
    }
}


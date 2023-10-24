namespace reserve
{
    partial class reserve_send
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reserve_send));
            sendText = new TextBox();
            reserve_introduce = new Label();
            reserve = new ComboBox();
            send_btn = new Button();
            means = new Label();
            SuspendLayout();
            // 
            // sendText
            // 
            sendText.Location = new Point(28, 52);
            sendText.Name = "sendText";
            sendText.Size = new Size(343, 23);
            sendText.TabIndex = 0;
            sendText.TextChanged += sendText_TextChanged;
            // 
            // reserve_introduce
            // 
            reserve_introduce.AutoSize = true;
            reserve_introduce.Location = new Point(28, 19);
            reserve_introduce.Name = "reserve_introduce";
            reserve_introduce.Size = new Size(274, 15);
            reserve_introduce.TabIndex = 2;
            reserve_introduce.Text = "아래에 입력한 메세지를 일정 시간 후에 보냅니다.";
            reserve_introduce.Click += reserve_introduce_Click;
            // 
            // reserve
            // 
            reserve.FormattingEnabled = true;
            reserve.Location = new Point(250, 91);
            reserve.Name = "reserve";
            reserve.Size = new Size(121, 23);
            reserve.TabIndex = 3;
            reserve.SelectedIndexChanged += reserve_SelectedIndexChanged;
            // 
            // send_btn
            // 
            send_btn.Location = new Point(387, 90);
            send_btn.Name = "send_btn";
            send_btn.Size = new Size(86, 23);
            send_btn.TabIndex = 4;
            send_btn.Text = "예약 보내기";
            send_btn.UseVisualStyleBackColor = true;
            send_btn.Click += send_btn_Click;
            // 
            // means
            // 
            means.AutoSize = true;
            means.Location = new Point(96, 94);
            means.Name = "means";
            means.Size = new Size(138, 15);
            means.TabIndex = 5;
            means.Text = "보낼 시간을 설정하세요.";
            means.Click += means_Click;
            // 
            // reserve_send
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 134);
            Controls.Add(means);
            Controls.Add(send_btn);
            Controls.Add(reserve);
            Controls.Add(reserve_introduce);
            Controls.Add(sendText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "reserve_send";
            Text = "예약 메세지";
            Load += reserve_send_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sendText;
        private Label reserve_introduce;
        private ComboBox reserve;
        private Button send_btn;
        private Label means;
    }
}
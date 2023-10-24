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
            sendText = new TextBox();
            reserve_introduce = new Label();
            SuspendLayout();
            // 
            // sendText
            // 
            sendText.Location = new Point(27, 88);
            sendText.Name = "sendText";
            sendText.Size = new Size(343, 23);
            sendText.TabIndex = 0;
            sendText.TextChanged += sendText_TextChanged;
            // 
            // reserve_introduce
            // 
            reserve_introduce.AutoSize = true;
            reserve_introduce.Location = new Point(27, 24);
            reserve_introduce.Name = "reserve_introduce";
            reserve_introduce.Size = new Size(298, 30);
            reserve_introduce.TabIndex = 2;
            reserve_introduce.Text = "아래에 입력한 메세지를 일정 시간 후에 보냅니다.\r\n방이 닫히는 시기를 고려하여 시간을 선택하여 주세요.";
            reserve_introduce.Click += reserve_introduce_Click;
            // 
            // reserve_send
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 185);
            Controls.Add(reserve_introduce);
            Controls.Add(sendText);
            Name = "reserve_send";
            Text = "reserve_send";
            Load += reserve_send_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sendText;
        private Label reserve_introduce;
    }
}
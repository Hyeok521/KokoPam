using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Emoticon;
using reserve;

namespace cocopalm_Client
{
    public partial class cocopalm_Client : Form
    {
        TcpClient clientSocket = new TcpClient(); // Socket
        NetworkStream stream = default(NetworkStream);
        string message = string.Empty;

        public cocopalm_Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNickName.Text))
                MessageBox.Show("Chat Name을 입력하세요");
            else
            {
                try
                {
                    clientSocket.Connect(MIPAddressTxtbox.Text, Convert.ToInt32(PortNumTxtbox.Text));
                    stream = clientSocket.GetStream();

                    if (stream != null)
                    {
                        byte[] buffer = Encoding.Unicode.GetBytes(this.textBoxNickName.Text + "$");
                        stream.Write(buffer, 0, buffer.Length);
                        stream.Flush();

                        int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                        byte[] send_buffer = new byte[BUFFERSIZE];
                        int bytes = stream.Read(send_buffer, 0, send_buffer.Length);
                        string send_message = Encoding.Unicode.GetString(send_buffer, 0, bytes);

                        bytes = 0;
                        stream.Flush();

                        if (send_message.Equals("Overlap"))
                        {
                            MessageBox.Show("chat name 중복");
                            this.Invoke(new Action(delegate () { textBoxNickName.Clear(); }));

                            clientSocket = new TcpClient();
                            stream = default(NetworkStream);
                        }
                        else
                        {
                            message = "채팅 서버에 연결되었습니다";
                            DisplayText(message);

                            send_message = string.Empty;

                            Thread t_handler = new Thread(GetMessage);
                            t_handler.IsBackground = true;
                            t_handler.Start();
                        }
                    }
                }
                //catch (SocketException)
                //{
                //    MessageBox.Show("서버와 이미 연결중입니다");
                //    //Application.Exit();
                //}

                // 06.14 접속 시 오류처리
                catch (SocketException ex)
                {
                    if (ex.SocketErrorCode == SocketError.IsConnected)
                    {
                        MessageBox.Show("서버와 이미 연결 중입니다");
                        // 이미 서버와 연결 중인 경우 처리할 작업
                    }
                    else
                    {
                        MessageBox.Show("서버 연결 중 오류가 발생했습니다: ");
                        // 그 외의 경우 처리할 작업
                    }
                }
                // 06.14

                catch (FormatException)
                {
                    MessageBox.Show("입력 문자열의 형식이 잘못되었습니다");
                }
                //catch (Exception)
                //{
                //    MessageBox.Show("서버가 실행중이 아닙니다", "연결 실패");
                //    stream = null;
                //    EndConnect();
                //    Application.Exit();
                //}
            }
        }

        // 메세지 보내기
        private async void btnSendText_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxMessage.Focus();
                //byte[] buffer = Encoding.Unicode.GetBytes(this.textBoxMessage.Text + "$");
                //stream.Write(buffer, 0, buffer.Length);
                //stream.Flush();
                //textBoxMessage.Text = "";
                string messageText = textBoxMessage.Text;

                // ~~ 명령어 기능~~
                if (messageText.StartsWith("/"))
                {
                    // 명령어 처리
                    string command = messageText.Substring(1); // '/' 제거

                    switch (command)
                    {
                        case "명령어":
                            // 사용 가능한 명령어 출력
                            string availableCommands = "사용 가능한 명령어:\r\n" +
                                                       "/명령어  - 사용 가능한 명령어를 보여줍니다.\r\n" +
                                                       "/시간    - 현재 시간을 보여줍니다.\r\n" +
                                                       "/주사위  - 1부터 6까지 랜덤한 숫자가 나옵니다.";
                            DisplayText(availableCommands);
                            break;

                        case "시간":
                            // 현재 시간을 보여주는 기능 수행
                            string currentTime = DateTime.Now.ToString("HH:mm:ss");
                            DisplayText("현재 시간: " + currentTime);
                            break;
                        case "주사위":
                            // 주사위 굴리기 기능 수행
                            Random random = new Random();
                            int diceNumber = random.Next(1, 7);
                            String dice = "주사위를 굴립니다...\r\n주사위에서 " + diceNumber + "이 나왔습니다!";

                            byte[] buffer = Encoding.Unicode.GetBytes(dice + "$");  // 서버에 메시지 전송
                            stream.Write(buffer, 0, buffer.Length);
                            stream.Flush();

                            break;

                        default:
                            // 알 수 없는 명령어 처리
                            MessageBox.Show("알 수 없는 명령어: " + command + "\r\n/명령어를 입력해주세요");
                            break;
                    }
                }

                else
                {

                    // 일반적인 채팅 메시지 전송
                    byte[] buffer = Encoding.Unicode.GetBytes(messageText + "$");
                    stream.Write(buffer, 0, buffer.Length);
                    stream.Flush();


                }
                // ~~ 명령어 끝

                textBoxMessage.Text = "";

            }

            catch
            {
                textBox1.Text = "";
                MessageBox.Show("서버가 연결되지 않았습니다");
            }
        }




        // 메세지 받기
        private void GetMessage()
        {
            while (true)
            {
                try
                {
                    stream = clientSocket.GetStream();
                    int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                    byte[] buffer = new byte[BUFFERSIZE];
                    int bytes = stream.Read(buffer, 0, buffer.Length);

                    string message = Encoding.Unicode.GetString(buffer, 0, bytes);

                    if (message.Equals("ServerEnd"))
                    {
                        MessageBox.Show("서버 접속 해제");

                        this.Invoke(new Action(delegate () { textBoxNickName.Clear(); }));
                        this.Invoke(new Action(delegate () { textBox1.Text = "서버 종료\n"; }));
                        this.Invoke(new Action(delegate () { MIPAddressTxtbox.Clear(); }));
                        this.Invoke(new Action(delegate () { PortNumTxtbox.Clear(); }));
                        this.Invoke(new Action(delegate () { textBoxMessage.Clear(); }));

                        stream.Write(buffer, 0, buffer.Length);
                        stream.Flush();

                        clientSocket = new TcpClient(); // Socket
                        stream = default(NetworkStream);
                        message = string.Empty;

                        break;
                    }
                    else if (message.Equals("clientEnd"))
                    {
                        this.Invoke(new Action(delegate () { textBoxNickName.Clear(); }));
                        this.Invoke(new Action(delegate () { textBox1.Text = "서버에서 접속 해제\n"; }));
                        this.Invoke(new Action(delegate () { MIPAddressTxtbox.Clear(); }));
                        this.Invoke(new Action(delegate () { PortNumTxtbox.Clear(); }));
                        this.Invoke(new Action(delegate () { textBoxMessage.Clear(); }));

                        stream.Write(buffer, 0, buffer.Length);
                        stream.Flush();

                        clientSocket = new TcpClient(); // Socket
                        stream = default(NetworkStream);
                        message = string.Empty;

                        break;
                    }

                    else DisplayText(message);

                }
                catch
                {
                    MessageBox.Show("서버 연결 해제");
                    break;
                }
            }
        }

        // Server에 메세지 출력
        private void DisplayText(string text)
        {

            if (textBox1.InvokeRequired)
            {
                textBox1.BeginInvoke(new MethodInvoker(delegate { textBox1.AppendText(text + Environment.NewLine); }));
            }
            else
                textBox1.AppendText(text + Environment.NewLine);

        }

        // 폼 닫을 때
        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            byte[] buffer = Encoding.Unicode.GetBytes("leaveChat" + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            Application.ExitThread();
            Environment.Exit(0);
            clientSocket.Close();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            EndConnect();
        }

        private void EndConnect()
        {
            try
            {
                byte[] buffer = Encoding.Unicode.GetBytes("leaveChat" + "$");
                textBoxNickName.Text = "";
                textBox1.Text = "";
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
                clientSocket = new TcpClient();
                //Application.ExitThread();
                //Environment.Exit(0);
            }
            catch
            {
                MessageBox.Show("연결된 서버가 없습니다");
            }
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                using (XmlReader rd = XmlReader.Create(@"C:\Users\super\Desktop\chat\file.xml"))
                {
                    while (rd.Read())
                    {
                        if (rd.IsStartElement())
                        {
                            if (rd.Name == "Connect")
                            {
                                // string portNumber = rd["port"];
                                // rd.GetAttribute("port");

                                try
                                {
                                    clientSocket.Connect(rd.GetAttribute("IP"), Convert.ToInt32(rd.GetAttribute("port")));
                                    stream = clientSocket.GetStream();

                                    if (stream != null)
                                    {
                                        message = "채팅 서버에 연결되었습니다";
                                        DisplayText(message);

                                        byte[] buffer = Encoding.Unicode.GetBytes(this.textBoxNickName.Text + "$");
                                        stream.Write(buffer, 0, buffer.Length);
                                        stream.Flush();

                                        Thread t_handler = new Thread(GetMessage);
                                        t_handler.IsBackground = true;
                                        t_handler.Start();
                                    }
                                }
                                catch (SocketException)
                                {
                                    MessageBox.Show("이미 서버와 연결중입니다");
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("서버 연결 실패");
                                    stream = null;
                                    EndConnect();
                                    //Application.Exit();
                                }
                            }
                        }
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("XML 파일이 없음");
            }
        }

        private void textBoxMessage_KeyUp(object sender, KeyPressEventArgs e)
        {
            // ENTER 키 눌렀을 때
            if (e.KeyChar == (char)Keys.Enter)
                btnSendText_Click(this, e);
        }

        private void PortNumTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자와 백스페이스를 제외한 나머지를 바로 처리
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                MessageBox.Show("숫자만 입력하세요");
                e.Handled = true;
            }
            this.PortNumTxtbox.MaxLength = 4;
        }

        private void textBoxNickName_TextChanged(object sender, EventArgs e)
        {
            textBoxNickName.MaxLength = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void MIPAddressTxtbox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void reserve_Click(object sender, EventArgs e)
        {
            //reserve_send reserve = new reserve(this);
            //reserve.Show();
        }

        private void emoticon_Click(object sender, EventArgs e)
        {
            var Emoticon = new Emoticon.emoticon();

            // emoticon 창을 띄웁니다.
            Emoticon.Show();
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

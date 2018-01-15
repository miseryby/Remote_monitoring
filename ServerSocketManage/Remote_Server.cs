using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerSocketManage
{
    public static class Remote_Server
    {
        //服务器IP地址和端口号
        static IPAddress IP = IPAddress.Parse("127.0.0.1");
        static IPEndPoint ipe = new IPEndPoint(IP, 6000);
        static Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        //监听
        public static void Remote_listen()
        {
            try
            {
                ServerSocket.Bind(ipe);
                ServerSocket.Listen(10);
                Thread th = new Thread(AcceptInfo);
                th.IsBackground = true;
                th.Start();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
       public static void AcceptInfo(object o)

        {

            Socket socket = o as Socket;

            while (true)

            {

                //通信用socket

                try

                {

                    //创建通信用的Socket

                    Socket tSocket = socket.Accept();

                    string point = tSocket.RemoteEndPoint.ToString();

                    dictSocket.Add(tSocket.RemoteEndPoint.ToString(), tSocket);

                    //接收消息

                    Thread th = new Thread(ReceiveMsg);

                    th.IsBackground = true;

                    th.Start(tSocket);

                }

                catch (Exception ex)

                {

                    break;

                }

            }

        }
        //保存了服务器端所有负责和客户端通信发套接字  
        static Dictionary<string, Socket> dictSocket = new Dictionary<string, Socket>();

       public static void ReceiveMsg(object o)

        {

            Socket client = o as Socket;
            List<byte> byteSource = new List<byte>();
            while (true)
            {
                try
                {
                    //定义byte数组存放从客户端接收过来的数据
                    byte[] buffer = new byte[1024 * 1024];
                    if (client.Receive(buffer) > 0)
                        byteSource.AddRange(buffer);
                }
                catch (Exception ex)
                {

                    break;
                }
            }
            byte[] data = byteSource.ToArray();
            //分析接收到的数据，代写
        }
       public static void SendMsg(string sendMsg, string strClientKey)
        {
                byte[] strSendMsg = Encoding.UTF8.GetBytes(sendMsg);
                dictSocket[strClientKey].Send(strSendMsg);
        }
        //发送命令
       public static void SendIns(string instruction, string strClientKey)
        {
            SendMsg("#INS#" + instruction, strClientKey);
        }
       public static void SendIns(string instruction, Socket sock)
        {
            byte[] strSendMsg = Encoding.UTF8.GetBytes("#INS#" + instruction);
            sock.Send(strSendMsg);
        }
    }
}

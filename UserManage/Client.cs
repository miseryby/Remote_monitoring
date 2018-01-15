using System.Net.Sockets;
using ServerSocketManage;
namespace ClientManage
{
    /// <summary>
    /// 暗号：
    /// 1--进程
    /// 2--截图
    /// 3--锁屏
    /// 4--解锁
    /// 5--关机
    /// 6--重启
    /// 7--注销
    /// </summary>
    public class Client
    {
        public static string jincheng = "1";
        public static string jietu = "2";
        public static string tingzhijietu = "2stop";
        public static string suoping = "3";
        public static string jiesuo = "4";
        public static string guanji = "5";
        public static string chongqi = "6";
        public static string zhuxiao = "7";
        static Socket ClientSocket;
        public Client(Socket sk) { ClientSocket = sk; }
        
        public void GetScreen()
        {
            sendIns(jietu);
        }
        public void EndGetScreen()
        {
            sendIns(tingzhijietu);
        }
        public void GetProcess()
        {
            sendIns(jincheng);
        }
        public void shutdown()
        {
            sendIns(guanji);
        }
        public void lockScreen()
        {
            sendIns(suoping);
        }
        public void unlockScreen()
        {
            sendIns(jiesuo);
        }
        public void reboot()
        {
            sendIns(chongqi);
        }
        public void logout()
        {
            sendIns(zhuxiao);
        }
        public void sendIns(string ins)
        {
            Remote_Server.SendIns(ins, ClientSocket);
        }
    }
}

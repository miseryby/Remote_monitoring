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
        private static string jincheng = "1";
        private static string jietu = "2";
        private static string tingzhijietu = "2stop";
        private static string suoping = "3";
        private static string jiesuo = "4";
        private static string guanji = "5";
        private static string chongqi = "6";
        private static string zhuxiao = "7";

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

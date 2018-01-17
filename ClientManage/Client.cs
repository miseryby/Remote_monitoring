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
    public static class Client
    {
        private static string jincheng = "1";
        private static string jietu = "2";
        private static string tingzhijietu = "2stop";
        private static string suoping = "3";
        private static string jiesuo = "4";
        private static string guanji = "5";
        private static string chongqi = "6";
        private static string zhuxiao = "7";
        
        public static void GetScreen(string ClientKey)
        {
            sendIns(jietu, ClientKey);
        }
        public static void EndGetScreen(string ClientKey)
        {
            sendIns(tingzhijietu, ClientKey);
        }
        public static void GetProcess(string ClientKey)
        {
            sendIns(jincheng, ClientKey);
        }
        public static void shutdown(string ClientKey)
        {
            sendIns(guanji, ClientKey);
        }
        public static void lockScreen(string ClientKey)
        {
            sendIns(suoping, ClientKey);
        }
        public static void unlockScreen(string ClientKey)
        {
            sendIns(jiesuo, ClientKey);
        }
        public static void reboot(string ClientKey)
        {
            sendIns(chongqi, ClientKey);
        }
        public static void logout(string ClientKey)
        {
            sendIns(zhuxiao, ClientKey);
        }
        public static void sendIns(string ins,string ClientKey)
        {
            Remote_Server.SendIns(ins, ClientKey);
        }
    }
}

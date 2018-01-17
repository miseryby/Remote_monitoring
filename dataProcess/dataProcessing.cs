using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataProcess
{
    public static  class dataProcessing
    {
        private static Queue Q = new Queue(10);
        //存放图片数据
        public static void Save(byte[] s)
        {
            //超出10
            if (Q.Count == 10)
            {

            }
            //不超过10时存入队尾
            else
            {
                Q.Enqueue(s);
            }
        }
        
       public  static byte[] Readcode()
        {
            //队列不为空
            if (Q.Count > 0)
            {
                //读取第一个指令
                byte[] code = (byte[])Q.Dequeue();
                return code;
            }
            //队列为空
            else
            {
                byte[] code = { 0 };
                return code;
            }
        }
        public static char isImgOrStr(byte[] source,byte[] data)
        {
                byte[] bt = new byte[5];//区分究竟是进程信息还是图片信息
                for (int i = 0; i <= 4; i++)//前五个字节码为#PRO#的字节码
                {
                    bt[i] = source[i];
                }
                string temp = System.Text.Encoding.Default.GetString(bt);
            byte[] bty = new byte[source.Length - 5];//第五个字节码后为进程信息
                for (int i = 0; i <= source.Length - 6; i++)
                {
                    bty[i] = data[i + 5];
                }
                data = bty;
            if (temp == "#IMG#")
                return 'I';
            else if (temp == "#PRO#")
                return 'P';
            else
                return 'N';
        }
        public static string byteToProcess(byte[] data)
        {
           return System.Text.Encoding.Default.GetString(data);
        }
    }

}

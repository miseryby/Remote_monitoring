using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataProcess
{
    public static class dataProcessing
    {
        private static string[,] processes;
        private static Queue Q = new Queue(10);
        //存放图片数据
        private static void SavePro(byte[] s)
        {
            processes = AllProcessStrToArrayStr(byteToProcess(s));
        }
        public static string[,] ReadPro()
        {
            return processes;
        }

        private static void SavePic(byte[] s)
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

        public static byte[] ReadPic()
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
        /// <summary>
        /// 分析数据是图片还是进程
        /// </summary>
        /// <param name="source"></param>
        public static void isImgOrStr(byte[] source)
        {
            byte[] data = new byte[source.Length - 5];
            byte[] bt = new byte[5];//区分究竟是进程信息还是图片信息
            for (int i = 0; i <= 4; i++)//前五个字节码为#PRO#的字节码
            {
                bt[i] = source[i];
            }
            string temp = System.Text.Encoding.Default.GetString(bt);
            for (int i = 0; i <= source.Length - 6; i++)
            {
                data[i]   = source[i + 5];
            }
            if (temp == "#IMG#")
                SavePic(data);
            else if (temp == "#PRO#")
            {
                SavePro(data);
            }
        }

        private static string byteToProcess(byte[] data)
        {
            return System.Text.Encoding.Default.GetString(data);
        }


        /// <summary>
        /// 将转换成的String制成str数组输出
        /// str二维数组，N行表示有N个进程，
        /// str[i,j]：j为0时为第i个进程的id，j为1时为第i个进程名字
        /// </summary>
        private static string[,] AllProcessStrToArrayStr(string str)
        {
            //将所有进程信息划分为逐个进程
            string[] ProcessArray = str.Split(',');
            int ProcessNum = ProcessArray.Length;

            //开辟二维数组
            string[,] ArrayStr = new string[ProcessNum, 2];

            for (int i = 0; i < ProcessNum - 1; i++)
            {
                ////将每个进程的id和名字分开
                string[] EachProcessIdAndNameArray = ProcessArray[i].Split('_');

                for (int j = 0; j < 2; j++)
                {
                    ArrayStr[i, j] = EachProcessIdAndNameArray[j];
                }
            }

            for (int i = 0; i < ProcessNum; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(ArrayStr[i, j]);
                    if (j == 1)
                        Console.WriteLine("");
                }
            }
            return ArrayStr;
        }
    }

}

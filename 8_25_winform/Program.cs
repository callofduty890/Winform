using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_25_winform
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hash = new Hashtable();//创建实例
            //添加 键-值 对
            hash.Add(".txt", "记事本.exe");
            hash.Add(".bmp", "图片管理器.exe");
            hash.Add(".doc", "officeWorld.exe");
            hash.Add(".xls", "officeExcle.exe");
            //修改 键-值 对
            hash[".doc"] = "wpf.exe";
            //遍历的两种方式
            foreach (var item in hash.Keys)
                Console.WriteLine(item+":"+hash[item] + "\n");
            Console.WriteLine("==========================");
            foreach (DictionaryEntry item in hash)
                Console.WriteLine("Key={0},Value={1}",item.Key,item.Value);
            Console.ReadLine();
        }
    }
}

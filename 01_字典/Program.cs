using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_字典
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            //赋值
            dict.Add("key2", "value2");
            dict.Add("key1", "value1");
            //修改
            dict["key1"] = "value01";
            //遍历
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item+":"+dict[item] + "\t");
            }
            Console.WriteLine("===================");
            //遍历
            foreach (KeyValuePair<string,string> item in dict)
            {
                Console.WriteLine("Key={0},Value={1}", item.Key, item.Value);
            }
            Console.ReadKey();
        }
    }
}

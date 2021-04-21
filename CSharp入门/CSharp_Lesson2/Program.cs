//变量
//21.4.21

using System;

namespace CSharp_Lesson2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("变量");

			#region 如何声明变量
			//1.有符号的整型变量
			sbyte sb = 1;
			//潜在知识点	通过+来拼接打印
			Console.WriteLine("sbyte变量sb中存储的值是：" + sb);
			int i = 2;
			short s = 3;
			long l = 4;

			//2.无符号的整型变量
			byte b = 1;
			ushort us = 2;
			uint ui = 3;
			ulong ul = 4;

			//3.浮点数
			float f = 0.1234567890f;
			Console.WriteLine(f);//输出0.12345679，因为8位有效数字，最后一位四舍五入
			double d = 0.12345678901234567890;
			Console.WriteLine(d);
			decimal de = 0.123456789012345678901234567890m;
			Console.WriteLine(de);

			//4.特殊类型
			bool bo = true;
			bool bo2 = false;
			Console.WriteLine(bo + "_" + bo2);
			char c = '牛';
			Console.WriteLine(c);
			string str = "asfhjkdfhjkfas";
			Console.WriteLine(str);

			#endregion
			#region 为什么有那么多不同变量类型
			//姓名
			string myName = "小赵";
			//年龄
			byte myAge = 26;
			//身高
			float height = 178.5f;
			//体重
			float weight = 60.2f;
			//性别	true女 false男
			bool sex = false;

			#endregion
			#region 多个相同类型的变量同时声明
			int a1 = 1, a2 = 2, a3 = 3;
			#endregion
			#region 变量初始化相关
			int a6;
			a6 = 9;
			Console.WriteLine(a6);
			#endregion
		}
	}
}

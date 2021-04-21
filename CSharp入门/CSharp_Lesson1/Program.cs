//第一个应用程序	注释-程序文件的基础结构
//2021.4.21

//第一种注释 两杠注释
//第二种注释	星号注释
//第三种注释 三杠注释

//引用命名空间（工具包）
using System;

/// <summary>
/// 命名空间 - 工具包
/// </summary>
namespace CSharp_21_4_21
{
	//命名空间代码块
	//面向对象相关知识点内容 会在这里来写代码

	/// <summary>
	/// 类 - 工具
	/// </summary>
	class Program
	{
		//类 代码块
		//面向对象相关知识点内容 会在这里来写代码

		/// <summary>
		/// 函数 - 工具能做的事情
		/// 主函数 一个程序的入口
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			//函数代码块 我们目前学习基础知识时
			//所有代码都会写在该代码块中

			//在控制台打印一行信息 打印结束后自动换行
			Console.WriteLine("Hello World!");
			Console.WriteLine("你好世界");

			//在控制台打印一行信息 打印结束后不会自动换行
			Console.Write("我要好好学习");
			Console.Write("天天向上");

			//检测玩家输入的代码
			//等待玩家输入完毕后（按回车键）才会继续执行后面的代码
			Console.ReadLine();

			//检测玩家是否按键 只要按了键盘上的任意键 就会认为输入结束
			Console.ReadKey();

			//输入 向控制台输入内容
			//Console.ReadLine();
			//Console.ReadKey();

			//输出 在控制台输出信息
			//Console.WriteLine();
			//Console.Write();
		}
	}
}

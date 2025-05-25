using System;

namespace ConsoleApp
{
    /// <summary>
    /// サンプル01
    /// コンソール入出力
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// メインメソッド（プログラムのエントリポイント）
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // コンソールに文字列を出力した後に入力を待機する
            Console.Write("文字列を入力してください： ");
            string inputString = Console.ReadLine();

            // 入力された文字列をコンソールに出力する
            Console.WriteLine("入力された文字列は" + inputString + "です");
            // Console.WriteLine("入力された文字列は{0}です", inputString);
        }
    }
}
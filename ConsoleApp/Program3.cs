using System;

namespace ConsoleApp
{
    /// <summary>
    /// サンプル03
    /// コンソール入出力（ループからの脱出）
    /// </summary>
    internal class Program3
    {
        /// <summary>
        /// メインメソッド（プログラムのエントリポイント）
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string inputString = null;

            // 抜け出さない限り繰り返す（永久ループ）
            while (true)
            {
                // コンソールに文字列を出力した後に入力を待機する
                Console.Write("文字列を入力してください（'E'を入れると終了します）： ");
                inputString = Console.ReadLine();

                if ("E" == inputString)
                {
                    break;
                }
                else
                {
                    // 入力された文字列をコンソールに出力する
                    Console.WriteLine("入力された文字列は" + inputString + "です");
                }
            }

            Console.WriteLine("ループを終了しました");

            // 何かキーが入力されるまで待機する
            Console.WriteLine("何かキーを押すと終了します");
            Console.ReadKey();
        }
    }
}
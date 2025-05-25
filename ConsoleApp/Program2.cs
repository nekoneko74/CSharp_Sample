using System;

namespace ConsoleApp
{
    /// <summary>
    /// サンプル02
    /// コンソール入出力（ループで繰り返す）
    /// </summary>
    internal class Program2
    {
        /// <summary>
        /// メインメソッド（プログラムのエントリポイント）
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string inputString = null;

            // 'E'が入力されないあいだ繰り返す ＝ 'E'が入力されるまで繰り返す
            while ("E" != inputString)
            {
                // コンソールに文字列を出力した後に入力を待機する
                Console.Write("文字列を入力してください（'E'を入れると終了します）： ");
                inputString = Console.ReadLine();

                // 入力された文字列をコンソールに出力する
                Console.WriteLine("入力された文字列は" + inputString + "です");
            }

            Console.WriteLine("ループを終了しました");
        }
    }
}
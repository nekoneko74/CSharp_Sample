using System;

namespace OOP.Sample01
{
    /// <summary>
    /// サンプル01
    /// 学生／成績管理プログラムの基本形
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// メインメソッド（プログラムのエントリポイント）
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            try
            {
                // 管理対象の学生／科目別の成績を保持する変数を確保する
                //  ⇒ 実際のプログラミングにおいてはユーザーが入力した後にデータベースに保存されていたりします
                int studentNo = 202;
                string studentName = "学生一郎";
                int japanesePoint = 85;
                int mathPoint = 75;
                int englishPoint = 60;

                // 学生／成績の情報をコンソールに表示する
                // ヘッダを出力する
                Console.WriteLine("-------------------------------------------------------------");
                Console.WriteLine("| No. | Name\t\t| JPN | MAT | ENG | TTL | AVG | EVA |");
                Console.WriteLine("-------------------------------------------------------------");

                // 学生番号／学生氏名を表示する
                Console.Write("| {0,3:D} ", studentNo);
                Console.Write("| {0}\t", studentName);

                // 国語／数学／英語の各テストの点数をフォーマット／桁合わせをして出力する
                Console.Write("| {0,3:D} ", japanesePoint);
                Console.Write("| {0,3:D} ", mathPoint);
                Console.Write("| {0,3:D} ", englishPoint);

                // 合計点を計算して出力する
                int total = japanesePoint + mathPoint + englishPoint;
                Console.Write("| {0,3:D} ", total);

                // 平均点を計算して出力する
                int avg = total / 3;
                Console.Write("| {0,3:D} ", avg);

                // 成績評価を出力する
                string evaluation = GetEvaluation(japanesePoint, mathPoint, englishPoint);
                Console.Write("|  {0}  ", evaluation);

                // 一番右側の「|」を出力後に改行する
                Console.WriteLine("|");

                // フッタ（最終行）を出力する
                Console.WriteLine("-------------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("例外が発生しました：" + ex.Message);
            }
        }

        /// <summary>
        /// 学生の成績評価を取得する
        /// </summary>
        /// <param name="japanesePoint">国語の点数</param>
        /// <param name="mathPoint">数学の点数</param>
        /// <param name="englishPoint">英語の点数</param>
        /// <returns>成績評価（S／A／B／C／D／F）</returns>
        public static string GetEvaluation(int japanesePoint, int mathPoint, int englishPoint)
        {
            string evaluation;

            // 3教科の点数がそれぞれ60点以上であること
            if (60 <= japanesePoint && 60 <= mathPoint && 60 <= englishPoint)
            {
                // 3教科の合計点で評価を決定する
                int total = japanesePoint + mathPoint + englishPoint;
                if (290 <= total)
                {
                    evaluation = "S";
                }
                else if (260 <= total)
                {
                    evaluation = "A";
                }
                else if (230 <= total)
                {
                    evaluation = "B";
                }
                else if (200 <= total)
                {
                    evaluation = "C";
                }
                else // if (180 <= total)
                {
                    evaluation = "D";
                }
            }
            // 3教科の点数のうちどれかが60点未満だった
            else
            {
                evaluation = "F";
            }

            return evaluation;
        }
    }
}
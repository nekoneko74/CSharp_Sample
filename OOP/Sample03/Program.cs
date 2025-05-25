using System;

namespace OOP.Sample03
{
    /// <summary>
    /// サンプル03
    /// 学生／成績管理プログラム（配列＋メソッド版）
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
                // 管理対象の学生／科目別の成績を保持する配列変数（5人分）を確保する
                //  ⇒ 実際のプログラミングにおいてはユーザーが入力した後にデータベースに保存されていたりします
                int[] studentNos = new int[5];
                string[] studentNames = new string[5];
                int[] japanesePoints = new int[5];
                int[] mathPoints = new int[5];
                int[] englishPoints = new int[5];

                studentNos[0] = 201;
                studentNames[0] = "満点花子";
                japanesePoints[0] = 100;
                mathPoints[0] = 100;
                englishPoints[0] = 100;

                studentNos[1] = 202;
                studentNames[1] = "学生一郎";
                japanesePoints[1] = 85;
                mathPoints[1] = 75;
                englishPoints[1] = 60;

                studentNos[2] = 203;
                studentNames[2] = "合格瀬戸際";
                japanesePoints[2] = 60;
                mathPoints[2] = 60;
                englishPoints[2] = 60;

                studentNos[3] = 204;
                studentNames[3] = "合格出来無";
                japanesePoints[3] = 60;
                mathPoints[3] = 60;
                englishPoints[3] = 59;

                studentNos[4] = 205;
                studentNames[4] = "零点大介";
                japanesePoints[4] = 0;
                mathPoints[4] = 0;
                englishPoints[4] = 0;

                // 学生／成績のリストをコンソールに表示する
                DisplayStudents(studentNos, studentNames, japanesePoints, mathPoints, englishPoints);
            }
            catch (Exception ex)
            {
                Console.WriteLine("例外が発生しました：" + ex.Message);
            }
        }

        /// <summary>
        /// 学生／成績のリストをコンソールに表示する
        /// </summary>
        /// <param name="studentNos">学生番号の配列</param>
        /// <param name="studentNames">学生氏名の配列</param>
        /// <param name="japanesePoints">国語の点数の配列</param>
        /// <param name="mathPoints">数学の点数の配列</param>
        /// <param name="englishPoints">英語の点数の配列</param>
        public static void DisplayStudents(int[] studentNos, string[] studentNames, int[] japanesePoints, int[] mathPoints, int[] englishPoints)
        {
            // ヘッダを出力する
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("| No. | Name\t\t| JPN | MAT | ENG | TTL | AVG | EVA |");
            Console.WriteLine("-------------------------------------------------------------");

            // 学生／成績の配列の要素を1行に出力する処理を繰り返す
            for (int i = 0; i < studentNos.Length; i++)
            {
                // 学生番号／学生氏名を表示する
                Console.Write("| {0,3:D} ", studentNos[i]);
                Console.Write("| {0}\t", studentNames[i]);

                // 国語／数学／英語の各テストの点数をフォーマット／桁合わせをして出力する
                Console.Write("| {0,3:D} ", japanesePoints[i]);
                Console.Write("| {0,3:D} ", mathPoints[i]);
                Console.Write("| {0,3:D} ", englishPoints[i]);

                // 合計点を計算して出力する
                int total = japanesePoints[i] + mathPoints[i] + englishPoints[i];
                Console.Write("| {0,3:D} ", total);

                // 平均点を計算して出力する
                int avg = total / 3;
                Console.Write("| {0,3:D} ", avg);

                // 成績評価を出力する
                string evaluation = GetEvaluation(japanesePoints[i], mathPoints[i], englishPoints[i]);
                Console.Write("|  {0}  ", evaluation);

                // 一番右側の「|」を出力後に改行する
                Console.WriteLine("|");
            }

            // フッタ（最終行）を出力する
            Console.WriteLine("-------------------------------------------------------------");
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
            string evaluation = "F";

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

            return evaluation;
        }
    }
}
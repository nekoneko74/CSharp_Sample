using System;

namespace OOP.Sample06
{
    /// <summary>
    /// サンプル06
    /// 学生／成績管理プログラム（オブジェクト指向／3教科対応版）
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
                // 管理対象の学生／科目別の成績の配列変数（5人分）を生成する
                //  ⇒ 実際のプログラミングにおいてはユーザーが入力した後にデータベースに保存されていたりします
                Student3[] students = new Student3[5];

                students[0] = new Student3(201, "満点花子", 100, 100, 100);
                students[1] = new Student3(202, "学生一郎", 85, 75, 60);
                students[2] = new Student3(203, "合格瀬戸際", 60, 60, 60);
                students[3] = new Student3(204, "合格出来無", 60, 60, 59);
                students[4] = new Student3(205, "零点大介", 0, 0, 0);

                // 学生／成績のリストをコンソールに表示する
                DisplayStudents(students);
            }
            catch (Exception ex)
            {
                Console.WriteLine("例外が発生しました：" + ex.Message);
            }

            // 何かキーが入力されるまで待機する
            Console.WriteLine("何かキーを押すと終了します");
            Console.ReadKey();
        }

        /// <summary>
        /// 学生／成績のリストをコンソールに表示する
        /// </summary>
        /// <param name="students">学生／科目別の成績の配列</param>
        public static void DisplayStudents(Student3[] students)
        {
            // ヘッダを出力する
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("| No. | Name\t\t| JPN | MAT | ENG | TTL | AVG | EVA |");
            Console.WriteLine("-------------------------------------------------------------");

            // 学生／成績の配列の要素を1行に出力する処理を繰り返す
            foreach (Student3 student in students)
            {
                // 学生番号／学生氏名を表示する
                Console.Write("| {0,3:D} ", student.StudentNo);
                Console.Write("| {0}\t", student.StudentName);

                // 国語／数学／英語の各テストの点数をフォーマット／桁合わせをして出力する
                Console.Write("| {0,3:D} ", student.Japanese);
                Console.Write("| {0,3:D} ", student.Math);
                Console.Write("| {0,3:D} ", student.English);

                // 合計点を計算して出力する
                int total = student.Japanese + student.Math + student.English;
                Console.Write("| {0,3:D} ", total);

                // 平均点を計算して出力する
                int avg = total / 3;
                Console.Write("| {0,3:D} ", avg);

                // 成績評価を出力する
                Evaluation evaluation = GetEvaluation(student.Japanese, student.Math, student.English);
                Console.Write("|  {0}  ", evaluation.ToString());

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
        public static Evaluation GetEvaluation(int japanesePoint, int mathPoint, int englishPoint)
        {
            Evaluation evaluation = Evaluation.F;

            // 3教科の点数がそれぞれ60点以上であること
            if (60 <= japanesePoint && 60 <= mathPoint && 60 <= englishPoint)
            {
                // 3教科の合計点で評価を決定する
                int total = japanesePoint + mathPoint + englishPoint;
                if (290 <= total)
                {
                    evaluation = Evaluation.S;
                }
                else if (260 <= total)
                {
                    evaluation = Evaluation.A;
                }
                else if (230 <= total)
                {
                    evaluation = Evaluation.B;
                }
                else if (200 <= total)
                {
                    evaluation = Evaluation.C;
                }
                else // if (180 <= total)
                {
                    evaluation = Evaluation.D;
                }
            }

            return evaluation;
        }
    }
}
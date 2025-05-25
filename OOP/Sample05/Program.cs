using System;

namespace OOP.Sample05
{
    /// <summary>
    /// サンプル05
    /// 学生／成績管理プログラム（5教科対応版）
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
                // 管理対象の学生／科目別の成績の配列変数（10人分）を生成する
                //  ⇒ 実際のプログラミングにおいてはユーザーが入力した後にデータベースに保存されていたりします
                int[] studentNos = new int[10];
                string[] studentNames = new string[10];
                int[] studentTypes = new int[10];
                int[] japanesePoints = new int[10];
                int[] mathPoints = new int[10];
                int[] englishPoints = new int[10];
                int[] sciencePoints = new int[10];
                int[] socialStudyPoints = new int[10];

                studentNos[0] = 201;
                studentNames[0] = "満点花子";
                studentTypes[0] = 3;
                japanesePoints[0] = 100;
                mathPoints[0] = 100;
                englishPoints[0] = 100;
                sciencePoints[0] = 0;
                socialStudyPoints[0] = 0;

                studentNos[1] = 202;
                studentNames[1] = "学生一郎";
                studentTypes[1] = 3;
                japanesePoints[1] = 85;
                mathPoints[1] = 75;
                englishPoints[1] = 60;
                sciencePoints[1] = 0;
                socialStudyPoints[1] = 0;

                studentNos[2] = 203;
                studentNames[2] = "合格瀬戸際";
                studentTypes[2] = 3;
                japanesePoints[2] = 60;
                mathPoints[2] = 60;
                englishPoints[2] = 60;
                sciencePoints[2] = 0;
                socialStudyPoints[2] = 0;

                studentNos[3] = 204;
                studentNames[3] = "合格出来無";
                studentTypes[3] = 3;
                japanesePoints[3] = 60;
                mathPoints[3] = 60;
                englishPoints[3] = 59;
                sciencePoints[3] = 0;
                socialStudyPoints[3] = 0;

                studentNos[4] = 205;
                studentNames[4] = "零点大介";
                studentTypes[4] = 3;
                japanesePoints[4] = 0;
                mathPoints[4] = 0;
                englishPoints[4] = 0;
                sciencePoints[4] = 0;
                socialStudyPoints[4] = 0;

                studentNos[5] = 301;
                studentNames[5] = "学生花江";
                studentTypes[5] = 5;
                japanesePoints[5] = 33;
                mathPoints[5] = 100;
                englishPoints[5] = 50;
                sciencePoints[5] = 45;
                socialStudyPoints[5] = 0;

                studentNos[6] = 302;
                studentNames[6] = "学生次郎";
                studentTypes[6] = 5;
                japanesePoints[6] = 60;
                mathPoints[6] = 60;
                englishPoints[6] = 60;
                sciencePoints[6] = 59;
                socialStudyPoints[6] = 60;

                studentNos[7] = 303;
                studentNames[7] = "文系虎子";
                studentTypes[7] = 5;
                japanesePoints[7] = 85;
                mathPoints[7] = 95;
                englishPoints[7] = 85;
                sciencePoints[7] = 95;
                socialStudyPoints[7] = 85;

                studentNos[8] = 304;
                studentNames[8] = "超平均三郎";
                studentTypes[8] = 5;
                japanesePoints[8] = 60;
                mathPoints[8] = 60;
                englishPoints[8] = 60;
                sciencePoints[8] = 60;
                socialStudyPoints[8] = 60;

                studentNos[9] = 305;
                studentNames[9] = "理系美子";
                studentTypes[9] = 5;
                japanesePoints[9] = 100;
                mathPoints[9] = 100;
                englishPoints[9] = 100;
                sciencePoints[9] = 100;
                socialStudyPoints[9] = 100;

                // 学生／成績のリストをコンソールに表示する
                DisplayStudents(studentNos, studentNames, studentTypes, japanesePoints, mathPoints, englishPoints, sciencePoints, socialStudyPoints);
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
        /// <param name="studentTypes">学生の選択コースの配列</param>
        /// <param name="japanesePoints">国語の点数の配列</param>
        /// <param name="mathPoints">数学の点数の配列</param>
        /// <param name="englishPoints">英語の点数の配列</param>
        /// <param name="sciencePoints">理科の点数</param>
        /// <param name="socialStudyPoints">社会の点数</param>
        public static void DisplayStudents(int[] studentNos, string[] studentNames, int[] studentTypes, int[] japanesePoints, int[] mathPoints, int[] englishPoints, int[] sciencePoints, int[] socialStudyPoints)
        {
            // ヘッダを出力する
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("| No. | Name\t\t| JPN | MAT | ENG | SCI | SOC | TTL | AVG | EVA |");
            Console.WriteLine("-------------------------------------------------------------------------");

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
                if (5 == studentTypes[i])
                {
                    // 5教科コースの場合には理科／社会の点数を表示する
                    Console.Write("| {0,3:D} ", sciencePoints[i]);
                    Console.Write("| {0,3:D} ", socialStudyPoints[i]);
                }
                else
                {
                    // 3教科コースの場合には理科／社会の点数を表示しない
                    Console.Write("| --- ");
                    Console.Write("| --- ");
                }

                // 合計点を計算して出力する
                int total = japanesePoints[i] + mathPoints[i] + englishPoints[i];
                if (5 == studentTypes[i])
                {
                    total += sciencePoints[i] + socialStudyPoints[i];
                }
                Console.Write("| {0,3:D} ", total);

                // 平均点を計算して出力する
                int avg = total / studentTypes[i];
                Console.Write("| {0,3:D} ", avg);

                // 成績評価を出力する
                Evaluation evaluation;
                if (5 == studentTypes[i])
                {
                    evaluation = GetEvaluation(japanesePoints[i], mathPoints[i], englishPoints[i], sciencePoints[i], socialStudyPoints[i]);
                }
                else
                {
                    evaluation = GetEvaluation(japanesePoints[i], mathPoints[i], englishPoints[i]);
                }
                Console.Write("|  {0}  ", evaluation.ToString());

                // 一番右側の「|」を出力後に改行する
                Console.WriteLine("|");
            }

            // フッタ（最終行）を出力する
            Console.WriteLine("-------------------------------------------------------------------------");
        }

        /// <summary>
        /// 3教科コースの学生の成績評価を取得する
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

        /// <summary>
        /// 5教科コースの学生の成績評価を取得する
        /// </summary>
        /// <param name="japanesePoint">国語の点数</param>
        /// <param name="mathPoint">数学の点数</param>
        /// <param name="englishPoint">英語の点数</param>
        /// <param name="sciencePoint">理科の点数</param>
        /// <param name="socialStudyPoint">社会の点数</param>
        /// <returns>成績評価（S／A／B／C／D／F）</returns>
        public static Evaluation GetEvaluation(int japanesePoint, int mathPoint, int englishPoint, int sciencePoint, int socialStudyPoint)
        {
            Evaluation evaluation = Evaluation.F;

            // 5教科の点数がそれぞれ60点以上であること
            if (60 <= japanesePoint && 60 <= mathPoint && 60 <= englishPoint && 60 <= sciencePoint && 60 <= socialStudyPoint)
            {
                // 5教科の合計点で評価を決定する
                int total = japanesePoint + mathPoint + englishPoint + sciencePoint + socialStudyPoint;
                if (480 <= total)
                {
                    evaluation = Evaluation.S;
                }
                else if (450 <= total)
                {
                    evaluation = Evaluation.A;
                }
                else if (400 <= total)
                {
                    evaluation = Evaluation.B;
                }
                else if (350 <= total)
                {
                    evaluation = Evaluation.C;
                }
                else // if (300 <= total)
                {
                    evaluation = Evaluation.D;
                }
            }

            return evaluation;
        }
    }
}
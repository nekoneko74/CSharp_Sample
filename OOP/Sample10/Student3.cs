using System;

namespace OOP.Sample10
{
    /// <summary>
    /// 国語／数学／英語の3教科対応版の成績クラス
    /// </summary>
    public class Student3 : Student
    {
        /// <summary>
        /// 国語の点数
        /// </summary>
        protected int japanese = 0;

        /// <summary>
        /// 数学の点数
        /// </summary>
        protected int math = 0;

        /// <summary>
        /// 英語の点数
        /// </summary>
        protected int english = 0;

        /// <summary>
        /// プロパティ：国語の点数
        /// </summary>
        /// <exception cref="Exception">国語の点数に0未満または100より大きい値が設定された</exception>
        public int Japanese
        {
            get
            {
                return this.japanese;
            }
            set
            {
                if (value < 0 || 100 < value)
                {
                    throw new Exception("国語の点数には0～100の数値を設定してください。");
                }
                this.japanese = value;
            }
        }

        /// <summary>
        /// プロパティ：数学の点数
        /// </summary>
        /// <exception cref="Exception">数学の点数に0未満または100より大きい値が設定された</exception>
        public int Math
        {
            get
            {
                return this.math;
            }
            set
            {
                if (value < 0 || 100 < value)
                {
                    throw new Exception("数学の点数には0～100の数値を設定してください。");
                }
                this.math = value;
            }
        }

        /// <summary>
        /// プロパティ：英語の点数
        /// </summary>
        /// <exception cref="Exception">英語の点数に0未満または100より大きい値が設定された</exception>
        public int English
        {
            get
            {
                return this.english;
            }
            set
            {
                if (value < 0 || 100 < value)
                {
                    throw new Exception("英語の点数には0～100の数値を設定してください。");
                }
                this.english = value;
            }
        }

        /// <summary>
        /// 合計点を計算する
        /// </summary>
        /// <returns>計算された合計点</returns>
        public override int CalcTotal()
        {
            return this.japanese + this.math + this.english;
        }

        /// <summary>
        /// 学生の成績評価を取得する
        /// </summary>
        /// <returns>成績評価（S／A／B／C／D／F）</returns>
        public override Evaluation GetEvaluation()
        {
            Evaluation evaluation = Evaluation.F;

            // 3教科の点数がそれぞれ60点以上であること
            if (60 <= this.japanese && 60 <= this.math && 60 <= this.english)
            {
                // 3教科の合計点で評価を決定する
                int total = this.CalcTotal();
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
        /// 平均点の計算に使用する科目数を取得する
        /// </summary>
        /// <returns>平均点の計算に使用する科目数</returns>
        public override int GetNumOfSubjects()
        {
            return 3;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Student3() : base()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Student3(int studentNo, string studentName) : base(studentNo, studentName)
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Student3(int studentNo, string studentName, int japanese, int math, int english) : base(studentNo, studentName)
        {
            this.Japanese = japanese;
            this.Math = math;
            this.English = english;
        }
    }
}
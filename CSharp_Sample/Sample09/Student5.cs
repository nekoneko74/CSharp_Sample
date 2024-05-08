using System;

namespace CSharp_Sample.Sample09
{
    /// <summary>
    /// 国語／数学／英語に加えて理科／社会まで扱う5教科版の学生／成績クラス
    /// </summary>
    public class Student5 : Student3
    {
        /// <summary>
        /// 理科の点数
        /// </summary>
        protected int science = 0;

        /// <summary>
        /// 社会の点数
        /// </summary>
        protected int socialStudies = 0;

        /// <summary>
        /// プロパティ：理科の点数
        /// </summary>
        /// <exception cref="Exception">理科の点数に0未満または100より大きい値が設定された</exception>
        public int Science
        {
            get
            {
                return this.science;
            }
            set
            {
                if (value < 0 || 100 < value)
                {
                    throw new Exception("理科の点数には0～100の数値を設定してください。");
                }
                this.science = value;
            }
        }

        /// <summary>
        /// プロパティ：社会の点数
        /// </summary>
        /// <exception cref="Exception">社会の点数に0未満または100より大きい値が設定された</exception>
        public int SocialStudies
        {
            get
            {
                return this.socialStudies;
            }
            set
            {
                if (value < 0 || 100 < value)
                {
                    throw new Exception("社会の点数には0～100の数値を設定してください。");
                }
                this.socialStudies = value;
            }
        }

        /// <summary>
        /// 平均点を計算する
        /// </summary>
        /// <returns>計算された平均点</returns>
        public override int CalcAverage()
        {
            return this.CalcTotal() / 5;
        }

        /// <summary>
        /// 合計点を計算する
        /// </summary>
        /// <returns>計算された合計点</returns>
        public override int CalcTotal()
        {
            return base.CalcTotal() + this.science + this.socialStudies;
        }

        /// <summary>
        /// 学生の成績評価を取得する
        /// </summary>
        /// <returns>成績評価（S／A／B／C／D／F）</returns>
        public override Evaluation GetEvaluation()
        {
            Evaluation evaluation = Evaluation.F;

            // 5教科の点数がそれぞれ60点以上であること
            if (60 <= this.japanese && 60 <= this.math && 60 <= this.english && 60 <= this.science && 60 <= this.socialStudies)
            {
                // 5教科の合計点で評価を決定する
                int total = this.CalcTotal();
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

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Student5() : base()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Student5(int studentNo, string studentName) : base(studentNo, studentName)
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Student5(int studentNo, string studentName, int japanese, int math, int english, int science, int socialStudies) : base(studentNo, studentName, japanese, math, english)
        {
            this.Science = science;
            this.SocialStudies = socialStudies;
        }
    }
}
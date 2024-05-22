using System;
using System.Linq.Expressions;

namespace OOP.Sample10
{
    /// <summary>
    /// 美術コースの成績クラス
    /// </summary>
    public class StudentArt : Student
    {
        /// <summary>
        /// 技術力
        /// </summary>
        protected int technical = 0;

        /// <summary>
        /// 創造性
        /// </summary>
        protected int creativity = 0;

        /// <summary>
        /// 表現力
        /// </summary>
        protected int expression = 0;

        /// <summary>
        /// プロパティ：技術力
        /// </summary>
        /// <exception cref="Exception">技術力に0未満または100より大きい値が設定された</exception>
        public int Technical
        {
            get
            {
                return this.technical;
            }
            set
            {
                if (value < 0 || 100 < value)
                {
                    throw new Exception("技術力には0～100の数値を設定してください。");
                }
                this.technical = value;
            }
        }

        /// <summary>
        /// プロパティ：創造性
        /// </summary>
        /// <exception cref="Exception">創造性に0未満または100より大きい値が設定された</exception>
        public int Creativity
        {
            get
            {
                return this.creativity;
            }
            set
            {
                if (value < 0 || 100 < value)
                {
                    throw new Exception("創造性には0～100の数値を設定してください。");
                }
                this.creativity = value;
            }

        }

        /// <summary>
        /// プロパティ：表現力
        /// </summary>
        /// <exception cref="Exception">表現力に0未満または100より大きい値が設定された</exception>
        public int Expression
        {
            get
            {
                return this.expression;
            }
            set
            {
                if (value < 0 || 100 < value)
                {
                    throw new Exception("表現力には0～100の数値を設定してください。");
                }
                this.expression = value;
            }
        }

        /// <summary>
        /// 合計点を計算する
        /// </summary>
        /// <returns>計算された合計点</returns>
        public override int CalcTotal()
        {
            return this.technical + this.creativity + this.expression;
        }

        /// <summary>
        /// 学生の成績評価を取得する
        /// </summary>
        /// <returns>成績評価（S／A／B／C／D／F）</returns>
        public override Evaluation GetEvaluation()
        {
            // ひとつでも0点があればF
            Evaluation evaluation = Evaluation.F;

            // 0点がなければC以上
            // （D評価はなし）
            if (0 < this.technical && 0 < this.creativity && 0 < this.expression)
            {
                evaluation = Evaluation.C;

                // どれかひとつでも95点以上があればS
                if (95 <= this.technical || 95 <= this.creativity || 95 <= this.expression)
                {
                    evaluation = Evaluation.S;
                }
                // どれかひとつでも85点以上があればA
                else if (85 <= this.technical || 85 <= this.creativity || 85 <= this.expression)
                {
                    evaluation = Evaluation.A;
                }
                // どれかひとつでも80点以上があればB
                else if (80 <= this.technical || 80 <= this.creativity || 80 <= this.expression)
                {
                    evaluation = Evaluation.B;
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
        public StudentArt() : base()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StudentArt(int studentNo, string studentName) : base(studentNo, studentName)
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public StudentArt(int studentNo, string studentName, int technical, int creativity, int expression) : base(studentNo, studentName)
        {
            this.Technical = technical;
            this.Creativity = creativity;
            this.Expression = expression;
        }
    }
}
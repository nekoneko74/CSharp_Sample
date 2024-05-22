using System;

namespace OOP.Sample08
{
    /// <summary>
    /// 国語／数学／英語の3教科対応版の学生／成績クラス（合計／平均の計算と成績評価）
    /// </summary>
    public class Student3
    {
        /// <summary>
        /// 学生番号
        /// </summary>
        protected int? studentNo = null;

        /// <summary>
        /// 学生氏名
        /// </summary>
        protected string studentName = null;

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
        /// プロパティ：学生番号
        /// </summary>
        /// <exception cref="Exception">学生番号にnullが設定された</exception>
        /// <exception cref="Exception">学生番号に1未満または999より大きい値が設定された</exception>
        public int? StudentNo
        {
            get
            {
                return this.studentNo;
            }
            set
            {
                if (null == value)
                {
                    throw new Exception("学生番号にnullを設定することはできません。");
                }
                else if (value < 1 || 999 < value)
                {
                    throw new Exception("学生番号には1～999までの値を設定してください。");
                }
                this.studentNo = value;
            }
        }

        /// <summary>
        /// プロパティ：学生氏名
        /// </summary>
        /// <exception cref="Exception">学生氏名にnullまたは空文字列が設定された</exception>
        public string StudentName
        {
            get
            {
                return this.studentName;
            }
            set
            {
                if (true == string.IsNullOrEmpty(value))
                {
                    throw new Exception("学生氏名にnullまたは空文字列を設定することはできません。");
                }
                this.studentName = value;
            }
        }

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
        /// 読み取り専用プロパティ：平均点
        /// </summary>
        public int Average
        {
            get
            {
                return this.CalcAverage();
            }
        }

        /// <summary>
        /// 読み取り専用プロパティ：合計点
        /// </summary>
        public int Total
        {
            get
            {
                return this.CalcTotal();
            }
        }

        /// <summary>
        /// 平均点を計算する
        /// </summary>
        /// <returns>計算された平均点</returns>
        public virtual int CalcAverage()
        {
            return this.CalcTotal() / 3;
        }

        /// <summary>
        /// 合計点を計算する
        /// </summary>
        /// <returns>計算された合計点</returns>
        public virtual int CalcTotal()
        {
            return this.japanese + this.math + this.english;
        }

        /// <summary>
        /// 学生の成績評価を取得する
        /// </summary>
        /// <returns>成績評価（S／A／B／C／D／F）</returns>
        public virtual Evaluation GetEvaluation()
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
        /// コンストラクタ
        /// </summary>
        public Student3()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Student3(int studentNo, string studentName) : this()
        {
            this.StudentNo = studentNo;
            this.StudentName = studentName;
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Student3(int studentNo, string studentName, int japanese, int math, int english) : this(studentNo, studentName)
        {
            this.Japanese = japanese;
            this.Math = math;
            this.English = english;
        }
    }
}
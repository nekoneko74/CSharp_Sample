using System;

namespace CSharp_Sample.Sample10
{
    /// <summary>
    /// 学生クラス（合計／平均の計算と成績評価は必ず行えるようにする）
    /// </summary>
    public abstract class Student
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
        public int CalcAverage()
        {
            return this.CalcTotal() / this.GetNumOfSubjects();
        }

        /// <summary>
        /// 合計点を計算する
        /// </summary>
        /// <returns>計算された合計点</returns>
        public abstract int CalcTotal();

        /// <summary>
        /// 学生の成績評価を取得する
        /// </summary>
        /// <returns>成績評価（S／A／B／C／D／F）</returns>
        public abstract Evaluation GetEvaluation();

        /// <summary>
        /// 平均点の計算に使用する科目数を取得する
        /// </summary>
        /// <returns>平均点の計算に使用する科目数</returns>
        public abstract int GetNumOfSubjects();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Student()
        {
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Student(int studentNo, string studentName) : this()
        {
            this.StudentNo = studentNo;
            this.StudentName = studentName;
        }
    }
}
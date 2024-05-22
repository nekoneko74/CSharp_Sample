using System;

namespace OOP.Sample06
{
    /// <summary>
    /// 国語／数学／英語の3教科対応版の学生／成績クラス
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
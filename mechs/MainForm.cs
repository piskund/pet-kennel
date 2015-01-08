using System;
using System.Windows.Forms;
using Mechs.BL.BusinessObjects;
using System.Globalization;
using System.Reflection;
using System.Diagnostics;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using Mechs.Common.Interfaces;

namespace Mechs
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Entry point
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        //public class B : A
        //{
        //    public B()
        //    {
        //    }
        //}

        public class A
        {
            public A inner;

            private A()
            {
            }

            public A(int n)
            {
                this.InVal = n;
                this.inner = new A();
                this.inner.InVal = n;
            }

            public event EventHandler myEvent;

            public int InVal { get; set; }

            //public static implicit operator A(int n)
            //{
            //    return new A(n);
            //}

            public static A operator +(A left, A right)
            {
                var result = new A(left.InVal + right.InVal);
                result.inner = new A(left.InVal + right.InVal);
                return result;
            }

            public override string ToString()
            {
                return string.Format("({0},{1})", this.InVal, this.inner.InVal);
            }
        }

        private void ShowTimeline()
        {
            lbDay.Text = TimeLine.Instance.Day.ToString();
            lbDOW.Text = TimeLine.Instance.DayOfWeek.ToString();
            lbWeek.Text = TimeLine.Instance.Week.ToString();
            lbMonth.Text = TimeLine.Instance.Month.ToString();
            lbDOY.Text = TimeLine.Instance.DayOfYear.ToString();
            lbYear.Text = TimeLine.Instance.Year.ToString();
        }

        private void btnEndOfTurn_Click(object sender, EventArgs e)
        {
            object temp1 = null;
            temp1 = new TestEntSer<IPlayer>();

            TestEntSer<IPlayer> temp2 = temp1 as TestEntSer<IPlayer>;
            IEntityService<IPlayer> temp4 = null;
            temp4 = temp2;
            var temp3 = temp2 as IEntityService<IPlayer>;

            temp4 = new TestEntSer<IPlayer>();

            //A a1 = new A(2);
            //A a2 = new A(5);

            //Debug.WriteLine(a1);
            //Debug.WriteLine(a2);
            //A b = new A(7);
            //a1.inner = b;
            //b.InVal = 10;
            //Debug.WriteLine(a1);
            //Debug.WriteLine(a2);

            //TimeLine.Instance.EndOfTurn();
            //this.ShowTimeline();
        }
    }
}
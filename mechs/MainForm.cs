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
            //TimeLine.Instance.EndOfTurn();
            //this.ShowTimeline();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Asg3_kxl180016
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        List<TimeSpan> enter = new List<TimeSpan>();
        List<TimeSpan> inter = new List<TimeSpan>();
        int backCount = 0, recordsNum;
        TimeSpan? minEntry, maxEntry, minInter, maxInter, total;
        TimeSpan aveEntry, aveInter;
        private void Analyze_Click(object sender, EventArgs e)
        {
            setInfo();
            tableLayout.Visible = true;
            recordsNumberDisplay.Text = recordsNum.ToString();
            MinRecordDisplay.Text = minEntry.ToString();
            MaxRecordDisplay.Text = maxEntry.ToString();
            AveRecordDisplay.Text = aveEntry.ToString(@"hh\:mm\:ss");
            MinInterDisplay.Text = minInter.ToString();
            MaxInterDisplay.Text = maxInter.ToString();
            AveInterDisplay.Text = aveInter.ToString(@"hh\:mm\:ss");
            TotalDisplay.Text = total.ToString();
            BackCountDisplay.Text = backCount.ToString();

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = new Size(800, 600);
        }
        private void Select_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Text files (*.txt)|*.txt";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                readFile(path);
            }
            Analyze.Enabled = true;
        }
        private void readFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            DateTime lastEnd = new DateTime();
            string str;
            string[] datas;
            while(sr.Peek() > -1)
            {
                str = sr.ReadLine();
                datas = str.Split(',');
                DateTime start = Convert.ToDateTime(datas[13]);
                DateTime end = Convert.ToDateTime(datas[14]);
                backCount += Int32.Parse(datas[15]);

                TimeSpan spend = end - start;
                enter.Add(spend);
                if(lastEnd != DateTime.MinValue)
                {
                    TimeSpan diff = start - lastEnd;
                    inter.Add(diff);
                }
                lastEnd = end;
            }
        }
        private void setInfo()
        {
            var sum = 0L;
            foreach(TimeSpan time in enter)
            {
                sum += time.Ticks;
                if(time < minEntry || !minEntry.HasValue)
                {
                    minEntry = time;
                }
                if(time > maxEntry || !maxEntry.HasValue)
                {
                    maxEntry = time;
                }
            }
            recordsNum = enter.Count;
            var ave = sum / recordsNum;
            aveEntry = new TimeSpan(ave);
            total = new TimeSpan(sum);
            sum = 0L;
            foreach(TimeSpan time in inter)
            {
                sum += time.Ticks;
                if (time < minInter || !minInter.HasValue)
                {
                    minInter = time;
                }
                if (time > maxInter || !maxInter.HasValue)
                {
                    maxInter = time;
                }
            }
            ave = sum / recordsNum;
            aveInter = new TimeSpan(ave);
        }
    }
}

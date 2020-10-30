using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiRunClient
{
    public partial class Form1 : Form
    {
        List<Process> runProcessList = new List<Process>();
        int screenWidth = 0;
        int screenHeight = 0;

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hwnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        
        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);


        public Form1()
        {
            InitializeComponent();
        }

        void ThreadRunProcess()
        {
            runProcessList.Clear();
            int width = Int32.Parse(tbWidth.Text);
            int height = Int32.Parse(tbHeight.Text);
            int curLeft = 0, curTop = 0;
            int waitTime = Int32.Parse(tbWaitTime.Text);
            int positionCount = Int32.Parse(tbPositionCount.Text);
            int count = Int32.Parse(tbRunCount.Text);
            for (int i = 0; i < count; i++)
            {
                Process proc = Process.Start(tbProcessName.Text);
                runProcessList.Add(proc);
                Thread.Sleep(waitTime);
                bool isMove = MoveWindow(proc.MainWindowHandle, curLeft, curTop, width, height, false);
                Console.WriteLine("{0}-{1}-{2}", curLeft, curTop, isMove);
                int moveCnt = 0;
                while (isMove == false && moveCnt < positionCount)
                {
                    Thread.Sleep(waitTime);
                    isMove = MoveWindow(proc.MainWindowHandle, curLeft, curTop, width, height, false);
                    Console.WriteLine("{0}-{1}-{2}", curLeft, curTop, isMove);
                    moveCnt++;
                }
                curLeft += width;
                if ((curLeft + width) > (screenWidth + 10))
                {
                    curLeft = 0;
                    curTop += height;
                }
            }
        }

        private void btnRunProcesses_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Thread t = new Thread(new ThreadStart(ThreadRunProcess));
            t.Start();            
        }

        void ThreadEndProcess()
        {
            bool isException = false;
            foreach (var proc in runProcessList)
            {
                try
                {
                    proc.Kill();
                    Thread.Sleep(100);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    isException = true;
                }
            }

            Process[] procs = Process.GetProcessesByName(tbFindWindow.Text);
            if (procs.Length > 0)
            {
                foreach (var proc in procs)
                {
                    proc.Kill();
                    Thread.Sleep(100);
                }
            }
        }

        private void btnEndProcesses_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Thread t = new Thread(new ThreadStart(ThreadEndProcess));
            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace PC_Kontrol
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            _ramCounter = new PerformanceCounter("Memory", "Available Bytes");
            _timer = new Timer { Interval = 1000 };
            _timer.Tick += Timer_Tick;

            _dataTable = new DataTable();
            _dataTable.Columns.Add("Time", typeof(DateTime));
            _dataTable.Columns.Add("Value", typeof(long));

            chart1.DataSource = _dataTable;

        }
        private PerformanceCounter _ramCounter;
        private Timer _timer;
        private DataTable _dataTable;

        private void Timer_Tick(object sender, EventArgs e)
        {
            long value = (long)(_ramCounter.NextValue() / 1024);
            _dataTable.Rows.Add(DateTime.Now, value);

            if (_dataTable.Rows.Count > 60)
                _dataTable.Rows.RemoveAt(0);

            chart1.DataBind();
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _timer.Start();
        }
    }
}

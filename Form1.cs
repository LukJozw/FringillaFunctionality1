using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FringillaFunctionality1
{
    public partial class Form1 : Form
    {
        public List<Sample> Samples { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "TXT files |*.txt";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] fileNames = openFileDialog.FileNames;
                FringillaFunctionality1.Properties.Settings.Default.workDirectory = Path.GetDirectoryName(openFileDialog.FileName) + @"\";
                
                Samples = GetSamples(fileNames);
                dataGridView.DataSource = Samples;
                dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }      
        }
        private List<Sample> GetSamples(string[] fileNames)
        {
            var list = new List<Sample>();
            int index = 1;

            foreach(string fileName in fileNames)
            {
                string[] data = GetDataFromFile(fileName);

                list.Add(new Sample()
                {
                    SampleNo = index,
                    FileName = data[0],
                    AvgDistBckg = (float)Math.Round(double.Parse(data[1]),1),
                    AvgDistFilm = (float)Math.Round(double.Parse(data[2]), 1),
                    ZeroShift = (float)Math.Round(double.Parse(data[3]), 1),
                    NNumber = int.Parse(data[4]),
                    Lambda = int.Parse(data[5]),
                    Thickness = (float)Math.Round(double.Parse(data[6]), 1),
                });
                index++;
            }

            return list;
        }
        private string[] GetDataFromFile(string fileName)
        {
            string content = File.ReadAllText(fileName);

            string[] ans = { "stringFileName", "floatAvgDistBckg", "floatAvgDistFilm",
                "floatZeroShift", "intNNumber", "intLambda", "floatThickness" };

            string[] keyTable = { "Target: ", " Bckg - " , " Film - " , "0 order shift: " , "n - " , "Lambda - " , "Thickness: " }; 
                    
                    //, " Bckg - " , " Film - " , "0 order shift: " , " n - " , " Lambda - " , "Thickness: "};

            foreach(var key in keyTable.Select((value, i) => new { i, value }))
            {
                int findInd = content.IndexOf(key.value);
                int keyInd = key.i;

                string buffer = (findInd < 0)
                ? content
                : content.Remove(0, (findInd + key.value.Length));

                int j = 0;

                ans[key.i] = "";

                while(buffer[j] != ' ' && buffer[j] != '\n')
                {
                    ans[keyInd] += buffer[j];
                    j++;
                }
                
            }

            return ans;
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if(dataGridView.Rows.Count >0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for(int i = 1; i < dataGridView.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                }

                for(int i = 0; i < dataGridView.Rows.Count; i++)
                {

                    for(int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;            //.ToString();
                    }
                    xcelApp.Columns.AutoFit();
                    xcelApp.Visible = true;
                }
            }
        }
    }
}

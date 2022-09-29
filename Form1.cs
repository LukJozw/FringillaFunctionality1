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
                checkedListBox.Enabled = true;
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
                    AvgDistBckg = float.Parse(data[1]),
                    AvgDistFilm = float.Parse(data[2]),
                    ZeroShift = float.Parse(data[3]),
                    NNumber = int.Parse(data[4]),
                    Lambda = int.Parse(data[5]),
                    Thickness = float.Parse(data[6])
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
        //private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    foreach(object itemChecked in checkedListBox.CheckedItems)
        //    {
        //        for(int i = 0; i < dataGridView.RowCount; i++)
        //        {
        //            string fileName = FringillaFunctionality1.Properties.Settings.Default.workDirectory + @"\" +
        //                dataGridView.Rows[i].Cells[0].Value.ToString();
        //            string[] items = Program.ExtractUsefullData(fileName);

        //            // delete all collums from 1 to the end
        //            for(int j = 1; j < dataGridView.ColumnCount;j++)
        //            {
        //                dataGridView.Columns.RemoveAt(j);
        //            }
        //            ///

        //            if(checkedListBox.Items.IndexOf(itemChecked) == 0)      // avgDistBckg
        //            {
        //                dataGridView.Columns.Add("avgDistBckg", "avg. dist. Backgd");
        //            }

        //            if (checkedListBox.Items.IndexOf(itemChecked) == 1)     // avgDistFilm
        //            {
        //                dataGridView.Columns.Add("avgDistFilm", "avg. dist. Film");
        //            }

        //            if (checkedListBox.Items.IndexOf(itemChecked) == 2)     // 0shift
        //            {
        //                dataGridView.Columns.Add("0shift", "0-order shift");
        //            }

        //            if (checkedListBox.Items.IndexOf(itemChecked) == 3)     // n
        //            {
        //                dataGridView.Columns.Add("n", "n");
        //            }

        //            if (checkedListBox.Items.IndexOf(itemChecked) == 4)     // lambda
        //            {
        //                dataGridView.Columns.Add("lambda", "lambda");
        //            }

        //            if (checkedListBox.Items.IndexOf(itemChecked) == 5)     // thickness
        //            {
        //                dataGridView.Columns.Add("thickness", "thickness");
        //            }



        //        }

                //Use the IndexOf method to get the index of an item
                //MessageBox.Show("Item with title: \"" + itemChecked.ToString() +
                //    "\", is checked. Checked state is: " +
                //    checkedListBox.GetItemCheckState(checkedListBox.Items.IndexOf(itemChecked)).ToString() + ".");
        //    }
        //}
    }
}

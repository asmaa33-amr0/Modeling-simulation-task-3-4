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
using InventoryModels;
using InventoryTesting;

namespace InventorySimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem simulationSystem = new SimulationSystem();
        private string file_name;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void read_test_file(string fullPath)
        {
            decimal cumulative = 0, cumu1 = 0;

            List<string> testing_lines = File.ReadAllLines(fullPath).ToList();

            simulationSystem.OrderUpTo = int.Parse(testing_lines[1]);
            simulationSystem.ReviewPeriod = int.Parse(testing_lines[4]);
            simulationSystem.StartInventoryQuantity = int.Parse(testing_lines[7]);
            simulationSystem.StartLeadDays = int.Parse(testing_lines[10]);
            simulationSystem.StartOrderQuantity = int.Parse(testing_lines[13]);
            simulationSystem.NumberOfDays = int.Parse(testing_lines[16]);
            char[] sep = { ' ', ',' };

            int line = 19;

            // Use a for loop for demand and lead time distributions
            for (int row_demand = 0; row_demand < 5; row_demand++)
            {
                Distribution dist = new Distribution();
                string[] demand = testing_lines[line].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                dist.Generatedemand(decimal.Parse(demand[1]), cumulative, int.Parse(demand[0]));
                simulationSystem.DemandDistribution.Add(dist);
                cumulative += decimal.Parse(demand[1]);
                line++;
            }

            line = 26;

            for (int row_delay = 0; row_delay < 3; row_delay++)
            {
                Distribution dist1 = new Distribution();
                string[] test_leadtimedistributions = testing_lines[line].Split(sep, StringSplitOptions.RemoveEmptyEntries);
                dist1.Generateleadtime(decimal.Parse(test_leadtimedistributions[1]), cumu1, int.Parse(test_leadtimedistributions[0]));
                cumu1 += decimal.Parse(test_leadtimedistributions[1]);
                simulationSystem.LeadDaysDistribution.Add(dist1);
                line++;
            }
        }
        public void ClearSimulation()
        {
            simulationSystem.SimulationTable.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearSimulation();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult fileResult = openFileDialog.ShowDialog();
            if (fileResult == DialogResult.OK)
            {
                file_name = openFileDialog.FileName;
                string temp = Path.GetFileName(file_name);
                textBox1.Text = temp;
                textBox1.ReadOnly = true;
                this.read_test_file(file_name);
            }
        }
        public void getdata(SimulationSystem s)
        {
            simulationSystem = s;
        }
        //run button------
        private void button2_Click(object sender, EventArgs e)
        {
            
            simulationSystem.Simulation_table();
            
            display_table(simulationSystem.SimulationTable);
            //fill text boxes (performance measures)
            textBox8.Text = simulationSystem.PerformanceMeasures.demandAverage.ToString();
            textBox8.ReadOnly = true;
            textBox2.Text = simulationSystem.PerformanceMeasures.ShortageQuantityAverage.ToString();
            textBox2.ReadOnly = true;
            textBox3.Text = simulationSystem.PerformanceMeasures.EndingInventoryAverage.ToString();
            textBox3.ReadOnly = true;



        }

        private void Testing_Click(object sender, EventArgs e)
        {
            //Don't forget to change the test case number
            string t = TestingManager.Test(simulationSystem, test_case_name());
            MessageBox.Show(t);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

            
        public void display_table(List<SimulationCase> row)
        {


            dataGridView1.Rows.Clear();
            foreach (var item in row)
                dataGridView1.Rows.Add(item.Day, item.Cycle, item.DayWithinCycle, item.BeginningInventory,
                    item.RandomDemand, item.Demand, item.EndingInventory, item.ShortageQuantity, 
                    item.OrderQuantity,item.RandomLeadDays, item.LeadDays,item.daysuntilorderarrives);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 8 || e.ColumnIndex == 9 || e.ColumnIndex == 10 || e.ColumnIndex == 11)
                && e.Value != null && (int)e.Value <= 0)
            {
                e.Value = "---";
                e.FormattingApplied = true;
            }
        }
        public string test_case_name()
        {
            return textBox1.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    }
 

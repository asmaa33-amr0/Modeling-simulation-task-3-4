using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace InventoryModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }

        ///////////// INPUTS /////////////

        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }



        ///////////// OUTPUTS /////////////

        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

        
        public int calc_demand(int random_demand)
        {
            int res = 0;
            for (int i = 0; i < this.DemandDistribution.Count; i++)
            {
                if (random_demand <= this.DemandDistribution[i].MaxRange
                    && random_demand >= this.DemandDistribution[i].MinRange)
                {
                    res = this.DemandDistribution[i].Value;
                    break;
                }
            }
            return res;
        }
        public int calc_leadtime(int random_leadtime)
        {
            int res = 0;
            for (int i = 0; i < this.LeadDaysDistribution.Count; i++)
            {
                if (random_leadtime <= this.LeadDaysDistribution[i].MaxRange
                    && random_leadtime >= this.LeadDaysDistribution[i].MinRange)
                {
                    res = this.LeadDaysDistribution[i].Value;
                    break;
                }
            }
            return res;
        }
        
        public void Simulation_table()
        {
            int day;
            Random random = new Random();
            float sum_endinventory = 0.0f;
            float sum_shortagequantity = 0.0f;
            float sum_demand = 0.0f;
            int cycle = 1,ending=0,shortage=0,order=0,arrival=this.StartLeadDays-1;
            for (int i = 0; i < this.NumberOfDays; i++)
            {
                SimulationCase simulationrow = new SimulationCase();
                day = i + 1;
                simulationrow.Cycle = cycle;
                simulationrow.Day = day;
                 if (arrival == -1)
                {
                    simulationrow.BeginningInventory=order+ending;
                     
                }
                else if (simulationrow.Day==1)
                {
                    simulationrow.BeginningInventory = this.StartInventoryQuantity;

                }
                else
                {
                    simulationrow.BeginningInventory = ending;
                }

                int randomdemand = random.Next(1, 101);
                simulationrow.RandomDemand = randomdemand;
                simulationrow.Demand = calc_demand(randomdemand);


                if (simulationrow.Demand +shortage>  simulationrow.BeginningInventory)
                {
                    simulationrow.EndingInventory = 0;
                    ending = simulationrow.EndingInventory;

                    shortage  += simulationrow.Demand - simulationrow.BeginningInventory;
                    simulationrow.ShortageQuantity = shortage;

                }
                else
                {
                    simulationrow.EndingInventory = simulationrow.BeginningInventory - simulationrow.Demand-shortage;
                    ending = simulationrow.EndingInventory;
                    simulationrow.ShortageQuantity = 0;
                    shortage = simulationrow.ShortageQuantity;
                }
                
                if (day % this.ReviewPeriod == 0)
                {
                    cycle++;
                    simulationrow.DayWithinCycle = this.ReviewPeriod;
                    simulationrow.OrderQuantity = this.OrderUpTo - simulationrow.EndingInventory+simulationrow.ShortageQuantity;
                    order = simulationrow.OrderQuantity;
                    int randomleadday = random.Next(1, 101);
                    simulationrow.RandomLeadDays = randomleadday;
                    simulationrow.LeadDays = calc_leadtime(randomleadday);
                    arrival = simulationrow.LeadDays;


                    simulationrow.daysuntilorderarrives = simulationrow.LeadDays;
                }                
                else
                {
                    simulationrow.DayWithinCycle=day%this.ReviewPeriod;
                    simulationrow.OrderQuantity = 0;
                     
                }
                simulationrow.daysuntilorderarrives = arrival;
                if (i == 1)
                {
                    order = this.StartOrderQuantity;
                }
               
                sum_endinventory += simulationrow.EndingInventory;
                sum_shortagequantity += simulationrow.ShortageQuantity;
                sum_demand += simulationrow.Demand;


                this.SimulationTable.Add(simulationrow);
                arrival--;

            }
            this.PerformanceMeasures.demandAverage= Convert.ToDecimal(sum_demand / this.NumberOfDays);
            this.PerformanceMeasures.ShortageQuantityAverage = Convert.ToDecimal( sum_shortagequantity / this.NumberOfDays);
            this.PerformanceMeasures.EndingInventoryAverage = Convert.ToDecimal(sum_endinventory / this.NumberOfDays);
        } 

    }
}

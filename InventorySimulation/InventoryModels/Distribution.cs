using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class Distribution
    {
        public Distribution()
        {

        }
        public void Generatedemand(decimal prob,decimal cumulativeprob,int demand) {
            if (prob != 0) { 
                this.Probability = prob;
                this.CummProbability = cumulativeprob+prob;
                this.MinRange =(int) (cumulativeprob * 100)+1;
                this.MaxRange = (int)(CummProbability * 100);
                this.Value=demand;

            }

        }
        public void Generateleadtime(decimal prob, decimal cumulativeprob, int leadtime)
        {
            if (prob != 0)
            {
                this.Probability = prob;
                this.CummProbability = cumulativeprob + prob;
                this.MinRange = (int)(cumulativeprob * 100) + 1;
                this.MaxRange = (int)(CummProbability * 100);
                this.Value=leadtime;

            }

        }
        
        public int Value { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepByStep
{
    class Score
    {
        public int StudentCode { get; set; }
        public string SubjetName { get; set; }
        private int scoreValue;

        public int ScoreValue
        {
            get { return this.scoreValue; }
            set
            {
                if (value < 0)
                    scoreValue = 0;
                else if (value > 100)
                    this.scoreValue = 100;
                else
                    this.scoreValue = value;
            }
        }

    }
}

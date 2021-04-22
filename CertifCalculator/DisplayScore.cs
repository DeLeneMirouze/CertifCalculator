using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CertifCalculator
{
    class DisplayScore
    {
        public string Notes { get; set; }
        public State TestState { get; set; } = new State();
        public State ScoreState { get; set; } = new State();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuantumCircuitAPI.Models
{
    public class QCircuitScaffold
    {
        public int Nqubits {get; set;}
        public int NtimeSteps {get; set;}
        public bool[] MeasureArray {get; set;}
        public long[][] GateMatrix {get; set;}
        public long[][] CNotMatrix {get; set;}
    }
}
//QSharp wants longs and not ints, I figured it's best to just use longs here
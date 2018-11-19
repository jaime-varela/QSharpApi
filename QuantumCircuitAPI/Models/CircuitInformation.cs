using System;
using System.Collections.Generic;

namespace QuantumCircuitAPI.Models
{
    public class CircuitInformation
    {
        public string Information;
        
        public Dictionary<int,string> conversions;

        public CircuitInformation(){
            Information = "This api runs a quantum circuit where measurments are performed at the end.  To set the elementary gates or the CNot gates you must provide two matrices.  Specifically the gateMatrix and CNotMatrix.  The values in the CNotMatrix are either zero or greater than one.  A non-zero value in the cNotMatrix represents how far down (hop) to the target qubit will be applied.  The control qubit is the top qubit. The values of the elementary gate are represented by the conversions shown below.  A negative integer represents the dagger of the corresponding positive integer. To see a circuit example of a Hadamard gate followed by a CnotGate run /api/Quantum/SeeExampleCircuit in the api.";
            conversions = new Dictionary<int, string>(){
                {0,"No action to the qubit at the timestep"},
                {1,"X"},
                {2,"Y"},
                {3,"Z"},
                {4,"H"},
                {5,"S"},
                {6,"T"}
            };
        }
    }
}

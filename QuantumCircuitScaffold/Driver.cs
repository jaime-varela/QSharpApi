using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace QuantumCircuitScaffold
{
    class Driver
    {
        static void Main(string[] args)
        {
            // entanglement check
            var timeSteps = 2;
            var Nqubits = 2;
            var elementaryGate = new long[Nqubits][];
            elementaryGate[0] = new long[timeSteps];
            elementaryGate[1] = new long[timeSteps];
            elementaryGate[0][0] = 4;


            var cNotgates = new long[Nqubits][];
            cNotgates[0] = new long[timeSteps];
            cNotgates[1] = new long[timeSteps];
            cNotgates[0][1] = 1;
            //var consistencyCheck = CheckCircuitConsistency.IsConsistent(elementaryGate,cNotgates,Nqubits,timeSteps);
            //Console.WriteLine("It's {0} that the circuit is consistent",consistencyCheck);

            //You must send in a QArray<bool> whose size is the same as the number of qubits in the system
            //if the ith entry of the QArray is true, it will be measured, otherwise it will not.
            var qmeasures = new QArray<bool> {true,true};
            QArray<bool> resultArr;
            using(var sim = new QuantumSimulator())
            {
                resultArr = RunCircuit.Run(sim,MatrixToQarray<long>.Converter(elementaryGate,Nqubits,timeSteps),
                                        MatrixToQarray<long>.Converter(cNotgates,Nqubits,timeSteps),qmeasures,Nqubits,timeSteps).GetAwaiter().GetResult();
            }

            foreach (var item in resultArr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
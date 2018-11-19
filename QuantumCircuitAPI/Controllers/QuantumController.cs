using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

using QuantumCircuitAPI.Models;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using QuantumCircuitScaffold;


namespace MySiteAngular.Controllers
{
    [Route("api/[controller]")]
    public class QuantumController : Controller
    {
        //api/Quantum/SeeMyMatrix
        [HttpGet("[action]")]
        public async Task<ActionResult<QCircuitScaffold>> SeeExampleCircuit()
        {
            //QCircuitScaffold
            var result = new QCircuitScaffold();
            var Nqubits = 2;
            var timeSteps = 2;
            //initialize the matrices
            result.Nqubits = Nqubits;
            result.NtimeSteps = timeSteps;            
            var elementaryGate = new long[Nqubits][];
            elementaryGate[0] = new long[timeSteps];
            elementaryGate[1] = new long[timeSteps];
            elementaryGate[0][0] = 4;


            var cNotgates = new long[Nqubits][];
            cNotgates[0] = new long[timeSteps];
            cNotgates[1] = new long[timeSteps];
            cNotgates[0][1] = 1;

            result.CNotMatrix = cNotgates;
            result.GateMatrix = elementaryGate;
            result.MeasureArray = new bool[] {true,true};
            return result;
        }

        //api/Quantum/CalculateCircuit
        [HttpPost("[action]")]
        public async Task<ActionResult< List<int> > > CalculateCircuit([FromBody] QCircuitScaffold circuit)
        {
            //You must send in a QArray<bool> whose size is the same as the number of qubits in the system
            //if the ith entry of the QArray is true, it will be measured, otherwise it will not.
            var qmeasures = new QArray<bool>(circuit.MeasureArray);
            var Nqubits = circuit.Nqubits;
            var timeSteps = circuit.NtimeSteps;
            var elementaryGate = circuit.GateMatrix;
            var cNotgates = circuit.CNotMatrix;
            //var qmeasures = new QArray<bool> {true,true};
            QArray<bool> resultArr;


            // consistency check
            var consistencyCheck = CheckCircuitConsistency.IsConsistent(elementaryGate,cNotgates,Nqubits,timeSteps);
            if(!consistencyCheck){
                return BadRequest("Invalid Circuit");
            }

            using(var sim = new QuantumSimulator())
            {
                resultArr = await RunCircuit.Run(sim,MatrixToQarray<long>.Converter(elementaryGate,Nqubits,timeSteps),
                                        MatrixToQarray<long>.Converter(cNotgates,Nqubits,timeSteps),qmeasures,Nqubits,timeSteps);
                var result = new List<int>();
                foreach (var item in resultArr)
                {
                    if(item)
                        result.Add(1);
                    else
                        result.Add(0);
                }
                return result;
            }
        }

        //api/Quantum/CircuitNotation
        [HttpGet("[action]")]
        public async Task<ActionResult<CircuitInformation> > CircuitNotation()
        {
            return await Task.Run(() => new CircuitInformation());
        }
    }
}
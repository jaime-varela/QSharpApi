# Overview

This api runs a quantum circuit where measurments are performed at the end.  To set the elementary gates or CNot gates you must provide two matrices.  Specifically the gateMatrix and CNotMatrix.  The values in the CNotMatrix are either zero or greater than one.  A non-zero value in the cNotMatrix represents how far down (hop) to the target qubit will be applied.  The control qubit is the top qubit.  A negative integer represents the dagger of the correspondipositive integer. 

To see a circuit example of a Hadamard gate followed by a CnotGate run '/api/Quantum/SeeExampleCircuit` in the api.  To see the conversion run `/api/Quantum/CircuitNotation`. Swagger has also been implemented in this api.

An example circuit is:
```
{
  "nqubits": 2,
  "ntimeSteps": 2,
  "measureArray": [true,true],
  "gateMatrix": [
      [4,0],
      [0,0]
  ],
  "cNotMatrix": [
    [0,1],
    [0,0]
  ]
}
```
Where the Hadammard gate is applied at the first time step and a CNot gate at the second.  The gate conversions are:
```
"conversions": {
    "0": "No action to the qubit at the timestep",
    "1": "X",
    "2": "Y",
    "3": "Z",
    "4": "H",
    "5": "S",
    "6": "T"
  }
```

And the negative values are the daggers of the corresponding operation.

### measureArray and Output of api/CalculateCircuit

There is a one-to-one correspondence to the gate-matrix qubits and the measure array.  For example
```
measureArray = [true,true,false]
```
states that the 0th and 1st qubit (topmost and middle) are measured while the last qubit (bottom) is not 
measured.

Given a correct quantum circuit in the POST body the result of `api/CalculateCircuit` is a integer
array whose values are either zero or one.  The values of the array are the result of the qubit array measurements.  For example if the measureArray is as described above, one would get a result of the form
```
[0,1]
```
which states that the top qubit measured 0 and the middle qubit measured 1.

## Installation

cloning the source and running:
```
cd QSharpApi/QuantumCircuitAPI && dotnet run
```
should work if you have the latest dotnet sdk version.  Alternatively you can run the API in a docker container.  A docker file is provided.  For a basic run one can run the application using the following commands (assuming docker is installed):
```
sudo docker build -t aspnetapp .

sudo docker run -p 80:80 --name myapp aspnetapp
```
Remove "sudo" if not on linux.

### Next steps

I'm looking to add more functionality in the API.  If you have any suggestions, please let me know.
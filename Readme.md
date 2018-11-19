This api runs a quantum circuit where measurments are performed at the end.  To set the elementary gates or CNot gates you must provide two matrices.  Specifically the gateMatrix and CNotMatrix.  The values in tCNotMatrix are either zero or greater than one.  A non-zero value in the cNotMatrix represents how far down (hop) to the target qubit will be applied.  The control qubit is the top qubit. The values of the elementary gate arepresented by the conversions shown below.  A negative integer represents the dagger of the correspondipositive integer. To see a circuit example of a Hadamard gate followed by a CnotGate run /api/Quantum/SeeExampleCircuin the api.  To see the conversion run /api/Quantum/CircuitNotation.

Swagger has also been implemented in this api.
namespace QuantumCircuitScaffold
{
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Diagnostics;


/// A simple general circuit runner with a restricted set of elementary gates and CNOT gates.  The intended circuit size is small and intended for GUIS

    operation GateSwitchCase(classifier : Int, qubit : Qubit) : ()
    {
        //TODO: store an array of operators and return based on index (instead of this if-elif procedure)
        body
        {
            if(classifier == 1)
            {
                X(qubit);
            }
            elif(classifier == 2)
            {
                Y(qubit);
            }
            elif(classifier == 3)
            {
                Z(qubit);
            }
            elif(classifier == 4)
            {
                H(qubit);
            }
            elif(classifier == 5)
            {
                S(qubit);
            }
            elif(classifier == 6)
            {
                T(qubit);
            }
            elif(classifier == -1)
            {
                (Adjoint X)(qubit);
            }
            elif(classifier == -2)
            {
                (Adjoint Y)(qubit);
            }
            elif(classifier == -3)
            {
                (Adjoint Z)(qubit);
            }
            elif(classifier == -4)
            {
                (Adjoint H)(qubit);
            }
            elif(classifier == -5)
            {
                (Adjoint S)(qubit);
            }
            elif(classifier == -6)
            {
                (Adjoint T)(qubit);
            }

        }
    }

    function GetElementaryGate(classifier : Int) : (Qubit => ())
    {
        return GateSwitchCase(classifier, _);
    }


    operation RunCircuit(elementaryGates : Int[][], CNOTGATES:  Int[][] , isQubitMeasured : Bool[], Nqubits : Int, Ntimes : Int) : Bool[]
    {
        body
        {
            mutable measurecount = 0;
            for(idc in 0..(Nqubits-1))
            {
                if(isQubitMeasured[idc])
                {
                    set measurecount = measurecount + 1;
                }
            }
            mutable resultArray = new Result[measurecount];
            using(qubits=Qubit[Nqubits])
            {
                for(idt in 0..(Ntimes-1))
                {
                    for(idq in 0..(Nqubits-1))
                    {
                        let GateClassifier = elementaryGates[idq][idt];
                        let cNotClassifier = CNOTGATES[idq][idt];
                        if(GateClassifier != 0)
                        {
                            (GetElementaryGate(GateClassifier))(qubits[idq]);
                        }

                        if(GateClassifier == 0 && cNotClassifier != 0)
                        {
                            CNOT(qubits[idq],qubits[idq + cNotClassifier]);
                        }
                    }
                }
                set measurecount = 0;
                for (idx in 0..(Nqubits-1)) 
                {
                    if(isQubitMeasured[idx])
                    {
                        set resultArray[measurecount] = MResetZ(qubits[idx]);
                        set measurecount = measurecount + 1;
                    }
                }
                //DumpMachine("");
                ResetAll(qubits);

            }            
            return BoolArrFromResultArr(resultArray);
        }
    }
}
//Currently we aren't using sparse data structures to store the circuit information (which would make more sent).  The reason
//is that this is intended for a UI application where the circuit matrices are not expected to be large.  Future implementations
//should use sparse methods.
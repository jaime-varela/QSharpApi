namespace QuantumCircuitScaffold
{
    public static class CheckCircuitConsistency
    {
        //number of elementary gate types that the program supports
        private static readonly int NumGates = 6;
        
        ///<description> checks wether the circuit is consistent , i.e. cnot gates and elementary gates dont overlap.  It also checks
        /// if the cnot parameters stay within bounds.
        public static bool IsConsistent(long[][] elementaryGates,long[][] cNotGates, int Nqubits, int Ntimes)
        {
            bool isValid = true;
            
            for (int itime = 0; itime < Ntimes; itime++)
            {
                if(!isValid)
                    break;

                for (int indqubit = 0; indqubit < Nqubits; indqubit++)
                {
                    if(!isValid)
                        break;
                    long elemGate = 0;
                    long cNotHop = 0;
                    try
                    {
                        elemGate = elementaryGates[indqubit][itime];
                        cNotHop = cNotGates[indqubit][itime];                        
                    }
                    catch (System.Exception e)
                    {
                        isValid = false;
                    }

                    elemGate *= (elemGate<0)? -1 : 1;
                    if(elemGate > NumGates)
                        isValid = false;
                    if(cNotHop < 0 || cNotHop + indqubit > Nqubits)
                        isValid = false; //maybe allow negative numbers for reverse cNots?
                    //the cNots and gates can't overlap in the same location
                    if((elemGate > 0) && (cNotHop > 0))
                        isValid = false;
                    //checks if the cNot target has no gate
                    if(cNotHop > 0)
                    {
                        try
                        {
                            var gateAtTarget = elementaryGates[indqubit+cNotHop][itime];
                            isValid = (gateAtTarget == 0);
                        }
                        catch (System.Exception e)
                        {
                            isValid = false;
                        }
                    }                     

                }
            }
            return isValid;
        }
    }
}

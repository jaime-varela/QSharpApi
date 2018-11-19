#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("QuantumCircuitScaffold", "GateSwitchCase (classifier : Int, qubit : Qubit) : ()", new string[] { }, "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs", 394L, 11L, 5L)]
[assembly: OperationDeclaration("QuantumCircuitScaffold", "RunCircuit (elementaryGates : Int[][], CNOTGATES : Int[][], isQubitMeasured : Bool[], Nqubits : Int, Ntimes : Int) : Bool[]", new string[] { }, "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs", 1993L, 74L, 5L)]
[assembly: FunctionDeclaration("QuantumCircuitScaffold", "GetElementaryGate (classifier : Int) : (Qubit => ())", new string[] { }, "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs", 1732L, 67L, 14L)]
#line hidden
namespace QuantumCircuitScaffold
{
    public class GateSwitchCase : Operation<(Int64,Qubit), QVoid>, ICallable
    {
        public GateSwitchCase(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Qubit)>, IApplyData
        {
            public In((Int64,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "GateSwitchCase";
        String ICallable.FullName => "QuantumCircuitScaffold.GateSwitchCase";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveS
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveY
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get;
            set;
        }

        public override Func<(Int64,Qubit), QVoid> Body => (__in) =>
        {
            var (classifier,qubit) = __in;
#line 15 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
            if ((classifier == 1L))
            {
#line 17 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveX.Apply(qubit);
            }
            else if ((classifier == 2L))
            {
#line 21 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveY.Apply(qubit);
            }
            else if ((classifier == 3L))
            {
#line 25 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveZ.Apply(qubit);
            }
            else if ((classifier == 4L))
            {
#line 29 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveH.Apply(qubit);
            }
            else if ((classifier == 5L))
            {
#line 33 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveS.Apply(qubit);
            }
            else if ((classifier == 6L))
            {
#line 37 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveT.Apply(qubit);
            }
            else if ((classifier == -(1L)))
            {
#line 41 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveX.Adjoint.Apply(qubit);
            }
            else if ((classifier == -(2L)))
            {
#line 45 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveY.Adjoint.Apply(qubit);
            }
            else if ((classifier == -(3L)))
            {
#line 49 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveZ.Adjoint.Apply(qubit);
            }
            else if ((classifier == -(4L)))
            {
#line 53 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveH.Adjoint.Apply(qubit);
            }
            else if ((classifier == -(5L)))
            {
#line 57 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveS.Adjoint.Apply(qubit);
            }
            else if ((classifier == -(6L)))
            {
#line 61 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                MicrosoftQuantumPrimitiveT.Adjoint.Apply(qubit);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumPrimitiveS = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.S));
            this.MicrosoftQuantumPrimitiveT = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.T));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.MicrosoftQuantumPrimitiveY = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Y));
            this.MicrosoftQuantumPrimitiveZ = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.Z));
        }

        public override IApplyData __dataIn((Int64,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 classifier, Qubit qubit)
        {
            return __m__.Run<GateSwitchCase, (Int64,Qubit), QVoid>((classifier, qubit));
        }
    }

    public class GetElementaryGate : Operation<Int64, ICallable>, ICallable
    {
        public GetElementaryGate(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GetElementaryGate";
        String ICallable.FullName => "QuantumCircuitScaffold.GetElementaryGate";
        protected ICallable<(Int64,Qubit), QVoid> GateSwitchCase
        {
            get;
            set;
        }

        public override Func<Int64, ICallable> Body => (__in) =>
        {
            var classifier = __in;
#line 69 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
            return GateSwitchCase.Partial(new Func<Qubit, (Int64,Qubit)>((_arg1) => (classifier, _arg1)));
        }

        ;
        public override void Init()
        {
            this.GateSwitchCase = this.Factory.Get<ICallable<(Int64,Qubit), QVoid>>(typeof(QuantumCircuitScaffold.GateSwitchCase));
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(ICallable data) => new QTuple<ICallable>(data);
        public static System.Threading.Tasks.Task<ICallable> Run(IOperationFactory __m__, Int64 classifier)
        {
            return __m__.Run<GetElementaryGate, Int64, ICallable>(classifier);
        }
    }

    public class RunCircuit : Operation<(QArray<QArray<Int64>>,QArray<QArray<Int64>>,QArray<Boolean>,Int64,Int64), QArray<Boolean>>, ICallable
    {
        public RunCircuit(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<QArray<Int64>>,QArray<QArray<Int64>>,QArray<Boolean>,Int64,Int64)>, IApplyData
        {
            public In((QArray<QArray<Int64>>,QArray<QArray<Int64>>,QArray<Boolean>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "RunCircuit";
        String ICallable.FullName => "QuantumCircuitScaffold.RunCircuit";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<QArray<Result>, QArray<Boolean>> MicrosoftQuantumCanonBoolArrFromResultArr
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get;
            set;
        }

        protected ICallable<Int64, ICallable> GetElementaryGate
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> MicrosoftQuantumCanonMResetZ
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        public override Func<(QArray<QArray<Int64>>,QArray<QArray<Int64>>,QArray<Boolean>,Int64,Int64), QArray<Boolean>> Body => (__in) =>
        {
            var (elementaryGates,CNOTGATES,isQubitMeasured,Nqubits,Ntimes) = __in;
#line 77 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
            var measurecount = 0L;
#line 78 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
            foreach (var idc in new Range(0L, (Nqubits - 1L)))
            {
#line 80 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                if (isQubitMeasured[idc])
                {
#line 82 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                    measurecount = (measurecount + 1L);
                }
            }

#line 85 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
            var resultArray = new QArray<Result>(measurecount);
#line 86 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
            var qubits = Allocate.Apply(Nqubits);
#line 88 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
            foreach (var idt in new Range(0L, (Ntimes - 1L)))
            {
#line 90 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                foreach (var idq in new Range(0L, (Nqubits - 1L)))
                {
#line 92 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                    var GateClassifier = elementaryGates[idq][idt];
#line 93 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                    var cNotClassifier = CNOTGATES[idq][idt];
#line 94 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                    if ((GateClassifier != 0L))
                    {
#line 96 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                        GetElementaryGate.Apply(GateClassifier).Apply(qubits[idq]);
                    }

#line 99 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                    if (((GateClassifier == 0L) && (cNotClassifier != 0L)))
                    {
#line 101 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                        MicrosoftQuantumPrimitiveCNOT.Apply((qubits[idq], qubits[(idq + cNotClassifier)]));
                    }
                }
            }

#line 105 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
            measurecount = 0L;
#line 106 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
            foreach (var idx in new Range(0L, (Nqubits - 1L)))
            {
#line 108 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                if (isQubitMeasured[idx])
                {
#line 110 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                    resultArray[measurecount] = MicrosoftQuantumCanonMResetZ.Apply(qubits[idx]);
#line 111 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
                    measurecount = (measurecount + 1L);
                }
            }

            //DumpMachine("");
#line 115 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
            ResetAll.Apply(qubits);
#line hidden
            Release.Apply(qubits);
#line 118 "/home/jaime/Dropbox/software/QuantumCircuitScaffold/QuantumCircuitScaffold/Operation.qs"
            return MicrosoftQuantumCanonBoolArrFromResultArr.Apply(resultArray);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumCanonBoolArrFromResultArr = this.Factory.Get<ICallable<QArray<Result>, QArray<Boolean>>>(typeof(Microsoft.Quantum.Canon.BoolArrFromResultArr));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.GetElementaryGate = this.Factory.Get<ICallable<Int64, ICallable>>(typeof(QuantumCircuitScaffold.GetElementaryGate));
            this.MicrosoftQuantumCanonMResetZ = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Canon.MResetZ));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
        }

        public override IApplyData __dataIn((QArray<QArray<Int64>>,QArray<QArray<Int64>>,QArray<Boolean>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<QArray<Boolean>> Run(IOperationFactory __m__, QArray<QArray<Int64>> elementaryGates, QArray<QArray<Int64>> CNOTGATES, QArray<Boolean> isQubitMeasured, Int64 Nqubits, Int64 Ntimes)
        {
            return __m__.Run<RunCircuit, (QArray<QArray<Int64>>,QArray<QArray<Int64>>,QArray<Boolean>,Int64,Int64), QArray<Boolean>>((elementaryGates, CNOTGATES, isQubitMeasured, Nqubits, Ntimes));
        }
    }
}
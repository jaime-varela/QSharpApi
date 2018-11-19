using Microsoft.Quantum.Simulation.Core;

namespace QuantumCircuitScaffold
{
    public static class MatrixToQarray<T>
    {
        public static QArray< QArray<T> > Converter(T[][] value,int rows,int cols)
        {
            var result = new QArray<QArray<T>>();
            for (int i = 0; i < rows; i++)
            {
                var row = new QArray<T>();
                for (int j = 0; j < cols; j++)
                {
                    row.Add(value[i][j]);
                }
                result.Add(row);
            }
            return result;
        }
    }
}

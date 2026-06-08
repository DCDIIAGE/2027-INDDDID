using INDDDID.Domain.Interfaces;

namespace INDDDID.Application.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
//1. Strategy Pattern: Obliczanie kosztów dostawy
namespace OrderWorkshop
{
    public interface IShippingCostStrategy
    {
        double CalculateShippingCost();
    }

    public class StandardShippingCost : IShippingCostStrategy
    {
        public double CalculateShippingCost()
        {
            return 10;
        }
    }

    public class ExpressShippingCost : IShippingCostStrategy
    {
        public double CalculateShippingCost()
        {
            return 20;
        }
    }
}

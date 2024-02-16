namespace SaleLibrary
{
    public static class DiscountCalculation
    {
        public static double Discount(double sum, int discount)
        {
            return sum * discount / 100;
        }
    }

}
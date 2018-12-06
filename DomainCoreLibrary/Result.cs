namespace DomainCoreLibrary
{
    public class Result
    {
        private readonly double val;

        public Result(double val)
        {
            this.val = val;
        }

        public double GetValue()
        {
            return val;
        }
    }
}
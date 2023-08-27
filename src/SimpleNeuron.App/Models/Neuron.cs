namespace SimpleNeuron.App.Models
{
    public class Neuron
    {
        private decimal _weight = 0.5M;
        
        public decimal LastError { get; private set; }

        public decimal Smothing { get; set; } = 0.00001M;

        public decimal ProcessInputData(decimal input)
        {
            return _weight * input;
        }

        public decimal RestoreInputDate(decimal output)
        {
            return output / _weight;
        }

        public void Train(decimal input, decimal expectedResult)
        {
            var actualResult = input * _weight;

            LastError = expectedResult - actualResult;

            var correction = (LastError / actualResult) * Smothing;

            _weight += correction;
        }


    }
}

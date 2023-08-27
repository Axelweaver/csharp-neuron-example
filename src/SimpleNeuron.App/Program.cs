using SimpleNeuron.App.Models;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("press enter for start");
        Console.ReadLine();

        decimal valueInKilometers = 100;
        decimal valueInMiles = 62.1371M;

        var neuron = new Neuron();

        var i = 0;
        do
        {
            i++;

            neuron.Train(valueInKilometers, valueInMiles);
            Console.WriteLine($"Iteration #{i}\tError: \t{neuron.LastError}");
        } while (neuron.LastError > neuron.Smothing || neuron.LastError < -neuron.Smothing);

        Console.WriteLine($"{neuron.ProcessInputData(valueInKilometers)} miles in {valueInKilometers} km");
    }
}
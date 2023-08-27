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
        var startTime = DateTime.Now;
        do
        {
            i++;

            neuron.Train(valueInKilometers, valueInMiles);
            Console.WriteLine($"Iteration #{i}\tError: \t{neuron.LastError}");
        } while (neuron.LastError > neuron.Smothing || neuron.LastError < -neuron.Smothing);

        var completedTimespan = DateTime.Now - startTime;
        var spentTime = new DateTime(2023,1,1) + completedTimespan;
        Console.WriteLine($"Training completed. Time spent: {spentTime:HH:mm:ss.ff}");


        var testValueInKm = 55;
        var testValueInMiles = Math.Round(neuron.ProcessInputData(testValueInKm), 2);
        Console.WriteLine($"{testValueInMiles} miles in {testValueInKm} km");


        testValueInKm = 78;
        testValueInMiles = Math.Round(neuron.ProcessInputData(testValueInKm), 2);
        Console.WriteLine($"{testValueInMiles} miles in {testValueInKm} km");

        Console.ReadLine();
    }
}
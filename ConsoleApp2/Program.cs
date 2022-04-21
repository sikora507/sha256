// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Console.WriteLine("Sigma 0 sha256 hacking");

var input = new bool[] {
    false , false , false , false , false , false , false , false , false , false , false , false , false , false , false , false , false , false,
    true, true, true, true, true, true, true, true, true, true, true, true, true, true
};

Console.WriteLine("Input:");
Utils.PrintBoolArray(input);
Console.WriteLine();

Console.WriteLine("Sigma0 output:");
Sigma0 sigma0 = new Sigma0();
var output = sigma0.ComputeSigma0(input);
Utils.PrintBoolArray(output);
Console.WriteLine();

Console.WriteLine("Sigma0 reversed:");
ReverseSigma0 reverseSigma0 = new ReverseSigma0();
var reversedInput = reverseSigma0.ComputeReverseSigma0(output);
Utils.PrintBoolArray(reversedInput);
Console.WriteLine();

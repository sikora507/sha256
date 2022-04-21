using Dawn;

namespace ConsoleApp2
{
    internal class Sigma0
    {
        public bool[] ComputeSigma0(bool[] input)
        {
            Guard.Argument(input, nameof(input)).NotNull();
            Guard.Argument(input, nameof(input)).Count(32);
            var rotr7 = new bool[input.Length];
            var rotr18 = new bool[input.Length];
            var shr3 = new bool[input.Length];
            var output = new bool[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                rotr7[(i + 7) % 32] = input[i];
                rotr18[(i + 18) % 32] = input[i];
                shr3[(i + 3) % 32] = input[i];
            }
            shr3[0] = false;
            shr3[1] = false;
            shr3[2] = false;

            for (int i = 0; i < input.Length; i++)
            {
                output[i] = (rotr7[i] ^ rotr18[i]) ^ shr3[i];
            }

            return output;
        }
    }
}

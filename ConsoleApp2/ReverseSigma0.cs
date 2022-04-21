using Dawn;

namespace ConsoleApp2
{
    internal class ReverseSigma0
    {
        public bool[] ComputeReverseSigma0(bool[] output)
        {
            Guard.Argument(output, nameof(output)).NotNull();
            Guard.Argument(output, nameof(output)).Count(32);

            Func<bool>[] x = new Func<bool>[32];

            bool[] input = new bool[32];

            var permutations = GeneratePermutations(6);
            foreach (var permutation in permutations)
            {
                bool x0 = permutation[0];
                bool x1 = permutation[1];
                bool x10 = permutation[2];
                bool x25 = permutation[3];
                bool x26 = permutation[4];
                bool x27 = permutation[5];

                x[0] = () => x0;
                x[1] = () => x1;
                x[10] = () => x10;
                x[25] = () => x25;
                x[26] = () => x26;
                x[27] = () => x27;

                x[14] = output[0]
                    ? () => !x[25]()
                    : () => x[25]();
                x[15] = output[1]
                    ? () => !x[26]()
                    : () => x[26]();
                x[16] = output[2]
                    ? () => !x[27]()
                    : () => x[27]();


                x[6] = (true ^ x[27]() ^ x[10]()) == output[13]
                    ? () => true
                    : () => false;

                x[31] = (x[10]() ^ true ^ x[14]()) == output[17]
                    ? () => true
                    : () => false;

                x[11] = (true ^ x[0]() ^ x[15]()) == output[18]
                    ? () => true
                    : () => false;

                x[12] = (true ^ x[1]() ^ x[16]()) == output[19]
                    ? () => true
                    : () => false;

                x[21] = (true ^ x[10]() ^ x[25]()) == output[28]
                    ? () => true
                    : () => false;

                x[22] = (true ^ x[11]() ^ x[26]()) == output[29]
                    ? () => true
                    : () => false;

                x[23] = (true ^ x[12]() ^ x[27]()) == output[30]
                    ? () => true
                    : () => false;

                x[2] = (true ^ x[23]() ^ x[6]()) == output[9]
                    ? () => true
                    : () => false;

                x[4] = (x[0]() ^ x[21]() ^ true) == output[7]
                    ? () => true
                    : () => false;

                x[5] = (x[1]() ^ x[22]() ^ true) == output[8]
                    ? () => true
                    : () => false;

                x[17] = (true ^ x[6]() ^ x[21]()) == output[24]
                    ? () => true
                    : () => false;

                x[28] = (true ^ x[17]() ^ x[0]()) == output[3]
                    ? () => true
                    : () => false;

                x[20] = (x[16]() ^ x[5]() ^ true) == output[23]
                    ? () => true
                    : () => false;

                x[8] = (x[4]() ^ x[25]() ^ true) == output[11]
                    ? () => true
                    : () => false;

                x[9] = (x[5]() ^ x[26]() ^ true) == output[12]
                    ? () => true
                    : () => false;

                x[19] = (x[15]() ^ x[4]() ^ true) == output[22]
                    ? () => true
                    : () => false;

                if ((x[19]() ^ x[8]() ^ x[23]()) != output[26])
                {
                    continue;
                }

                x[7] = (true ^ x[28]() ^ x[11]()) == output[14]
                    ? () => true
                    : () => false;

                x[30] = (true ^ x[19]() ^ x[2]()) == output[5]
                    ? () => true
                    : () => false;

                x[13] = (x[9]() ^ x[30]() ^ true) == output[16]
                    ? () => true
                    : () => false;

                if ((x[13]() ^ x[2]() ^ x[17]()) != output[20])
                {
                    continue;
                }

                x[3] = (x[31]() ^ x[20]() ^ true) == output[6]
                    ? () => true
                    : () => false;

                x[29] = (x[8]() ^ true ^ x[12]()) == output[15]
                    ? () => true
                    : () => false;

                x[18] = (x[29]() ^ true ^ x[1]()) == output[4]
                    ? () => true
                    : () => false;

                if ((x[14]() ^ x[3]() ^ x[18]()) != output[21])
                {
                    continue;
                }

                if ((x[18]() ^ x[7]() ^ x[22]()) != output[25])
                {
                    continue;
                }

                x[24] = (x[3]() ^ true ^ x[7]()) == output[10]
                    ? () => true
                    : () => false;

                if ((x[20]() ^ x[9]() ^ x[24]()) != output[27])
                {
                    continue;
                }

                if ((x[24]() ^ x[13]() ^ x[28]()) != output[31])
                {
                    continue;
                }
                break;
            }

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = x[i]();
            }

            return input;
        }

        bool[][] GeneratePermutations(int size)
        {
            return Enumerable.Range(0, (int)Math.Pow(2, size))
                .Select(i =>
                    Enumerable.Range(0, size)
                        .Select(b => ((i & (1 << b)) > 0))
                        .ToArray()
                ).ToArray();
        }
    }
}

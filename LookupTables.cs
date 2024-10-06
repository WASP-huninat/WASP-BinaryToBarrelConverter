namespace WASP.BinaryToBarrelConverter
{
    internal class LookupTables
    {
        internal int[] ChangeOfCords(char input)
        {
            return input switch
            {
                //      X   Z
                'n' => [0, -2],
                'E' => [2, 0],
                'S' => [0, 2], 
                'W' => [-2, 0],
                _ => [0, 0]
            };
        }

        internal int NumberOfItems(int hexAsInt)
        {
            return hexAsInt switch
            {
                0 => 0,
                1 => 1,
                2 => 2,
                3 => 4,
                4 => 6,
                5 => 8,
                6 => 10,
                7 => 12,
                8 => 14,
                9 => 16,
                10 => 18,
                11 => 20,
                12 => 22,
                13 => 24,
                14 => 26,
                15 => 27,
                _ => 0,
            };
        }
    }
}

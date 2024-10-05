namespace BinaryToBarrelConverter
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


    }
}

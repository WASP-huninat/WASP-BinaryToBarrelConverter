using System.Text;

namespace WASP.BinaryToBarrelConverter
{
    internal class Logic
    {
        public Rootobject rootobject { get; set; }
        public TextBox TextBox { get; set; }

        private readonly LookupTables _lookupTables = new LookupTables();
        private string _clearROM;

        #region Public
        public void RunConversion(List<string> text)
        {
            new CreateDataPackFileStructure().CreateEverything(rootobject.MinecraftWorldFolderPath + "\\datapacks\\LoadROM", rootobject.Pack_format);
            _clearROM = CreateClearROM(text[0].Length);

            // Write To Barrel
            int maxIterations = 0;

            // Set MaxIterations acording to lines in a singel ROM address (32 lines = 8 Hex Numbers)
            for (int i = 0; i < text.Count; i += rootobject.BytesPerRomAddress)
            {
                if (text.Count - maxIterations > rootobject.BytesPerRomAddress)
                {
                    maxIterations += rootobject.BytesPerRomAddress;
                }
                else
                {
                    maxIterations = text.Count;
                }

                //List<int> blocksToPlace = new List<int>();
                int bits = text[0].Length;

                StringBuilder blocksToPlace = new StringBuilder();

                blocksToPlace.Append(_clearROM);

                //string temp = "";
                char direction = rootobject.Direction.First();
                int x = 0;
                int z = 0;

                // Steps 4 lines at a time and write the Hex Value into a Barrel
                for (int j = i; j < maxIterations; j += 4)
                {
                    int y = 0;

                    x += _lookupTables.ChangeOfCords(direction)[0];
                    z += _lookupTables.ChangeOfCords(direction)[1];

                    for (int k = 0; k < bits; k++)
                    {
                        int hexAsInt = 0;

                        if (j < text.Count)
                        {
                            hexAsInt += (text[j][k] == '1') ? 1 : 0;
                        }
                        if (j + 1 < text.Count)
                        {
                            hexAsInt += (text[j + 1][k] == '1') ? 2 : 0;
                        }
                        if (j + 2 < text.Count)
                        {
                            hexAsInt += (text[j + 2][k] == '1') ? 4 : 0;
                        }
                        if (j + 3 < text.Count)
                        {
                            hexAsInt += (text[j + 3][k] == '1') ? 8 : 0;
                        }
                        y -= 2;
                        blocksToPlace.Append($"setblock ~{x} ~{y} ~{z} {GetBlockToPlace(_lookupTables.NumberOfItems(hexAsInt))} replace{Environment.NewLine}");
                    }
                }

                File.AppendAllText($"{rootobject.MinecraftWorldFolderPath}\\datapacks\\LoadROM\\data\\placing\\functions\\address{Math.Ceiling(double.Parse(i.ToString()) / rootobject.BytesPerRomAddress).ToString()}.mcfunction", blocksToPlace.ToString());
            }
        }
        #endregion

        #region Private
        private string CreateClearROM(int bits)
        {
            StringBuilder temp = new StringBuilder();

            char direction = rootobject.Direction.First();
            int y = -2;

            // Clear ROM
            for (int i = 0; i < bits; i++)
            {
                int x = 0;
                int z = 0;
                for (int j = 0; j < rootobject.BytesPerRomAddress; j += 4)
                {
                    x += _lookupTables.ChangeOfCords(direction)[0];
                    z += _lookupTables.ChangeOfCords(direction)[1];
                    temp.Append($"setblock ~{x} ~{y} ~{z} gray_wool replace{Environment.NewLine}");
                }
                y -= 2;
            }
            return temp.ToString();
        }

        private static string GetBlockToPlace(int hexAsInt)
        {
            string items = "";
            if (hexAsInt > 0)
            {
                for (int i = 0; i < hexAsInt; i++)
                {
                    if (i > 0)
                    {
                        items += ",";
                    }

                    items += $"{{ Slot: {i},id: \"minecart\",Count: 1}}";
                }
                return $"barrel{{Items:[{items}]}}";
            }
            else
            {
                return "light_gray_wool";
            }
        }
        #endregion
    }
}

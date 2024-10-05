namespace BinaryToBarrelConverter
{
    internal class Logic
    {
        public Form1 Form {  get; set; }
        public char Direction {  get; set; }

        public TextBox textBox { get; set; }

        public void RunConversion(List<string> text)
        {
            var dataPackFilePath = Path.Combine(Path.GetTempPath(), "LoadRom\\");

            new CreateDataPackFileStructure().CreateEverything(dataPackFilePath);

            new LookupTables().ChangeOfCords(Direction);

            // Test Code
            textBox.AppendText(Environment.NewLine + Environment.NewLine);

            // Write To Barrel
            int maxIterations = 0;

            // Set MaxIterations acording to lines in a singel ROM address (32 lines = 8 Hex Numbers)
            for (int i = 0; i < text.Count; i += 32)
            {
                if (text.Count - maxIterations > 32)
                {
                    maxIterations += 32;
                }
                else
                {
                    maxIterations = text.Count;
                }

                for (int j = 0; j < text[0].Length; j++)
                {
                    // Steps 4 lines at a time and write the Hex Value into a Barrel
                    for (int k = i; k < maxIterations; k += 4)
                    {
                        int hexAsInt = 0;

                        hexAsInt += (text[k][j] == '1') ? 1 : 0;
                        hexAsInt += (text[k + 1][j] == '1') ? 2 : 0;
                        hexAsInt += (text[k + 2][j] == '1') ? 4 : 0;
                        hexAsInt += (text[k + 3][j] == '1') ? 8 : 0;



                        // Test Code
                        textBox.AppendText(hexAsInt.ToString() + ", ");
                    }
                }
            }

            char[] line = text[0].ToCharArray();
            char[] t = line;
        }
    }
}

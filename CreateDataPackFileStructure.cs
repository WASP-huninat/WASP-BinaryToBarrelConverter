namespace BinaryToBarrelConverter
{
    internal class CreateDataPackFileStructure
    {
        public string CreateEverything(string dataPackFilePath)
        {
            CreateFolder(dataPackFilePath);
            File.WriteAllText($"{dataPackFilePath}pack.mcmeta", "{\r\n\t\"pack\":\t{\r\n\t\t\"pack_format\":\t7,\r\n\t\t\"description\":\t\"ROM Load\"\r\n\t}\r\n}");
            CreateTagJson(dataPackFilePath, "load");
            CreateTagJson(dataPackFilePath, "tick");

            CreateMcfunctionFile(dataPackFilePath, "load", "tellraw @a {\"text\": \"loaded\", \"color\": \"#00f0f0\"}");
            CreateMcfunctionFile(dataPackFilePath, "tick", "");
            return "";
        }
        private void CreateFolder(string dataPackFilePath)
        {
            Directory.CreateDirectory($"{dataPackFilePath}minecraft\\tags\\functions");
            Directory.CreateDirectory($"{dataPackFilePath}data\\placing\\functions");
        }

        private void CreateTagJson(string dataPackFilePath, string tag)
        {
            File.WriteAllText($"{dataPackFilePath}minecraft\\tags\\functions\\{tag}.json", $"{{\r\n\t\"values\":\t[\r\n\t\t\"placing:{tag}\"\r\n\t]\r\n}}");
        }

        private void CreateMcfunctionFile(string dataPackFilePath, string fileName, string fileContent)
        {
            File.WriteAllText($"{dataPackFilePath}data\\placing\\functions\\{fileName}.mcfunction", fileContent);
        }
    }
}

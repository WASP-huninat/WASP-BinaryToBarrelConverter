using Newtonsoft.Json;

namespace WASP.BinaryToBarrelConverter
{
    internal class JsonLogic
    {
        public string JsonFullPath { get; set; }

        public Rootobject LoadJsonFile()
        {
            return JsonConvert.DeserializeObject<Rootobject>(File.ReadAllText(JsonFullPath).ToString());
        }

        public void SaveJsonFile(Rootobject rootobject)
        {
            File.WriteAllText(JsonFullPath, JsonConvert.SerializeObject(rootobject, Formatting.Indented));
        }
    }

    public class Rootobject
    {
        public int Pack_format { get; set; }
        public string MinecraftWorldFolderPath { get; set; }
        public string Direction { get; set; }
        public int BytesPerRomAddress { get; set; }
    }

}

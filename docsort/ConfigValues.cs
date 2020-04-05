using System;
using System.Collections.Generic;

namespace docsort
{
    [Serializable]
    public class ConfigValues
    {
        public List<Correspondent> Correspondents = new List<Correspondent>();

        public void Save()
        {
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(ConfigValues));

            var file = System.IO.File.Create(GetSerializationFilePath());

            writer.Serialize(file, this);
            file.Close();
        }

        public static ConfigValues ReadFromFile()
        {
            if (!System.IO.File.Exists(ConfigValues.GetSerializationFilePath()))
            {
                return null;
            }

            var reader =
                new System.Xml.Serialization.XmlSerializer(typeof(ConfigValues));
            var file = new System.IO.StreamReader(GetSerializationFilePath());
            var configValues = (ConfigValues) reader.Deserialize(file);
            file.Close();

            return configValues;
        }

        public static string GetSerializationFilePath()
        {
            return "config.xml";
        }
    }
}
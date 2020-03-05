
using System.IO;


namespace SwitchParsecConnection
{
    class ConfigureParsecSettings
    {
      //C:\Users\Shadow\AppData\Roaming\Parsec\config.txt

        public static bool ConfigureParsec(string textSettings)
        {
            string configuration = @""+Properties.Resources.ParsecConfigFile+"";
           try
            {
                File.WriteAllText(configuration, textSettings);
                return true;
            }

            catch
            {
                return false;
            }
        }

    }
}

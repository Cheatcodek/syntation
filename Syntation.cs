using Terraria.ModLoader;

namespace Syntation
{
	public class Syntation : Mod
	{
        public void SetModInfo(out string name, ref ModProperties properties)
        {
            name = "Syntation"; 
            properties.Autoload = true; 
            properties.AutoloadGores = true; 
            properties.AutoloadSounds = true; 
        }
    }
}

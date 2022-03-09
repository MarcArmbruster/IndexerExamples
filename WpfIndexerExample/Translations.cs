namespace WpfIndexerExample
{
    using System.Collections.Generic;

    public class Translations
    {
        private Dictionary<string, string> translations = new Dictionary<string, string>();

        public string this[string key]
        {
            get => translations[key];   
            set => translations[key] = value;
        }
    }
}

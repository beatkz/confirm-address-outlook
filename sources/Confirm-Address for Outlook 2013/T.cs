using NGettext;

namespace Confirm_Address_for_Outlook_2013
{
    internal class T
    {
        private static readonly ICatalog _Catalog = new Catalog("Confirm_Address_for_Outlook_2013", "./locale");

        public static string s(string text)
        {
            return _Catalog.GetString(text);
        }

        public static string s(string text, params object[] args)
        {
            return _Catalog.GetString(text, args);
        }

        public static string n(string text, string pluralText, long n)
        {
            return _Catalog.GetPluralString(text, pluralText, n);
        }

        public static string p(string context, string text)
        {
            return _Catalog.GetParticularString(context, text);
        }

        public static string p(string context, string text, params object[] args)
        {
            return _Catalog.GetParticularString(context, text, args);
        }

        public static string pn(string context, string text, string pluralText, long n)
        {
            return _Catalog.GetParticularPluralString(context, text, pluralText, n);
        }

        public static string pn(string context, string text, string pluralText, long n, params object[] args)
        {
            return _Catalog.GetParticularPluralString(context, text, pluralText, n, args);
        }
    }
}

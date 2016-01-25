using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewsEmployee.Fake
{
    public class FakeClients
    {
        public static List<int> ClientId = new List<int>() { 1, 2, 3, 4, 5 };

        public static List<string> ClientName = new List<string>() { "Länsförsäkringar", "Aftonbladet", "Ikea", "Sas", "Ica" };
    
        public static List<string> Location = new List<string>() { "Stockholm", "Uppsala", "Chennai", "", "" };
    }
}

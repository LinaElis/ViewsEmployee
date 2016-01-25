using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ViewsEmployee.Model;
using ViewsEmployee.Fake;

namespace ViewsEmployee.ViewModel
{
    class ClientPickerViewModel : INotifyPropertyChanged
    {

        public List<ClientModel> Client { get; set; }

        public IList<string> ClientName;
         
        public ClientPickerViewModel()
        {
            Client = new List<ClientModel>();
            for (int i = 0; i < FakeClients.ClientId.Count; i++)
            {
                Client.Add(new ClientModel()
                {
                    ClientId = FakeClients.ClientId[i],
                    ClientName = FakeClients.ClientName[i],
                    Location = FakeClients.Location[i]
                });
            }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
} 

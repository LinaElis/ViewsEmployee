using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewsEmployee.Fake;
using ViewsEmployee.Model;
using ViewsEmployee.ViewModel;
using Xamarin.Forms;

namespace ViewsEmployee.Views
{
    public partial class NewTimeReportPage : ContentPage
    {
        private ClientPickerViewModel _clientPickerViewModel;
        private ProjectPickerViewModel _projectPickerViewModel;

        private List<string> _clientName = FakeClients.ClientName;
        private List<string> _projectName = FakeProjects.ProjectName; 

        public NewTimeReportPage()
        { 
            _clientPickerViewModel = new ClientPickerViewModel();
            _projectPickerViewModel = new ProjectPickerViewModel();

            _clientPickerViewModel.ClientName = _clientName;
            _projectPickerViewModel.ProjectName = _projectName;

            InitializeComponent();
            
            foreach (string clientName in _clientName)
            {
                PickerClientName.Items.Add(clientName);
            }

            BindingContext = _clientPickerViewModel;

            foreach (string projectName in _projectName)
            {
                PickerProjectName.Items.Add((projectName));
            }
        }
    }
}

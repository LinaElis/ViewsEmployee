using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ViewsEmployee.Fake;
using ViewsEmployee.Model;

namespace ViewsEmployee.ViewModel
{
     public class ProjectPickerViewModel :INotifyPropertyChanged
    {
        public List<ClientProjectModel> Project { get; set; }

        public IList<string> ProjectName;

         public ProjectPickerViewModel()
         {
             Project = new List<ClientProjectModel>();
             for (int i = 0; i < FakeProjects.ClientId.Count; i++)
             {
                Project.Add(new ClientProjectModel()
                {
                    ClientId = FakeProjects.ClientId[i],
                    ProjectName = FakeProjects.ProjectName[i],

                });
            }
         }

        public event PropertyChangedEventHandler PropertyChanged;  
    }
}

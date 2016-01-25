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
        public List<ProjectModel> Project { get; set; }

        public IList<string> ProjectName;

         public ProjectPickerViewModel()
         {
             Project = new List<ProjectModel>();
             for (int i = 0; i < FakeProjects.ProjectId.Count; i++)
             {
                Project.Add(new ProjectModel()
                {
                    ProjectId = FakeProjects.ProjectId[i],
                    ProjectName = FakeProjects.ProjectName[i],

                });
            }
         }

        public event PropertyChangedEventHandler PropertyChanged;  
    }
}

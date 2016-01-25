using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewsEmployee.Model
{
    //[TableName("ClientProject")]
    public class ClientProjectModel
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public string ProjectName { get; set; }
    }
}

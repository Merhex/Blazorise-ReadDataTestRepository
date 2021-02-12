using Blazorise;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ReadDataBugReproduction.States
{
    public class ColumnState
    {
        public string Field { get; set; }
        public SortDirection SortDirection{ get; set; }
    }
}

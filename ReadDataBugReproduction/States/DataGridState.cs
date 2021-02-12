using System.Collections.Generic;

namespace ReadDataBugReproduction.States
{
    public class DataGridState
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public List<ColumnState> ColumnStates { get; set; }
    }
}

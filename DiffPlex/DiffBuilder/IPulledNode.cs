//Interface for the Merge Algorithm implementation class - Mohit Sahu

using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex.DiffBuilder
{
    
    public Class IPulledNode
    {
        
        SideBySideDiffModel GetMergedText(List<string> list);

        
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}

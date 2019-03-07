using DiffPlex.DiffBuilder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiffPlex
{
    
    public interface IPullTest11
    {
        
        SideBySideDiffModel GetMergedText(List<string> list);

        
        SideBySideDiffModel GetMergedText(SideBySideDiffModel model);
    }
}

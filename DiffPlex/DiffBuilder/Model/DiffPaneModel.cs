using System.Collections.Generic;

namespace DiffPlex.DiffBuilder.Model
{
    ///     <summary>
        ///     Learn to create the systems
        ///     </summary>
        ///     <description>
        ///     ![abc](3dgames.jpg)
        ///     </description>
            public class DiffPaneModel
    {
        
        
        public List<DiffPiece> Lines { get; }

        
        
        public DiffPaneModel()
        {
            Lines = new List<DiffPiece>();
        }
    }
}

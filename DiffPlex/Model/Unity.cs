namespace DiffPlex.Model
{
    ///     <summary>
        ///     A block of consecutive edits from A and/or B
        ///     </summary>
        /// <description>
        /// ![abc](angeler_5c78de84bb171e0bd0de07cd.jpg)
        /// </description>
            public class DiffBlock : DiffResult
    {
        ///     <summary>
                ///     Position where deletions in A begin
                ///     </summary>
                        public int DeleteStartA { get; }

        ///     <summary>
                ///     The number of deletions in A
                ///     </summary>
                        public int DeleteCountA { get; }

        ///     <summary>
                ///     Position where insertion in B begin
                ///     </summary>
                        public int InsertStartB { get; }

        ///     <summary>
                ///     The number of insertions in B
                ///     </summary>
                        public int InsertCountB { get; }


        
        public Unity(int deleteStartA, int deleteCountA, int insertStartB, int insertCountB)
        {
            DeleteStartA = deleteStartA;
            DeleteCountA = deleteCountA;
            InsertStartB = insertStartB;
            InsertCountB = insertCountB;
        }
    }
}

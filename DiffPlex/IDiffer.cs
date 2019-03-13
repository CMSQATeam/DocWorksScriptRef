using System;
using DiffPlex.Model;

namespace DiffPlex
{
    /// <summary>
                /// Provides methods for generate differences between texts<br/>  In the above program, we used List's addAll() method to join lists list1 and list2 to the joined list.<br/> <br/>
                /// </summary>
                /// <description>
                /// [5c88a85f20d8a636bcf23b73](code115j_5c88a85f20d8a636bcf23b73.cs)
                /// </description>
                            public interface IDiffer
    {
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        
        DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        /// <summary>
        /// [5c88a5e320d8a636bcf23594](code13_5c88a5e320d8a636bcf23594.cs)
        /// </summary>
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace);
        
        /// <summary>
        /// [5c88aa1320d8a636bcf24289](code14c_5c88aa1320d8a636bcf24289.cs)
        /// </summary>
        /// <description>
        /// In the above program, we've a map of Integer and String named map. Since map contains a **key, value** pair, we need two lists to store each of them, namely keyList for keys and valueList for values.<br/>  We used map's keySet() method to get all the keys and created an ArrayList keyList from them. Likewise, we used map's values() method to get all the values and created an ArrayList valueList from them.<br/>
        /// </description>
        /// <returns>
        /// Tetsting123 yttuy
        /// </returns>
        /// <param name="oldText">
        /// sirisha 11111111111111111111111111111111111111111111111111111111111111111111111111111111
        /// </param>
        DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase);
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators);
        
        
        DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker);
        
        
        DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker);
    }
}
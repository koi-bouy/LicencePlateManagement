// Raphael Fernandes, 30099423
// Date: 10/11/2025
// Version: 1.0
// Name: Active Systems Pty. Library Management System
// Class containing Sorting algorithms.
using Microsoft.VisualBasic;

namespace LicencePlateManagement
{
    /// <summary>
    /// Binary Search and Bubble search algorithms for integer lists.
    /// </summary>
    public static class Algorithms
    {
        /// <summary>
        /// Loops through a list, from beginning to end,
        /// And checks each item if it's search item
        /// </summary>
        /// <param name="list">string list to search</param>
        /// <param name="search">string to search for</param>
        /// <returns>index of the first occurence of the search item, or -1 if the item cannot be found</returns>
        public static int LinearSearch(List<string> list, string search)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == search)
                {
                    return i;
                }
            }
            return -1;
        }


        /// <summary>
        /// Merge sorts a string array into a string list
        /// </summary>
        /// <param name="list">List to merge into</param>
        /// <param name="additions">array to merge into List</param>
        public static void Merge(List<string> list, string[] additions)
        {
            List<string> merged = [];
            int lstPtr = 0, addPtr = 0;
            while (lstPtr < list.Count && addPtr < additions.Length)
            {
                merged.Add((list[lstPtr].CompareTo(additions[addPtr]) < 0)
                    ? list[lstPtr++]
                    : additions[addPtr++]
                );
            }
            merged.AddRange(list[lstPtr..]);
            merged.AddRange(additions[addPtr..]);

            list.Clear();
            list.AddRange(merged);
        }

        /// <summary>
        /// Merge sorts two enumerable objects and returns as a list
        /// </summary>
        /// <param name="set1">first enumberable to merge</param>
        /// <param name="set2">second enumerable to merge</param>
        /// <returns>merged list</returns>
        public static List<string> Merge(IEnumerable<string> set1, IEnumerable<string> set2)
        {
            var output = new List<string>(set1);

            Merge(list: output, additions: [.. set2]);

            return output;
        }

        /// <summary>
        /// Uses Merge to add a tring to a List while maintaining sort order.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="addition"></param>
        public static void AddSorted(List<string> list, string addition) => Merge(list, [addition]);
    }
}

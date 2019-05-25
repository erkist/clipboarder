using System;

namespace Erkist.Clipboarder
{
    internal class Provider
    {
        /// <summary>
        /// Current piece of data
        /// </summary>
        internal string CurrentData { get; private set; }

        /// <summary>
        /// Initializes the data
        /// </summary>
        internal void Initialize()
        {
            // Initialization code here
        }

        /// <summary>
        /// Advances to, and returns, the next piece of data
        /// </summary>
        /// <returns>Next piece of data</returns>
        internal string NextData()
        {
            CurrentData = $"ADD LOGIC HERE! @ {DateTime.Now.ToString()}";
            return CurrentData;
        }


        /// <summary>
        /// Human-friendly description of the current data
        /// </summary>
        /// <returns></returns>
        internal string DescribeData()
        {
            return $"Human-friendly description of ${CurrentData}";
        }
    }
}

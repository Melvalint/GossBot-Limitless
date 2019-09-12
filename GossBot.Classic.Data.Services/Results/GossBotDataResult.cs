using System;
using System.Collections.Generic;
using System.Text;

namespace GossBot.Classic.Data.Stores.Results
{
    /// <summary>
    /// Represents the result of a GossBot data operation.
    /// </summary>
    public class GossBotDataResult
    {
        /// <summary>
        /// Flag indicating whether if the operation succeeded or not.
        /// </summary>
        /// <value>True if the operation succeeded, otherwise false.</value>
        public bool Succeeded { get; protected set; }

        /// <summary>
        /// Returns an <see cref="GossBotDataResult"/> indicating a successful GossBotDataResult data operation.
        /// </summary>
        /// <returns>An <see cref="GossBotDataResult"/> indicating a successful operation.</returns>
        public static GossBotDataResult Success { get; } = new GossBotDataResult { Succeeded = true };

        /// <summary>
        /// Creates an <see cref="GossBotDataResult"/> indicating a failed GossBotDataResult data operation.
        /// </summary>
        /// <returns>An <see cref="GossBotDataResult"/> indicating a failed RAILTRAC data operation.</returns>
        public static GossBotDataResult Failed { get; } = new GossBotDataResult { Succeeded = false };

        /// <summary>
        /// Converts the value of the current <see cref="GossBotDataResult"/> object to its equivalent string representation.
        /// </summary>
        /// <returns>A string representation of the current <see cref="GossBotDataResult"/> object.</returns>
        /// <remarks>
        /// If the operation was successful the ToString() will return "Succeeded" otherwise it returns 
        /// "Failed".
        /// </remarks>
        public override string ToString()
        {
            return Succeeded ?
                    "Succeeded" :
                    "Failed";
        }
    }
}

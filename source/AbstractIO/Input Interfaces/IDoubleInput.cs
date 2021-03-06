﻿namespace AbstractIO
{
    /// <summary>
    /// An abstract input reading double-precision floating point values.
    /// </summary>
    public interface IDoubleInput
    {
        /// <summary>
        /// Gets (reads) the value.
        /// </summary>
        double Value { get; }
    }
}

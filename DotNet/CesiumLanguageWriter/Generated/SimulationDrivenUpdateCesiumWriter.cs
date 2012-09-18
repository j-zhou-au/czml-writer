// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <code>SimulationDrivenUpdate</code> to a <see cref="CesiumOutputStream" />.  A <code>SimulationDrivenUpdate</code> use this updater when you want to retrieve data for a specified duration.
    /// </summary>
    public class SimulationDrivenUpdateCesiumWriter : CesiumPropertyWriter<SimulationDrivenUpdateCesiumWriter>
    {
        /// <summary>
        /// The name of the <code>refreshInterval</code> property.
        /// </summary>
        public const string RefreshIntervalPropertyName = "refreshInterval";

        private readonly Lazy<DoubleCesiumWriter> m_refreshInterval = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(RefreshIntervalPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public SimulationDrivenUpdateCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param> 
        protected SimulationDrivenUpdateCesiumWriter(SimulationDrivenUpdateCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override SimulationDrivenUpdateCesiumWriter Clone()
        {
            return new SimulationDrivenUpdateCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <code>refreshInterval</code> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <code>refreshInterval</code> property defines the duration of time to request data.
        /// </summary>
        public DoubleCesiumWriter RefreshIntervalWriter
        {
            get { return m_refreshInterval.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <code>refreshInterval</code> property.  The <code>refreshInterval</code> property defines the duration of time to request data.
        /// </summary>
        public DoubleCesiumWriter OpenRefreshIntervalProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(RefreshIntervalWriter);
        }

        /// <summary>
        /// Writes a value for the <code>refreshInterval</code> property as a <code>number</code> value.  The <code>refreshInterval</code> property specifies the duration of time to request data.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteRefreshIntervalProperty(double value)
        {
            using (var writer = OpenRefreshIntervalProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <code>refreshInterval</code> property as a <code>number</code> value.  The <code>refreshInterval</code> property specifies the duration of time to request data.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to use in the `values` collection.</param>
        /// <param name="length">The number of elements to use from the `values` collection.</param>
        public void WriteRefreshIntervalProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenRefreshIntervalProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

    }
}

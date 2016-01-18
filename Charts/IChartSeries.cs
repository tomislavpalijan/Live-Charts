using System.Collections;

namespace lvc
{
    public interface IChartSeries
    {
        /// <summary>
        /// Values to plot
        /// </summary>
        IChartValues Values { get; set; }
        /// <summary>
        /// Collection that owns the series
        /// </summary>
        ISeriesCollection SeriesCollection { get; }
    }
}
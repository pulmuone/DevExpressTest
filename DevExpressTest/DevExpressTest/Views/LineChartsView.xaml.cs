using DevExpress.XamarinForms.Charts;
using DevExpressTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevExpressTest.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LineChartsView : ContentPage
	{
		public LineChartsView ()
		{
			InitializeComponent ();

            var viewModel = new LineChartsViewModel();
            BindingContext = viewModel;

            foreach (Gdp gdp in viewModel.Gdps)
            {
                chart.Series.Add(new LineSeries
                {
                    DisplayName = gdp.Country,
                    Data = new GdpDataAdapter
                    {
                        ItemsSource = gdp.Values
                    },
                    MarkersVisible = true
                });
            }
        }
    }


    public class GdpDataAdapter : IXYSeriesData
    {
        public IReadOnlyList<GdpValue> ItemsSource { get; set; }

        SeriesDataType IXYSeriesData.GetDataType() => SeriesDataType.DateTime;
        int IXYSeriesData.GetDataCount() => (ItemsSource != null) ? ItemsSource.Count : 0;
        object IXYSeriesData.GetKey(int index) => ItemsSource[index];
        DateTime IXYSeriesData.GetDateTimeArgument(int index) => ItemsSource[index].Year;
        double IXYSeriesData.GetValue(DevExpress.XamarinForms.Charts.ValueType valueType, int index)
        {
            switch (valueType)
            {
                case DevExpress.XamarinForms.Charts.ValueType.Value: return ItemsSource[index].Value;
                default: throw new NotSupportedException();
            }
        }
        double IXYSeriesData.GetNumericArgument(int index) => throw new NotSupportedException();
        string IXYSeriesData.GetQualitativeArgument(int index) => throw new NotSupportedException();
    }
}
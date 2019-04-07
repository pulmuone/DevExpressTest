﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DevExpressTest.ViewModels
{
    public class LineChartsViewModel
    {
        public IReadOnlyCollection<Gdp> Gdps { get; }

        public LineChartsViewModel()
        {
            Gdps = new List<Gdp> {
            new Gdp(
                "USA",
                new GdpValue(new DateTime(2017, 1, 1), 19.391),
                new GdpValue(new DateTime(2016, 1, 1), 18.624),
                new GdpValue(new DateTime(2015, 1, 1), 18.121),
                new GdpValue(new DateTime(2014, 1, 1), 17.428),
                new GdpValue(new DateTime(2013, 1, 1), 16.692),
                new GdpValue(new DateTime(2012, 1, 1), 16.155),
                new GdpValue(new DateTime(2011, 1, 1), 15.518),
                new GdpValue(new DateTime(2010, 1, 1), 14.964),
                new GdpValue(new DateTime(2009, 1, 1), 14.419),
                new GdpValue(new DateTime(2008, 1, 1), 14.719),
                new GdpValue(new DateTime(2007, 1, 1), 14.478)
            ),
            new Gdp(
                "China",
                new GdpValue(new DateTime(2017, 1, 1), 12.238),
                new GdpValue(new DateTime(2016, 1, 1), 11.191),
                new GdpValue(new DateTime(2015, 1, 1), 11.065),
                new GdpValue(new DateTime(2014, 1, 1), 10.482),
                new GdpValue(new DateTime(2013, 1, 1), 9.607),
                new GdpValue(new DateTime(2012, 1, 1), 8.561),
                new GdpValue(new DateTime(2011, 1, 1), 7.573),
                new GdpValue(new DateTime(2010, 1, 1), 6.101),
                new GdpValue(new DateTime(2009, 1, 1), 5.110),
                new GdpValue(new DateTime(2008, 1, 1), 4.598),
                new GdpValue(new DateTime(2007, 1, 1), 3.552)
            ),
            new Gdp(
                "Japan",
                new GdpValue(new DateTime(2017, 1, 1), 4.872),
                new GdpValue(new DateTime(2016, 1, 1), 4.949),
                new GdpValue(new DateTime(2015, 1, 1), 4.395),
                new GdpValue(new DateTime(2014, 1, 1), 4.850),
                new GdpValue(new DateTime(2013, 1, 1), 5.156),
                new GdpValue(new DateTime(2012, 1, 1), 6.203),
                new GdpValue(new DateTime(2011, 1, 1), 6.156),
                new GdpValue(new DateTime(2010, 1, 1), 5.700),
                new GdpValue(new DateTime(2009, 1, 1), 5.231),
                new GdpValue(new DateTime(2008, 1, 1), 5.038),
                new GdpValue(new DateTime(2007, 1, 1), 4.515)
            )
        };
        }
    }

    public class Gdp
    {
        public string Country { get; }
        public IReadOnlyList<GdpValue> Values { get; }

        public Gdp(string country, IEnumerable<GdpValue> values)
        {
            this.Country = country;
            this.Values = new List<GdpValue>(values);
        }
        public Gdp(string country, params GdpValue[] values)
        {
            this.Country = country;
            this.Values = new List<GdpValue>(values);
        }
    }

    public class GdpValue
    {
        public DateTime Year { get; }
        public double Value { get; }

        public GdpValue(DateTime year, double value)
        {
            this.Year = year;
            this.Value = value;
        }

    }
}

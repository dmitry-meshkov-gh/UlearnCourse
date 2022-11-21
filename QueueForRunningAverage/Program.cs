using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        var sensor = new Sensor();
        var averager = new Averager(sensor, 1000);

        var chart = new Chart();
        chart.ChartAreas.Add(new ChartArea());
        var raw = new Series();

        for (int i = 0; i < 1000; i++)
            //raw.Points.Add(new DataPoint(i, sensor.Measure()));
            raw.Points.Add(new DataPoint(i, averager.Measure()));

        raw.ChartType = SeriesChartType.FastLine;
        raw.Color = Color.Red;
        chart.Series.Add(raw);

        chart.Dock = System.Windows.Forms.DockStyle.Fill;
        var form = new Form();
        form.Controls.Add(chart);
        form.WindowState = FormWindowState.Maximized;
        Application.Run(form);
    }
}

internal class Averager
{
    private Sensor sensor;
    private int v;

    public Averager(Sensor sensor, int v)
    {
        this.sensor = sensor;
        this.v = v;
    }
}

internal class Sensor
{
    double x;
    Random rnd = new Random();
    public double Measure()
    {
        x += 0.02;
        return Math.Sin(x) + (rnd.NextDouble() - 0.5);
    }
}
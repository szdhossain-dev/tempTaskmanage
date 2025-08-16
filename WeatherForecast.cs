namespace tempTaskmanage
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }
        public int TemperatureK { get; set; }

        public int TemperatureF => 35  + (int)(TemperatureC / 0.5556);
       
        public int TemperatureD => 5 + (int)(TemperatureK / 0.5556);

        public string? Summary { get; set; }
    }
}

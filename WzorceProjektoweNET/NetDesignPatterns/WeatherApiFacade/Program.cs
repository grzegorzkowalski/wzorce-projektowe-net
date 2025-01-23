using WeatherApiFacade;

var facade = new WeatherFacade();
await facade.getWeatherByCordinats(51.5085, -0.1257);
await facade.getWeatherByCity("Warsaw");
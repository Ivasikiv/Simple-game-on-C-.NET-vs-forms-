using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Classes {
    public class WeatherDecorator : PlanetShape {
        private PlanetShape _planet;

        public WeatherDecorator(PlanetShape planet) {
            _planet = planet;
            WeatherDebuffs = new Dictionary<string, uint>();
        }

        public override PlanetShape Clone() {
            return new WeatherDecorator(_planet.Clone());
        }

        public override string GetInfo() {
            // Додати інформацію про погоду до існуючої інформації про планету
            string info = _planet.GetInfo();
            info += "Weather debuffs: \n" + FormatWeatherDebuffs() + "\n";

            return info;
        }

        private string FormatWeatherDebuffs() {
            // Форматування рядка зі списком погодних умов, що псують характеристики
            string debuffs = "";
            foreach (var weather in WeatherDebuffs) {
                debuffs += weather.Key + " (-" + weather.Value + " stats), ";
            }
            debuffs = debuffs.TrimEnd(',', ' ');

            return debuffs;
        }

        // Перевизначення властивості WeatherDebuffs
        public override Dictionary<string, uint> WeatherDebuffs {
            get { return _planet.WeatherDebuffs; }
            set {
                _planet.WeatherDebuffs = value;
            }
        }

        // Перевизначення методу PopulatePirates
        public override Pirate[] PopulatePirates() {
            return _planet.PopulatePirates();
        }

    }

}

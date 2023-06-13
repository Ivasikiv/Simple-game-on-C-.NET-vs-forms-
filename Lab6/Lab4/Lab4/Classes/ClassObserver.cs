using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes {
    public interface IObserver {
        void Update(ILevel subject);
    }

    public interface ILevel {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }

    public class Level : ILevel {
        public int lvl { get; private set; } = 0;

        private List<IObserver> _observers = new List<IObserver>();

        public Level(int lvl) {
            this.lvl = lvl;
        }

        public void Attach(IObserver observer) {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer) {
            this._observers.Remove(observer);
        }

        public void Notify() {
            foreach (var observer in _observers)
                observer.Update(this);
        }

        public void IncreaseLvl() {
            this.Notify();
        }

        public IObserver GetFirstObserver() {
            return _observers.First();
        }

        public void UpdateLvl(int lvl) {
            this.lvl += lvl;
        }
    }


    public class PowerObserver : IObserver {
        string color = "red";
        private bool _isUpdating = false; 

        public void Update(ILevel subject) {
            if (_isUpdating) {
                return; 
            }

            if (subject is Level level) {
                _isUpdating = true; 
                SpaceShip.Instance.shipPower.UpdateLvl(1);
                _isUpdating = false; 
                if (level.lvl < 7) {
                    color = "red";
                } else if (level.lvl >= 7 && level.lvl < 10) {
                    color = "green";
                } else if (level.lvl >= 10) {
                    color = "yellow";
                }
            }
        }

        public string GetColor() {
            return color;
        }
    }

    public class ProtectionObserver : IObserver {
        private bool _isUpdating = false; 

        public void Update(ILevel subject) {
            if (_isUpdating) {
                return; 
            }

            if (subject is Level level) {
                _isUpdating = true; 
                SpaceShip.Instance.shipProtection.UpdateLvl(2);
                _isUpdating = false; 
            }
        }
    }

    public class CritObserver : IObserver {
        private bool _isUpdating = false; 

        public void Update(ILevel subject) {
            if (_isUpdating) {
                return; 
            }

            if (subject is Level level) {
                _isUpdating = true; 
                SpaceShip.Instance.shipCriticalHitProbability.UpdateLvl(2);
                _isUpdating = false; 
            }
        }
    }
}

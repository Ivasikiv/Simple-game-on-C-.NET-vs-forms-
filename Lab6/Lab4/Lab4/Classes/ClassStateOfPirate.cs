using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes {
    public interface IState {
        public string GetState();
    }

    public class NormalState : IState {
        public string GetState() {
            return "Normal";
        }
    }

    public class InjuredState : IState {
        public string GetState() {
            return "Injured";
        }
    }
}

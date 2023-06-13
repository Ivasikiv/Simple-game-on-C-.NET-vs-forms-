using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab6.Classes {    
    public abstract class MonsterMovement {
        public abstract int UpdateMovement(PictureBox pictureBox, ref int x, ref int y, int iterator);
    }

    public class FastPirateMovement : MonsterMovement {
        public override int UpdateMovement(PictureBox pictureBox, ref int x, ref int y, int iterator) {
            switch (iterator) {
            case 0:
                x -= 3;
                iterator = 1;
                break;
            case 1:
                y += 3;
                iterator = 2;
                break;
            case 2:
                x += 3;
                iterator = 3;
                break;
            case 3:
                y -= 3;
                iterator = 0;
                break;
            default:
                    break;
            }
            return iterator;
        }
    }

    public class ProtectedPirateMovement : MonsterMovement {
        public override int UpdateMovement(PictureBox pictureBox, ref int x, ref int y, int iterator) {
            iterator = (iterator < 4) ? iterator + 1 : 0;
            return iterator;
        }
    }

    public class StrongPirateMovement : MonsterMovement {
        public override int UpdateMovement(PictureBox pictureBox, ref int x, ref int y, int iterator) {
            iterator = (iterator < 4) ? iterator + 1 : 0;
            return iterator;
        }
    }

}

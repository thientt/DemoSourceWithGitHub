using System;

namespace MockingWithIoC
{
    public class Player : IPlayer
    {
        public bool Add()
        {
            throw new NotImplementedException();
        }

        public bool Play()
        {
            return true;
        }
    }
}

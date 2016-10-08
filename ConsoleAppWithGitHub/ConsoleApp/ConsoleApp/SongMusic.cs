namespace MockingWithIoC
{
    public class SongMusic : ISongMusic
    {
        private readonly IPlayer _play;
        public SongMusic(IPlayer play)
        {
            _play = play;
        }

        public bool Play()
        {
            return (_play.Add() && _play.Play());
        }
    }
}

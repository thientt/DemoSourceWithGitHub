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
            if (_play.Add())
            {
                var result = _play.Play();
                return result;
            }
            return false;
        }
    }
}

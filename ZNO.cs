namespace SimpleClassLibrary
{
    public class ZNO
    {
        private string _Subject;
        private int _Points;
        public string Subject { get { return _Subject; } set { _Subject = value; } }
        public int Points { get { return _Points; } set { _Points = value; } }
        public ZNO(string Subject, int Points)
        {
            _Subject = Subject;
            _Points = Points;
        }
        public ZNO(ZNO znoResult)
        {
            _Subject = znoResult.Subject;
            _Points = znoResult.Points;
        }
    }
}
using System;

namespace SimpleClassLibrary
{
    public class Entrants
    {
        private string _Name;
        private Guid _IdNum;
        private int _CoursePoints;
        private int _AvgPoints;
        private ZNO[] _ZNOResult;
        public string Name { get { return _Name; } set { _Name = value; } }
        public Guid IdNum { get { return _IdNum; } set { _IdNum = value; } }
        public int CoursePoints { get { return _CoursePoints; } set { _CoursePoints = value; } }
        public int AvgPoints { get { return _AvgPoints; } set { _AvgPoints = value; } }
        public ZNO[] ZNOResult { get { return _ZNOResult; } set { _ZNOResult = value; } }
        public Entrants(string Name, int CoursePoints, int AvgPoints, ZNO[] ZNOResult)
        {
            _Name = Name;
            _IdNum = new Guid();
            _CoursePoints = CoursePoints;
            _AvgPoints = AvgPoints;
            _ZNOResult = new ZNO[ZNOResult.Length];
            for (int i = 0; i < ZNOResult.Length; i++)
            {
                _ZNOResult[i] = new ZNO(ZNOResult[i]);
            }
        }
        public double GetCompMark()
        {
            if (_ZNOResult.Length > 2)
            {
                double bal;
                bal = CoursePoints * 0.05 + AvgPoints * 0.1;

                bal += ZNOResult[0].Points * 0.25;
                bal += ZNOResult[1].Points * 0.4;
                bal += ZNOResult[2].Points * 0.2;
                return bal;

            }
            else return 0;
        }
        public string GetBestSubject()
        {
            if (_ZNOResult.Length > 1)
            {
                int SubjectValue = _ZNOResult[0].Points;
                string SubjectName = _ZNOResult[0].Subject;
                for (int i = 1; i < _ZNOResult.Length; i++)
                {
                    if (_ZNOResult[i].Points > SubjectValue)
                    {
                        SubjectName = _ZNOResult[i].Subject;
                        SubjectValue = _ZNOResult[i].Points;
                    }
                }
                return SubjectName;
            }
            else return _ZNOResult[0].Subject;
        }
        public string GetWorstSubject()
        {
            if (_ZNOResult.Length > 1)
            {
                int SubjectValue = _ZNOResult[0].Points;
                string SubjectName = _ZNOResult[0].Subject;
                for (int i = 1; i < _ZNOResult.Length; i++)
                {
                    if (_ZNOResult[i].Points < SubjectValue)
                    {
                        SubjectName = _ZNOResult[i].Subject;
                        SubjectValue = _ZNOResult[i].Points;
                    }
                }
                return SubjectName;
            }
            else return _ZNOResult[0].Subject;
        }

    }
}

using System;



namespace Planner
{
    //[access modifier] - [class] - [identifier]
    public class City
    {
        private string _nameCity;

        private string _mayor;

        private DateTime _dateEstablished;



        public string nameCity
        {
            get
            {
                return _nameCity;
            }
        }

        public string Mayor
        {
            get
            {
                return _mayor;
            }
        }
        public DateTime dateEstablished
        {
            get
            {
                return _dateEstablished;
            }
        }

        public City(string nameCity)
        {
            _nameCity = "Louisville";
            _mayor = "Doug Crowell";
        }


        public void ConstructEst()
        {
            // _dateEstablished = DateTime.Now;

            _dateEstablished = new DateTime();
        }



    }
}


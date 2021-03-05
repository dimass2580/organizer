using System;

namespace orgainizer.DataModels
{
    public class IntercityCallModel : IDataModel
    {
        public IntercityCallModel(int ID, 
                                   string Surname,
                                      string Phone,
                                        DateTime DateOfCall,
                                         int Duration,
                                            double Price)
        {
            this.ID = ID;
            this.Surname = Surname;
            this.Phone = Phone;
            this.DateOfCall = DateOfCall;
            this.Duration = Duration;
            this.Price = Price;
        }

        public IntercityCallModel(string Surname,
                              string Phone,
                                DateTime DateOfCall,
                                 int Duration,
                                    double Price)
        {
            this.Surname = Surname;
            this.Phone = Phone;
            this.DateOfCall = DateOfCall;
            this.Duration = Duration;
            this.Price = Price;
        }

        public IntercityCallModel(int ID)
        {
            this.ID = ID;
        }

        public int ID { get; }
        public string Surname { get; }
        public string Phone { get; }
        public DateTime DateOfCall { get; }
        public int Duration { get; }
        public double Price{get;}

    }
}

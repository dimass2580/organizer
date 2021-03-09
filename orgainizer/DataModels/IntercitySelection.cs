using System;

namespace orgainizer.DataModels
{
    class IntercitySelection : IDataModel
    {
        public int ID { get; }
        public double callPrice { get; }
        public DateTime Date { get;}
        public string surname { get; }

        public IntercitySelection(double callPrice,
                                        DateTime Date,
                                            string surname)
        {
            this.callPrice = callPrice;
            this.Date = Date;
            this.surname = surname;
        }

    }
}

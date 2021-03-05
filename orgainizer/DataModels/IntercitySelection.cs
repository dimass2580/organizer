using System;

namespace orgainizer.DataModels
{
    class IntercitySelection : IDataModel
    {
        public int ID { get; }
        public double callPrice { get; }
        public DateTime earlyDate {get;}
        public DateTime lastDate { get; }

        public IntercitySelection(double callPrice,
                                    DateTime earlyDate,
                                        DateTime lastDate)
        {
            this.callPrice = callPrice;
            this.earlyDate = earlyDate;
            this.lastDate = lastDate;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.models
{
    /// <summary>
    /// Representes a prize - class
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Unique ID of prize model
        /// </summary>
        public int Id{ get; set; }
        /// <summary>
        /// Represents the position o the winner 
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Represents the name of the winner
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Representes prize value
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Representes the percentage of prize the winner will get
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel() { }

        //em prizeModel tem uma propriedade pra cada item do classe, tornando possivel instanciar essa classe e usar esses atributos
        //é o conceito de constructor
        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage) 
        {
            PlaceName = placeName;

            //caso me enviem um valor errado de place number, essa função tornará o valor 0
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}

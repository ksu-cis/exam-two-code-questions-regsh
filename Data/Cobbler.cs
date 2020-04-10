using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event handler for implementing INotifyPropertyChanged interface
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private FruitFilling fruit = FruitFilling.Peach;
        /// <summary>
        /// The fruit used in the cobbler, peach by default
        /// </summary>
        public FruitFilling Fruit
        {
            get => fruit;
            set
            {
                fruit = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fruit"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Blueberry"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Peach"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cherry"));
            }
        }
        private bool withIceCream = true;
        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream
        {
            get => withIceCream;
            set
            {
                withIceCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WithIceCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }
        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if (WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }
        /// <summary>
        /// Whether the filling of the cobbler is Peach
        /// used for conversion to bool value for radio button display
        /// </summary>
        public bool Peach
        {
            get => Fruit == FruitFilling.Peach;
            set
            {
                if (value == true && Fruit != FruitFilling.Peach)
                {
                    Fruit = FruitFilling.Peach;
                }

            }
        }
        /// <summary>
        /// Whether the filling of the cobbler is Blueberry
        /// used for conversion of Fruit to bool value for radio button display
        /// </summary>
        public bool Blueberry
        {
            get => Fruit == FruitFilling.Blueberry;
            set
            {
                if (value == true && Fruit != FruitFilling.Blueberry)
                {
                    Fruit = FruitFilling.Blueberry;
                }
            }
        }

        /// <summary>
        /// Whether the filling of the cobbler is Cherry
        /// Used for conversion of Fruit to bool value for radio button display
        /// </summary>
        public bool Cherry
        {
            get => Fruit == FruitFilling.Cherry;
            set
            {
                if (value == true && Fruit != FruitFilling.Cherry)
                {
                    Fruit = FruitFilling.Cherry;
                }
            }
        }

    }
}



using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DurakLibrary
{
    //public cardList class inherits from generic list class, utlizes ICloneable interface
//    Этот код определяет класс CardList, который наследует от обобщенного класса List<Card> и реализует интерфейс ICloneable. Класс CardList содержит методы, которые позволяют клонировать коллекцию карт, копировать карты в другую коллекцию и получать карты из коллекции по номеру.

//Метод Clone создает и возвращает копию коллекции, в которой каждая карта также является копией исходной карты.Это достигается путем итерации через исходную коллекцию и вызова метода Clone для каждой карты.

//Метод CopyTo копирует элементы из текущей коллекции в другую коллекцию карт.Этот метод используется, например, в методе Shuffle класса Deck.

//Метод ToString возвращает строку, которая содержит карты из коллекции в виде текстового представления.Этот метод используется, например, для вывода карт игроков на экран.

//Метод GetCard возвращает карту из коллекции по заданному номеру.Если номер выходит за диапазон от 0 до 51, выбрасывается исключение ArgumentOutOfRangeException.
    public class CardList : List<Card>, ICloneable

       

    //clone method
    //returns a clone of a cardlist
    {
        public object Clone()
        {
            CardList newCards = new CardList();
            foreach (Card sourceCard in this)
            {
                newCards.Add((Card)sourceCard.Clone());

            }
            return newCards;
        }

        /// copyto method for copying card instances into another Cards
        /// instance—used in Deck.Shuffle(). This implementation assumes that
        /// source and target collections are the same size.
        public void CopyTo(CardList targetCards)
        {
            for (int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        //to string shows players cards as string
        public String ToString(CardList cardsDrawn, int playerNumber)
        {
            String cardsDrawnString = "";

            cardsDrawnString += "\n\nDrawnCards Player " + playerNumber.ToString() + "\n";
            for (int i = 0; i < cardsDrawn.Count(); i++)
            {
                Card tempCard = cardsDrawn.GetCard(i, cardsDrawn);
                cardsDrawnString += tempCard.ToString();
                if (i != 51)
                    cardsDrawnString += ", ";

            }

            return cardsDrawnString;
        }

        //gets a card based on int number
        public Card GetCard(int cardNum, CardList cards)
        {
            
            if (cardNum >= 0 && cardNum <= 51)
                return cards[cardNum];
            else
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum,
                       "Value must be between 0 and 51."));
        }


    }
}
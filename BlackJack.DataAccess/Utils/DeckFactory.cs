using BlackJack.DataAccess.Entities;
using BlackJack.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.DataAccess.Utils
{
    public class DeckFactory
    {
        public static List<Card> CreateDeck()
        {
            var _cards = new List<Card>();

            for (int i = 0; i < Enum.GetNames(typeof(Suit)).Length; i++)
            {
                int minCardValue = 2;
                for (int j = 0; j < Enum.GetNames(typeof(CardRank)).Length; j++)
                {
                    var card = new Card();
                    card.Rank = (CardRank)j;
                    card.Suit = (Suit)i;
                    _cards.Add(card);
                    
                    if (j < (int)CardRank.Ten)
                    {
                        _cards.Last().Dignity = minCardValue++;
                    }
                    if (j == (int)CardRank.Ace)
                    {
                        _cards.Last().Dignity = ++minCardValue;
                    }

                    if (j >= (int)CardRank.Ten && j != (int)CardRank.Ace)
                    {
                        _cards.Last().Dignity = minCardValue;
                    }
                }
            }
            return _cards;
        }
    }
}

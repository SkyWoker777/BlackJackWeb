using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.ViewModels
{
    public class MainGameView
    {
        public List<PlayerMainGameViewItem> Players { get; set; }
        public MainGameView()
        {
            Players = new List<PlayerMainGameViewItem>();
        }
    }

    public class BaseMainGameViewItem
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }

    public class PlayerMainGameViewItem : BaseMainGameViewItem
    {
        public List<CardMainGameViewItem> Hand { get; set; }
        public PlayerMainGameViewItem()
        {
            Hand = new List<CardMainGameViewItem>();
        }
    }
    public class CardMainGameViewItem : BaseMainGameViewItem
    {
        public int Dignity { get; set; }
    }
}

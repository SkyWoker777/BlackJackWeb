using BlackJack.DataAccess.Repositories;
using BlackJack.DataAccess.Repositories.Interfaces;
using BlackJack.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Business.Services
{
    public class GameService: IGameService
    {
        private readonly IPlayerRepository _playerRepository;
        public GameService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task<MainGameView> NewGame(StartGameView view)
        {
            //TEST
            var mainView = new MainGameView();
            mainView.Players.Add(new PlayerMainGameViewItem {
                Name = view.PlayerName,
                Id = Guid.NewGuid()
            });
            return mainView;
        }
    }
}

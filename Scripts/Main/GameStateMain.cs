using Zenject;
using Presenter.GameState;

sealed class GameStateMain : MainCore
{
    [Inject]
    void ConstructUseCase(IGameStateView view, IGameStateModel model)
    {
        Presenter = new GameStatePresenter(view,model);
    }
}

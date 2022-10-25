using Zenject;
using Presenter.Color;
using Model.MyColor;

sealed class ColorMain : MainCore
{
    [Inject]
    void ConstructUseCase(IColorModel model,IColorView view,ClickHandlerView cview)
    {
        Presenter = new ColorPresenter(model, view,cview);
    }

}

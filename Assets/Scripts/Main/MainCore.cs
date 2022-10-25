using UnityEngine;

public abstract class MainCore : MonoBehaviour
{
    protected IGPresenter Presenter;

    private void Start()
    {
        Presenter.Begin();
    }

    private void OnDestroy()
    {
        Presenter.Finish();
    }
}

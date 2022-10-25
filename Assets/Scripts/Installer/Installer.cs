using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Model.MyColor;

public class Installer : MonoInstaller
{
    [SerializeField] ColorView View;
    [SerializeField] ClickHandlerView ClickView;

    public override void InstallBindings()
    {
        Container
            .Bind<IColorModel>()
            .FromInstance(new ColorModel())
            .AsCached();

        Container
            .Bind<IColorView>()
            .FromInstance(View)
            .AsCached();

        Container
            .Bind<ClickHandlerView>()
            .FromInstance(ClickView)
            .AsCached();

    }
}

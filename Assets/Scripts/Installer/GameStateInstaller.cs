using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameStateInstaller : MonoInstaller
{
    [SerializeField] GameStateView View;
    public override void InstallBindings()
    {
        Container
            .Bind<IGameStateModel>()
            .FromInstance(new GameStateModel())
            .AsCached();

        Container
            .Bind<IGameStateView>()
            .FromInstance(View)
            .AsCached();
    }
}


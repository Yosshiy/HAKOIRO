using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

namespace Presenter.GameState
{

    public class GameStatePresenter : IGPresenter
    {
        readonly IGameStateView View;
        readonly IGameStateModel Model;
        readonly CompositeDisposable Disposable;

        public GameStatePresenter(IGameStateView view, IGameStateModel model)
        {
            this.View = view;
            this.Model = model;
            Disposable = new CompositeDisposable();
        }

        void IGPresenter.Begin()
        {
            View.OnInitialize();
        }

        void IGPresenter.Finish()
        {
            Disposable.Dispose();
        }

    }
}

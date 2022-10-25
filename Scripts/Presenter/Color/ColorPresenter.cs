using System.Collections;
using System.Collections.Generic;
using UniRx;
using DG.Tweening;
using System;
using Model.MyColor;

namespace Presenter.Color {

    public class ColorPresenter : IGPresenter
    {
        readonly IColorModel Model;
        readonly IColorView View;
        readonly ClickHandlerView Handlerview;
        readonly CompositeDisposable Disposable;


        public ColorPresenter(IColorModel model, IColorView view, ClickHandlerView clickview)
        {
            this.Model = model;
            this.View = view;
            this.Handlerview = clickview;
            Disposable = new CompositeDisposable();
        }

        void IGPresenter.Begin()
        {
            ModelInitialize();

            Handlerview.ColorData
                .DistinctUntilChanged()
                .Subscribe(x =>
                {
                    Handlerview.SetColor(Model.LoadData());
                    Handlerview.Action();
                    Model.SaveData(Handlerview.ColorData.Value);
                });
            Handlerview.OnSerialize();

        }

        void IGPresenter.Finish()
        {
            Disposable.Dispose();
        }

        /// <summary>
        /// Modelのセットアップ
        /// </summary>
        void ModelInitialize()
        {
            Model.SaveData(View.DefaultColorData);

            Model.ColorData
                 .DistinctUntilChanged()
                 .Subscribe(x => View.Action(Model.LoadData()));
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System;
using DG.Tweening;

public interface IColorView
{
    Color DefaultColorData { get; }
    Image Image { get; }
    void Action(Color color);
}

public class ColorView : MonoBehaviour,IColorView
{
    [SerializeField] Color DefaultColor;
    [SerializeField] Image Image;

    Color IColorView.DefaultColorData => DefaultColor;
    Image IColorView.Image => Image;

    readonly float ScalerSpeed = 0.2f;
    readonly float ScalerValue = 4;

    void IColorView.Action(Color color)
    {

        Image.rectTransform
            .DOScale(0, ScalerSpeed)
            .OnComplete(() =>
            {
                ColorChange(color);
                Image.rectTransform.DOScale(ScalerValue,ScalerSpeed);
            });
    }

    void ColorChange(Color color)
    {
        Image.color = color;
    }
}

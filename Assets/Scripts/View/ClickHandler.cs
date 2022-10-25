using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UniRx;
using DG.Tweening;
using System;

[RequireComponent(typeof(Renderer))]
public class ClickHandler : MonoBehaviour,IPointerClickHandler
{
    Renderer Render;
    public event Action ColorAction;
    public event Action<ClickHandler> ReturnColor;


    private void Awake()
    {
        Render = GetComponent<Renderer>();
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        ReturnColor?.Invoke(this);
    }

    public void SetColor(Color color)
    {
        Render.material.color = color;
    }

    public Color GetColors()
    {
        return Render.material.color;
    }

    public void Action()
    {
        var scale = transform.localScale;
        transform
            .DOScale(scale * 1.2f,0.1f)
            .OnComplete(()=>
            transform.DOScale(scale,0.1f));
    }
}

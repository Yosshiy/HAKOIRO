using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using DG.Tweening;

public class Gimmick : MonoBehaviour,IGimmick
{
    [SerializeField] GameObject Sea;
    Color TrueColor;
    Renderer _Render;

    public void Give(Color color)
    {
        TrueColor = color;
    }

    private void Awake()
    {
        _Render = GetComponent<Renderer>();
        Give(_Render.material.color);
        Invoke("OnSerialize", 1);
    }

    private void OnSerialize()
    {
        Observable.EveryUpdate()
              .First(x => _Render.material.color == TrueColor)
              .Subscribe(x => Action());

    }

    public void Action()
    {
        _Render.material.EnableKeyword("_EMISSION");
        var PosY = Sea.transform.position.y;
        Sea.transform.DOMoveY(PosY-2,2f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using DG.Tweening;

public class Gimmick1 : MonoBehaviour
{
    /*
    Color TrueColor;
    Renderer _Render;

    public void Give(Color color)
    {
        TrueColor = color;
        Debug.Log(TrueColor);
    }

    private void Awake()
    {
        _Render = GetComponent<Renderer>();
        TrueColor = _Render.material.color;
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
        GetComponent<Animator>().enabled = true;
    }
    */
}

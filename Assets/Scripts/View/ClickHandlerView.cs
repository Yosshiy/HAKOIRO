using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;
using System.Linq;

public class ClickHandlerView : MonoBehaviour
{
    //ClickŠ´’mclass‚ÌList
    [SerializeField]List<ClickHandler> ClickHandlers;
    IReactiveProperty<Color> ColorData => ColorDatail;
    ReactiveProperty<Color> ColorDatail;
    ClickHandler OnClick = null;

    public void OnSerialize()
    {
        foreach (var list in ClickHandlers)
        {
            list.ReturnColor += (data) => OnClick = data;
        }
        /*
        var LList = ClickHandlers.Select(x => x.gameObject.GetComponent<Renderer>()).ToList();
        var CList = ClickHandlers.Select(x => x.gameObject.GetComponent<Renderer>().material.color).Reverse().ToList();

        for (int i = 0; i < LList.Count; i++)
        {
            LList[i].material.color = CList[i];
        }
        */
    }

    public void ReactiveSetColor(Color color)
    {
        ColorDatail.Value = color;
    }

    public void SetColor(Color color)
    {
        OnClick?.SetColor(color);
    }

    public void Action()
    {
        OnClick?.Action();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System.Linq;


public interface IGameStateView
{
    void OnInitialize();
    Image Image { get; }
}

public class GameStateView : MonoBehaviour,IGameStateView
{
    [SerializeField] Image Image;
    Image IGameStateView.Image => Image;


    void IGameStateView.OnInitialize()
    {
        
    }

    void ClearAction()
    {

    }
    
}

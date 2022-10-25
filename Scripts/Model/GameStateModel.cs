using UniRx;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine;
using System.Collections.Generic;
using System;
using Cysharp.Threading.Tasks;
using System.Threading;


public interface IGameStateModel
{
    
}

public class GameStateModel : IGameStateModel
{
    List<Color> TrueList;
    List<Material> ColorList;

    public bool IsGame { get; private set; } = false;

    /// <summary>
    /// ゲーム開始
    /// </summary>
    public void Begin()
    {
        if (IsGame) return;
        IsGame = true;
    }

    /// <summary>
    /// ゲーム終了
    /// </summary>
    public void Finish()
    {
        if (!IsGame) return;
        IsGame = false;
    }

    void Pouse()
    {
        Time.timeScale = 0;
    }

    void ReStart()
    {
        Time.timeScale = 1;
    }

    bool ClearFlag()
    {
        for (int i = 0; i < TrueList.Count; i++)
        {
            if (TrueList[i] != ColorList[i].color)
            {
                return false;
            }
        }

        return true;
    }
}

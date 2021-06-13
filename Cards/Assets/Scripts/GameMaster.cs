using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokerGameManager : MonoBehaviour
{
    enum GameState
    {

        Init = 0,
        Start,
        Deal,
        Bet,
        CardChange,
        ShowDown,
        Result
    }

    Private GameState gameState = GameState.Init;

//Update is called once per frame
void Update()
    
        switch (gameState)
        {
            case GameState.Init:
                //初期化するものがあれば初期化してstartへ
                gameState = GameState.Start;
                break;
            case GameState.Start:
                //STARTのときにしたいことを書く、終わればDealへ
                gameState = GameState.Deal;
                break;
            case GameState.Deal;
                //Dealのときにしたいことを書く、終わればBetへ
                GameState = GameState.Bet;
                break;
            case GameState.Bet:
                //Betのときにしたいことを書く、終わればCardChangeへ
                GameState = GameState.CardChange;
                break;
            case GameState.CardChange:
                //CardChangeのときにしたいことを書く、終わればShowDownへ
                GameState = GameState.ShowDown;
                break;
            case GameState.ShowDown;
                //ShowDown のときにしたいことを書く、終わればResultへ
                GameState = GameState.Result;
                break;
            case GameState.Result;
                break;
        }
}
}
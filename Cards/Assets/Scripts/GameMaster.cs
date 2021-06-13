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
                //������������̂�����Ώ���������start��
                gameState = GameState.Start;
                break;
            case GameState.Start:
                //START�̂Ƃ��ɂ��������Ƃ������A�I����Deal��
                gameState = GameState.Deal;
                break;
            case GameState.Deal;
                //Deal�̂Ƃ��ɂ��������Ƃ������A�I����Bet��
                GameState = GameState.Bet;
                break;
            case GameState.Bet:
                //Bet�̂Ƃ��ɂ��������Ƃ������A�I����CardChange��
                GameState = GameState.CardChange;
                break;
            case GameState.CardChange:
                //CardChange�̂Ƃ��ɂ��������Ƃ������A�I����ShowDown��
                GameState = GameState.ShowDown;
                break;
            case GameState.ShowDown;
                //ShowDown �̂Ƃ��ɂ��������Ƃ������A�I����Result��
                GameState = GameState.Result;
                break;
            case GameState.Result;
                break;
        }
}
}
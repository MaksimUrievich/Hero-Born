using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    public bool showLossScreen = false;
    public bool showWinScreen = false;
    public string lableText = "Collect all 4 items and win your freedom!";
    public int maxItems = 4;

    private int _playerHP = 10; 
    private int _itemsCollected = 0;

    public int Items
    {
        get{
            return _itemsCollected;
        }
        set{
            _itemsCollected = value;
            Debug.LogFormat("Items: {0}", _itemsCollected);
            if (_itemsCollected >= maxItems)
            {
                lableText = "You've found all the items!";
                showWinScreen = true;
                Time.timeScale = 0f;
            }
            else
            {
                lableText = "Item found , only " + (maxItems - _itemsCollected) + " more to go!";
            }
        }
    }

   
    public int HP
    {
        get
        {
           return _playerHP;
        }
        set
        {
           _playerHP = value;
           if(_playerHP <=0)
           {
               lableText = "You want another life with that?";
               showLossScreen = true;
               Time.timeScale = 0f;
           }
           else
           {
                lableText = "Ouch... that's got hurt.";
           }

        }
    }
    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Player Health:" + _playerHP);

        GUI.Box(new Rect(20, 50, 150, 25), "Items Collected:" + _itemsCollected);

        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), lableText);

        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 100), "You WON!"))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1.0f;
            }   
        }

        if(showLossScreen)
        {
            if(GUI.Button(new Rect(Screen.width/2 - 100, Screen.height/2 -50, 200,100), "You lose..."))
            {
                SceneManager.LoadScene(0);
                Time.timeScale = 1.0f;
            }
        }
    }
}

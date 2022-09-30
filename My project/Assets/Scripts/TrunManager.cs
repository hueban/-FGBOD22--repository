using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunManager : MonoBehaviour
{
    //the selected player
    private GameObject selectedPlayer;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    
    private scriptManager scriptMan;
    public void getScripts()
    {
        
        
        scriptMan = selectedPlayer.GetComponent<scriptManager>();
        scriptMan.Selected(true);
    }
    void Start()
    {
        selectedPlayer = player1;
        getScripts();
    }
    public void nextTurn()
    {
        if (selectedPlayer == player1)
        {
            selectedPlayer = player2;
            scriptMan.Selected(false);
            getScripts();
        }
        else
        {
            selectedPlayer = player1;
            scriptMan.Selected(false);
            getScripts();
        }
    }
    
}

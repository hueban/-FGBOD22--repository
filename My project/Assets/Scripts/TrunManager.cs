using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TrunManager : MonoBehaviour
{
    //the selected player
    private GameObject selectedPlayer;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    private bool waiting = false;
    [SerializeField] GameObject turnPanel;
    
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
    public void nextTurnWait()
    {
        waiting = true;
        scriptMan.waitingForTurn(true);
        turnPanel.SetActive(true);
    }
    public void nextTurn()
    {
        if (selectedPlayer == player1)
        {
            selectedPlayer = player2;
            scriptMan.Selected(false);
            getScripts();
            turnPanel.SetActive(false);
            
        }
        else
        {
            turnPanel.SetActive(false);
            selectedPlayer = player1;
            scriptMan.Selected(false);
            getScripts();
            
        }
    }
    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.T ) && waiting == true)
        {
            nextTurn();
            waiting = false;
        }
    }

}

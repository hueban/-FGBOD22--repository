using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptManager : MonoBehaviour
{
    // Start is called before the first frame update
    private bool selected = false;
    private bool waiting = false;
    [SerializeField] private GameObject player;
    private BasicEnemy enemyScript;
    private Shovel shovelScript;
    private Rzucannie throwScript;
    private PlayerMovment movementScript;
    private Energy energyScript;
    private NewBehaviourScript2 camScript;
   [SerializeField] private Camera camera;
    public void Selected(bool sel)
    {
        selected = sel;
        
    }
    public void waitingForTurn(bool wal)
    {
        waiting = wal;
    }
    void Start()
    {
        enemyScript = player.GetComponent<BasicEnemy>();
        shovelScript = player.GetComponent<Shovel>();
        throwScript = player.GetComponent<Rzucannie>();
        movementScript = player.GetComponent<PlayerMovment>();
        energyScript = player.GetComponent<Energy>();
        camScript = camera.GetComponent<NewBehaviourScript2>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!waiting && selected)
        {

            camera.enabled =true;
            movementScript.enableDisable(true);
            camScript.enableDisable(true);
            throwScript.enableDisable(true);
            shovelScript.enableDisable(true);
        }
        else
        {
            if (!selected)
            {
                waiting = false;
                camera.enabled = false;
            }
            movementScript.enableDisable(false);
            camScript.enableDisable(false);
            throwScript.enableDisable(false);
            shovelScript.enableDisable(false);
        }
    }
}

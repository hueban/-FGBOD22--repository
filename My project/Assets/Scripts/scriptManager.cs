using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptManager : MonoBehaviour
{
    // Start is called before the first frame update
    private bool selected = false;
    [SerializeField] private GameObject player;
    private BasicEnemy enemyScript;
    private Shovel shovelScript;
    private Rzucannie cameraScript;
    private PlayerMovment movementScript;
    private Energy energyScript;
    public void Selected(bool sel)
    {
        selected = sel;
    }
    void Start()
    {
        enemyScript = player.GetComponent<BasicEnemy>();
        shovelScript = player.GetComponent<Shovel>();
        cameraScript = player.GetComponent<Rzucannie>();
        movementScript = player.GetComponent<PlayerMovment>();
        energyScript = player.GetComponent<Energy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (selected)
        {
            movementScript.enableDisable(true);
        }
        else
        {
            movementScript.enableDisable(false);
        }
    }
}

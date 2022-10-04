using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobRotationScript : MonoBehaviour
{
    public GameObject cameraBoba;
    void Update()
    {
        Vector3 temp = cameraBoba.transform.localRotation.eulerAngles;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, temp.y+90, 0));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobRotationScript2 : MonoBehaviour
{
    public GameObject cameraBoba;
    void Update()
    {
        Vector3 temp = cameraBoba.transform.localRotation.eulerAngles;
        gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay : MonoBehaviour
{

    public Transform myPrefab;
    GameObject[] collectiblearr;
    GameObject go;
    public Transform RemainingTransform;
    public int ammocount = 0;

    // Start is called before the first frame update
    void Start()
    {
        ammoprefab();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && ammocount < collectiblearr.Length)
        {
            Destroy(collectiblearr[ammocount]);
            Debug.Log("Destroy" + ammocount);
            ammocount++;
        }

        if (ammocount >= collectiblearr.Length)
        {
            Debug.Log("You Lose");
        }
    }


    public void ammoprefab()
    {
        collectiblearr = new GameObject[5];
        for (int i = 0; i < 5; i++)
        {
            var position = new Vector3(-80 + i * 30, 260, 0);
            go = (Instantiate(myPrefab, position, Quaternion.identity)).gameObject;
            collectiblearr[i] = go;
            collectiblearr[i].transform.SetParent(RemainingTransform, false);
        }
    }
}

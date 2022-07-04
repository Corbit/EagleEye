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

    public GameObject GameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        ammoprefab();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale != 0)
        {
            if (Input.GetButtonDown("Fire1") && ammocount < collectiblearr.Length)
            {
                Destroy(collectiblearr[ammocount]);
                ammocount++;
            }

            if (ammocount >= collectiblearr.Length)
            {
                GameOverScreen.SetActive(true);
                Time.timeScale = 0f;
            }
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

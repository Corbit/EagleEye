using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Overlay : MonoBehaviour
{

    public Transform myPrefab;
    GameObject[] ammocountarr;
    GameObject go;
    public Transform RemainingTransform;
    public int ammocount = 0;

    public Transform setTargetprefab;
    public Transform setProtectedprefab;

    public GameObject GameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        ammoprefab();
        Targetprefab();
        Protectedprefab();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale != 0)
        {
            if (Input.GetButtonDown("Fire1") && ammocount < ammocountarr.Length)
            {
                Destroy(ammocountarr[ammocount]);
                ammocount++;
            }

            if (ammocount >= ammocountarr.Length)
            {
                GameOverScreen.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }


    public void ammoprefab()
    {
        ammocountarr = new GameObject[5];
        for (int i = 0; i < 5; i++)
        {
            var position = new Vector3(-80 + i * 30, 260, 0);
            go = (Instantiate(myPrefab, position, Quaternion.identity)).gameObject;
            ammocountarr[i] = go;
            ammocountarr[i].transform.SetParent(RemainingTransform, false);
        }
    }

    public void Targetprefab()
    {
        var position = new Vector3(0, 50, 0);
        go = (Instantiate(setTargetprefab, position, Quaternion.identity)).gameObject;
        
        go.transform.SetParent(RemainingTransform, false);
    }

    public void Protectedprefab()
    {
        var position = new Vector3(0,-170, 0);
        go = (Instantiate(setProtectedprefab, position, Quaternion.identity)).gameObject;
        
        go.transform.SetParent(RemainingTransform, false);
    }
}

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
    int ammocount = 0;
    Shooting shooting;
    public Transform RemainingTransform;
    public Transform setTargetprefab;
    //public Transform setProtectedprefab;

   // public GameObject GameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        shooting = GameObject.Find("Player").GetComponent<Shooting>();
        ammoprefab();
        Targetprefab();
        //Protectedprefab();
    }

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetButtonDown("Fire1") && ammocount < ammocountarr.Length)
            {
                Destroy(ammocountarr[ammocount]);
                ammocount++;
            }

            /* if (ammocount >= ammocountarr.Length)
            {
                GameOverScreen.SetActive(true);
                Debug.Log("Lose");
                Time.timeScale = 0f;
            } */
        
    }


    public void ammoprefab()
    {
        ammocountarr = new GameObject[shooting.magazine];
        for (int i = 0; i < ammocountarr.Length; i++)
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

    /* public void Protectedprefab()
    {
        var position = new Vector3(0,-170, 0);
        go = (Instantiate(setProtectedprefab, position, Quaternion.identity)).gameObject;
        
        go.transform.SetParent(RemainingTransform, false);
    } */
}

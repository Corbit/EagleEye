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
    int currentMagazineSize;
    public Transform RemainingTransform;
    public Transform setTargetprefab;
    public Transform setProtectedprefab1;
    public Transform setProtectedprefab2;
    

    /// public GameObject GameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        shooting = GameObject.FindGameObjectWithTag("Player").GetComponent<Shooting>();
        ammoprefab();
        Targetprefab();
        Protectedprefab();
        currentMagazineSize = shooting.magazine;
    }

    /*
        checks if how much ammo is left and updates the view   
    */    void Update()
    {
        
            if ( shooting.magazine < currentMagazineSize && ammocount < ammocountarr.Length)
            {
                Destroy(ammocountarr[ammocount]);
                ammocount++;
                currentMagazineSize--;
            }        
    }


    //Overlay Munition Bild
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

    //Overlay Target Bild
    public void Targetprefab()
    {
        var position = new Vector3(0, 50, 0);
        go = (Instantiate(setTargetprefab, position, Quaternion.identity)).gameObject;
        
        go.transform.SetParent(RemainingTransform, false);
    }

    //Overlay Protected Bild
    public void Protectedprefab()
    {
        var position = new Vector3(0,-170, 0);
        go = (Instantiate(setProtectedprefab1, position, Quaternion.identity)).gameObject;
        
        go.transform.SetParent(RemainingTransform, false);
    }
}

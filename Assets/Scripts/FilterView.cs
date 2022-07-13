using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterView : MonoBehaviour
{
    private string obstacle = "Obstacle";
    private string map = "Base";
    private string player = "Player";
    private string target = "Target_Hit";
    private string animal_1 = "Animal_1";
    private string animal_2 = "Animal_2";
    private string animal_3 = "Animal_3";
    private string animal_4 = "Animal_4";


    public GameObject dispmap;
    public GameObject disptarget;
    public GameObject dispplayer;
    public GameObject dispprotected;

    // Start is called before the first frame update
    void Start()
    {
        hideAll();
        display(player);
    }

    // Update is called once per frame
    void Update()
    {
        //Map
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            hideAll();
            display(map);
            display(obstacle);
            dispmap.SetActive(true);
            disptarget.SetActive(false);
            dispplayer.SetActive(false);
            dispprotected.SetActive(false);
        }
    
        //Target
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            hideAll();
            display(target);
            disptarget.SetActive(true);
            dispmap.SetActive(false);
            dispplayer.SetActive(false);
            dispprotected.SetActive(false);
        }
        //Player
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {          
            hideAll();
            display(player);
            dispplayer.SetActive(true);
            dispmap.SetActive(false);
            disptarget.SetActive(false);
            dispprotected.SetActive(false);
        }
        //Animal 1

        if (Input.GetKeyDown(KeyCode.Alpha4)) {
            hideAll();
            display(animal_1);
            dispprotected.SetActive(true);
            dispplayer.SetActive(false);
            dispmap.SetActive(false);
            disptarget.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            hideAll();
            display(animal_2);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            hideAll();
            display(animal_3);
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            hideAll();
            display(animal_4);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            displayAll();
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {

            hideAll();
        }
    }

    void hide(string type) {
        foreach(GameObject go in GameObject.FindGameObjectsWithTag(type)) {          
             go.GetComponent<Renderer>().enabled = false;
        }
    }

    void display(string type) {
        foreach(GameObject go in GameObject.FindGameObjectsWithTag(type)) {          
             go.GetComponent<Renderer>().enabled = true;
        }
    }

    void displayAll() {
        display(map);
        display(obstacle);
        display(player);
        display(target);
        display(animal_1);
        display(animal_2);
        display(animal_3);
        display(animal_4);
    }

    void hideAll() {
        hide(map);
        hide(obstacle);
        hide(player);
        hide(target);
        hide(animal_1);
        hide(animal_2);
        hide(animal_3);
        hide(animal_4);
    }
}

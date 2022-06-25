using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterView : MonoBehaviour
{
    private string obstacle = "Obstacle";
    private string map = "Base";
    private string player = "Player";

    // Start is called before the first frame update
    void Start()
    {
        hide(obstacle);
        hide(map);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Map
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {          
            hide(player);
            hide(obstacle);
            display(map);
        }
        //Obstacle
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {          
           hide(player);
           hide(map);
           display(obstacle);
            
        }
        //Target
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {          
           
            
        }
        //Player
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {          
           hide(map);
           hide(obstacle);
           display(player);
            
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
    }

    void hideAll() {
        hide(map);
        hide(obstacle);
        hide(player);
    }
}

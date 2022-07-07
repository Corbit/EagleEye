using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FilterView : MonoBehaviour
{
    private string obstacle = "Obstacle";
    private string map = "Base";
    private string player = "Player";

    private string target = "Target_Hit";

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
            hide(player);
            hide(target);
            display(obstacle);
            display(map);
        }
    
        //Target
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {          
           hide(player);
           hide(obstacle);
           hide(map);
           display(target);
            
        }
        //Player
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {          
           hide(map);
           hide(obstacle);
           hide(target);
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
        hide(target);
    }
}

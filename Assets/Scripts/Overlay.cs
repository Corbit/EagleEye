using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay : MonoBehaviour
{

    public Transform myPrefab;
    GameObject[] collectiblearr;
    GameObject go;
    public Transform RemainingTransform;
    // Start is called before the first frame update
    void Start()
    {
        collectiblearr = new GameObject[5];
        for (int i = 0; i < 5; i++)
        {
            var position = new Vector3(450 + i * 30, 140, 0);
            go = (Instantiate(myPrefab, position, Quaternion.identity)).gameObject;
            collectiblearr[i] = go;
            collectiblearr[i].transform.parent = RemainingTransform;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

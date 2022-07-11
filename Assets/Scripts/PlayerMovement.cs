using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    //public float moveSpeed = 5f;

    //Wenn das Script eh am Player hängt, muss man das Objekt nicht extra importieren
    //public Rigidbody2D rb;
    
    [SerializeField] public Camera cam;
    Vector3 mousePos;
    // Update is called once per frame
    void Update()
    {
       mousePos = cam.ScreenToWorldPoint(Input.mousePosition); 
    }

    private void FixedUpdate()
    {
        Vector3 lookDir = mousePos - transform.position;
        lookDir.Normalize();
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        
        transform.rotation = Quaternion.Euler(0,0,angle);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowThePath : MonoBehaviour
{


    // Array of waypoints to walk from one to the next one
    [SerializeField]
    private Vector3[] waypoints;

    // Walk speed that can be set in Inspector
    [SerializeField]
    private float moveSpeed = 2f;



    // Index of current waypoint from which Enemy walks
    // to the next one
    private int waypointIndex = 0;

    // Use this for initialization
    private void Start()
    {

        // Set position of Enemy as position of the first waypoint
        transform.position = waypoints[waypointIndex];
    }

    // Update is called once per frame
    private void Update()
    {

        // Move Enemy
        Move();
    }

    
    private void Move()
    {
        
        
            // If Enemy didn't reach last waypoint it can move
            // If enemy reached last waypoint then it stops
            if (waypointIndex <= waypoints.Length - 1)
            {

                // Move Enemy from current waypoint to the next one
                // using MoveTowards method
                transform.position = Vector2.MoveTowards(transform.position,
                   waypoints[waypointIndex],
                   moveSpeed * Time.deltaTime);

                // If Enemy reaches position of waypoint he walked towards
                // then waypointIndex is increased by 1
                // and Enemy starts to walk to the next waypoint
                if (transform.position == waypoints[waypointIndex])
                {
                    waypointIndex += 1;
                }
            if (waypointIndex == waypoints.Length )
            { waypointIndex = 0; }
            }
                // If the last waypoint is identical to the first waypoint, it loops
    }
}

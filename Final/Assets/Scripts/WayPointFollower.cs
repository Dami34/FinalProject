using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointFollower : MonoBehaviour
{
    [SerializeField] GameObject[] wayPs; // Array of waypoints
    int currentWayP = 0; // Index of current waypoint
    [SerializeField] float speed = 1f; // Speed of object between waypoints

    void Update()
    {
        // Check waypoint object is moving to next and change waypoint index
        if(Vector3.Distance(transform.position, wayPs[currentWayP].transform.position) < .1f)
        {
            currentWayP++;

            // If current waypoint is beyond the array, start again at the beginning of the array
            if(currentWayP >= wayPs.Length)
            {
                currentWayP = 0;
            }
        }

        // Moves object between waypoints
        transform.position = Vector3.MoveTowards(transform.position, wayPs[currentWayP].transform.position, speed * Time.deltaTime);
    }
}
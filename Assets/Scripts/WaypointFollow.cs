using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    //Checks for the waypoint object as well as which waypoint the platform/enemy is at. Drag ingame waypoints into the serialized field to allow the platform/enemy to move to them
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;

    //Average speed of the platform/enemy moving to the waypoints, can be changed
    [SerializeField] private float speed = 2f;

    private void Update()
    {

        //Actually moves to each waypoint. Don't ask me what the individual lines do, I have no idea
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}

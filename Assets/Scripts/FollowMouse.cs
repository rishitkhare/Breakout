using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* This is a script that will aid in testing the collision script,
* since we haven't created the bouncing script yet.
*/

public class FollowMouse : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        //this code doesn't work for some reason, so I have to do this other shit
        //transform.position = Input.mousePosition;

        //records mouseposition relative to game window
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //ignores Z-component because of 2-D
        transform.position = new Vector3(newPosition.x, newPosition.y, 0);
    }
}

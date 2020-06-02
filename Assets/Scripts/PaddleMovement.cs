using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(0, -3.5f, 0);
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(myPos.x, -3.5f, 0);

    }
}

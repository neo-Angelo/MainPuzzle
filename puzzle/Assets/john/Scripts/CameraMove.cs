using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private Vector3 cameraPosition;
    public float cameraSpeed = 1;

    private void Start()
    {
        cameraPosition = this.transform.position;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            cameraPosition.z += cameraSpeed / 10;
        }
        if (Input.GetKey(KeyCode.S))
        {
            cameraPosition.z -= cameraSpeed / 10;
        }
        if (Input.GetKey(KeyCode.A))
        {
            cameraPosition.x -= cameraSpeed / 10;
        }
        if (Input.GetKey(KeyCode.D))
        {
            cameraPosition.x += cameraSpeed / 10;
        }

        this.transform.position = cameraPosition;
    }
}

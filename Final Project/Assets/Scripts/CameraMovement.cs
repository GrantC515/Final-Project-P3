using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform player;
    public Vector3 offset;
 // Update is called once per frame
    void Update () {
     transform.position = player.position + offset;
     //if (Input.GetMouseButton(1))
     {
      float mouseX = Input.GetAxis("Mouse X");
     float mouseY = Input.GetAxis("Mouse Y");
     Vector3 lookhere = new Vector3(-mouseY, mouseX, 0);
      transform.Rotate(lookhere);
     }
    }    
}

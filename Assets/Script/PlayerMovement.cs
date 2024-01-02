using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Camera cam;
    public LayerMask groundMask;
    public PlayerAnimation playerAnim;
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray,out hit,groundMask))
            {
                Debug.Log(hit.collider.name);   // แสดงชื่อวัตถุที่เราคลิ๊ก
            }
        }
    }
}

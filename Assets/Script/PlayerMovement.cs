using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Camera cam;
    public LayerMask groundMask;
    public PlayerAnimation playerAnim;
    public GameObject inventoryUI;

    public GameObject axe;
    public bool showAxe = false;
    public bool isAttack = false;
    public static PlayerMovement instance;

    private void Awake()
    {
        instance = this;
    }
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
                if (!inventoryUI.activeSelf)
                {
                    playerAnim.MovetoPoint(hit.point);
                }
            }
        }
    }

    public void ShowAxe()
    {
        axe.SetActive(true);
        showAxe = true;
    }
}

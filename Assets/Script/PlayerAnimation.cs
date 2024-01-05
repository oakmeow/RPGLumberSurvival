using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimation : MonoBehaviour
{
    Transform target = null;
    public Animator anim;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void MovetoPoint(Vector3 point)
    {
        agent.SetDestination(point);
    }

    void Update()
    {
        float speed = agent.velocity.magnitude / agent.speed; // ความเร็วการเคลื่อนที่
        if (speed > 0)
        {
            anim.SetBool("isWalk", true);
        }
        else
        {
            anim.SetBool("isWalk", false);
        }

        if (target!=null)
        {
            MovetoPoint(target.position);
        }

        if (Input.GetMouseButtonDown(1) && PlayerMovement.instance.showAxe)
        {
            if (!InventoryUI.instance.inventoryUI.activeSelf)
            {
                anim.SetTrigger("Attack");
                PlayerMovement.instance.isAttack = true;
            }
        }

        if (Input.GetMouseButtonUp(1) && PlayerMovement.instance.showAxe)
        {
            if (!InventoryUI.instance.inventoryUI.activeSelf)
            {
                PlayerMovement.instance.isAttack = false;
            }
        }
    }
}

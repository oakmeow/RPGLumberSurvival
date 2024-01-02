using System.Collections;
using System.Collections.Generic;
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
        // เคลื่อนที่
        bool isWalk = (speed > 0) ? true : false;
        anim.SetBool("isWalk",isWalk);

        /*if (speed > 0)
        {
            anim.SetBool("isWalk", true);
        }
        else
        {
            anim.SetBool("isWalk", false);
        }*/

        if (target!=null)
        {
            MovetoPoint(target.position);
        }
    }
}

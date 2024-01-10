using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SheepController : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    public float distancePlayer = 4f;
    private Animator anim;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);
        if (distance < distancePlayer)
        {
            Vector3 dirToPlayer = transform.position - player.transform.position;   // วิ่งหนีในระยะของผู้เล่นกับแกะ
            Vector3 newPos = transform.position + dirToPlayer;
            agent.SetDestination(newPos);
            anim.SetBool("walk",true);
        }
        else
        {
            anim.SetBool("walk", false);
        }
    }
}

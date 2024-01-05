using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Axe")
        {
            if (PlayerMovement.instance.isAttack==true)
            {
                GetComponent<Animator>().SetTrigger("die");
            }
        }
    }
}

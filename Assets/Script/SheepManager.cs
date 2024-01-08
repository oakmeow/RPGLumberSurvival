using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepManager : MonoBehaviour
{
    public GameObject[] items;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Axe")
        {
            if (PlayerMovement.instance.isAttack==true)
            {
                GetComponent<Animator>().SetTrigger("die");
                Invoke("SpawnItem", 0.5f);
            }
        }
    }

    void SpawnItem()
    {
        foreach(var item in items)
        {
            item.SetActive(true);
        }

        Destroy(GetComponent<SphereCollider>());
        transform.Find("sheep_mesh").GetComponent<SkinnedMeshRenderer>().enabled = false;
    }
}

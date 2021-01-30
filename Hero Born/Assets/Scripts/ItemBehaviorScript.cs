using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviorScript : MonoBehaviour
{

    void OnCollisionEnter (Collision col)
    {
        if(col.gameObject.name == "Player")
        {
            Destroy(transform.parent.gameObject);
            Debug.Log("Item Collected");


        }

    }

}

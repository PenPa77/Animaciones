using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            if(!Input.GetKey("w"))
            {
                anim.SetBool("isWalking", false);

            }
        }
    }
}

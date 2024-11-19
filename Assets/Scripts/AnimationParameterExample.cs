using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationParameterExample : MonoBehaviour
{
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
       
        animator.SetBool("StartWalking", true);
    }

    // Update is called once per frame
    void Update()
    {
      //  animator.SetFloat("WalkSpeed", 3f);

        //animator.Play("Pick ingrediants");

    }
}

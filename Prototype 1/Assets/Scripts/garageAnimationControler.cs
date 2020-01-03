using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garageAnimationControler : MonoBehaviour
{
    public Animator anim;
    public bool jest = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q") && jest == false)
        {
            anim.enabled = false;
            anim.enabled = true;
            anim.Play("garageAnimation");
            jest = true;
        }
        else if(Input.GetKeyDown("q") && jest == true)
        {
            anim.enabled = false;
            jest = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.5f;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool isWalking = false;

        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxis("Vertical");
        
        if (mv > 0 || mv < 0)
        {
            if(mv > 0)
            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
                mv = -mv;
            }

            //this.transform.Translate(0, 0, mv *speed);
            this.transform.Translate(0, 0, mv *speed);
            isWalking = true;
        }

        if (mh > 0 || mh < 0)
        {
            if (mh > 0)
            {
                this.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
            else
            {
                this.transform.rotation = Quaternion.Euler(0, -90, 0);
                mh = -mh;
            }

            //this.transform.Translate(mh * speed, 0, 0);
            this.transform.Translate(0, 0, mh * speed);
            isWalking = true;
        }

        animator.SetBool("isWalking", isWalking);
    }
}

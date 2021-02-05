using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovement : MonoBehaviour
{
    public float movePower = 1f;
    Animator animator;
    Vector3 movement;
    int movementFlag = 0;

    void Start()

    {
        animator = gameObject.GetComponentInChildren<Animator>();

        StartCoroutine("ChangeMovement");
    }

    IEnumerator ChangeMovement()
    {
        Debug.Log("Front Logic : " + Time.time);
        yield return new WaitForSeconds(5f);
        Debug.Log("behind Logic : " + Time.time);
    }
    void FixedUpdate ()
    {
        Move();
    }
    void Move ()
    {
        Vector3 moveVelocity = Vector3.zero;
        if (movementFlag == 1)
        {
            moveVelocity = Vector3.left;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (movementFlag == 2)
        {
            moveVelocity = Vector3.right;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        transform.position += moveVelocity * movePower * Time.deltaTime;
    }
}

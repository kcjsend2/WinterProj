using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerDir
{ 
    Left = 0,
    LeftUp,
    Up,
    RightUp,
    Right,
    RightDown,
    Down,
    LeftDown
}

public class PlayerBehavior : MonoBehaviour
{
    private Animator m_animator;
    private PlayerDir dir;

    private void Awake()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            dir = PlayerDir.Left;
            if(Input.GetKeyDown(KeyCode.S))
            {
                dir = PlayerDir.LeftDown;
            }
            else if(Input.GetKeyDown(KeyCode.W))
            {
                dir = PlayerDir.LeftUp;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            dir = PlayerDir.Right;
            m_animator.SetBool("WalkRight", true);
            m_animator.SetBool("WalkDown", false);
            if (Input.GetKeyDown(KeyCode.S))
            {
                dir = PlayerDir.RightDown;
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                dir = PlayerDir.RightUp;
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            dir = PlayerDir.Down;
            m_animator.SetBool("WalkDown", true);
            m_animator.SetBool("WalkRight", false);
            if (Input.GetKeyDown(KeyCode.A))
            {
                dir = PlayerDir.LeftDown;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                dir = PlayerDir.RightDown;
            }
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            dir = PlayerDir.Up;
            if (Input.GetKeyDown(KeyCode.A))
            {
                dir = PlayerDir.LeftUp;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                dir = PlayerDir.RightUp;
            }
        }

    }
}

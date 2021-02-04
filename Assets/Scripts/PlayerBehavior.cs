using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerDir
{ 
    neutral = 0,
    Left,
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
    private PlayerDir prevDir;

    private void Awake()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.W))
        {
            m_animator.SetInteger("WalkDir", (int)PlayerDir.neutral);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            m_animator.SetInteger("WalkDir", (int)PlayerDir.Left);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            m_animator.SetInteger("WalkDir", (int)PlayerDir.Right);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            m_animator.SetInteger("WalkDir", (int)PlayerDir.Down);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            m_animator.SetInteger("WalkDir", (int)PlayerDir.Up);
        }

        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.A))
        {
            m_animator.SetInteger("WalkDir", (int)PlayerDir.LeftUp);
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.D))
        {
            m_animator.SetInteger("WalkDir", (int)PlayerDir.RightUp);
        }
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.A))
        {
            m_animator.SetInteger("WalkDir", (int)PlayerDir.LeftDown);
        }
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.D))
        {
            m_animator.SetInteger("WalkDir", (int)PlayerDir.RightDown);
        }
    }
}

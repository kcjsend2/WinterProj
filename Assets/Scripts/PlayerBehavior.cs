using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerHdir
{ 
    neutral = 0,
    Left,
    Right,
}

public enum PlayerVdir
{
    neutral = 0,
    Up,
    Down,
}

public class PlayerBehavior : MonoBehaviour
{
    private Animator m_animator;
    private Queue m_keyQueue = new Queue();
    private PlayerHdir m_hdir = 0;
    private PlayerVdir m_vdir = 0;
    private PlayerHdir m_prev_hdir = 0;
    private PlayerVdir m_prev_vdir = 0;

    private void Awake()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        KeyEvent();
        PlayerMove();
    }
    private void KeyEvent()
    {
        m_keyQueue.Enqueue(Input.inputString);
    }

    private void PlayerMove()
    {
        switch (m_keyQueue.Dequeue())
        {
            case "W":
            case "w":
                m_vdir = PlayerVdir.Up;
                break;

            case "A":
            case "a":
                m_hdir = PlayerHdir.Left;
                break;

            case "S":
            case "s":
                m_vdir = PlayerVdir.Down;
                break;

            case "D":
            case "d":
                m_hdir = PlayerHdir.Right;
                break;
        }

        if(m_prev_hdir != m_hdir)
            m_animator.SetInteger("WalkHdir", (int)m_hdir);

        if(m_prev_vdir != m_vdir)
            m_animator.SetInteger("WalkVdir", (int)m_vdir);

        if (!Input.anyKeyDown)
        {
            m_hdir = PlayerHdir.neutral;
            m_vdir = PlayerVdir.neutral;
        }

        m_prev_hdir = m_hdir;
        m_prev_vdir = m_vdir;
    }
}

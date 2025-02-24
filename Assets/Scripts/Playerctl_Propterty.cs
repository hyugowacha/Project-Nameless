using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Animations;


public partial class PlayerController : MonoBehaviour
{
    public Animator PlayerAnimator
    {
        get { return playerAnimator; }
        set { playerAnimator = value; }
    }

    public float MaxWatingTime
    {
        get { return maxWatingTime; }
        set { maxWatingTime = value; }
    }

    public bool AttackOn
    {
        get { return attackOn; }
        set { attackOn = value; }
    }

    public bool DashOn
    {
        get { return dashOn; }
        set { dashOn = value; }
    }

    public bool JumpOn
    {
        get { return jumpOn; }
        set { jumpOn = value; }
    }

    public Vector3 MoveDir
    {
        get { return moveDir; }
        set { moveDir = value; }
    }

    public Vector2 Dir
    {
        get { return dir; }
        set { dir = value; }
    }



    public AnimatorStateInfo AnimationInfo
    {
        get { return animationInfo; }
        set { animationInfo = value; }
    }

    public Rigidbody Rigid
    {
        get { return rigid; }
        set { rigid = value; }
    }

    public GameObject PlayerWeapon
    {
        get { return playerWeapon; }
        set { playerWeapon = value; }
    }


    public float TurnSpeed
    {
        get { return turnSpeed; }
        set
        {
            if (turnSpeed > 50.0f || turnSpeed < 1.0f)
            {
                turnSpeed = 20.0f;
            }

            else
            {
                turnSpeed = value;
            }

        }
    }

    public float MoveSpeed
    {
        get { return moveSpeed; }
        set
        {
            if (moveSpeed > 8.0f)
            {
                moveSpeed = 8.0f;
            }
            else
            {
                moveSpeed = value;
            }
        }
    }



}

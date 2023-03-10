using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 8f;
    [SerializeField] private float leftRightSpeed = 4f;
    public static bool canMove = false;

    private bool isMoving = false;

    private bool isJumping = false;
    private bool comingDown = false;
    public GameObject playerObject;

    public GameObject playerModel;
    public Animator animator;

    //get key
    private bool pressForward1;
    private bool pressForward2;
    private bool pressLeft1;
    private bool pressLeft2;
    private bool pressRight1;
    private bool pressRight2;
    private bool pressJump;


    // Update is called once per frame
    private void Update()
    {
        this.GetKey();
        this.GetKeyInputMoving();
    }


    protected virtual void GetKey()
    {
        //get run forward key
        pressForward1 = Input.GetKey(KeyCode.W);
        pressForward2 = Input.GetKey(KeyCode.UpArrow);
        //get left key
        pressLeft1 = Input.GetKey(KeyCode.A);
        pressLeft2 = Input.GetKey(KeyCode.LeftArrow);
        //get right key
        pressRight1 = Input.GetKey(KeyCode.D);
        pressRight2 = Input.GetKey(KeyCode.RightArrow);

        //get jump key
        pressJump = Input.GetKey(KeyCode.Space);
    }



    protected virtual void GetKeyInputMoving()
    {
        //OnStartGame
        if (canMove)
        {
            //move forward
            if (pressForward1 || pressForward2)
            {
                transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
                animator.SetBool("isRun", true);
                isMoving = true;
            }
            else
            {
                isMoving = false;
            }



            //move left
            if (pressLeft1 || pressLeft2)
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                    animator.SetBool("isRun", true);
                    isMoving = true;
                }
                else
                {
                    isMoving = false;
                }

            }
            


            //move right
            if (pressRight1 || pressRight2)
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                    animator.SetBool("isRun", true);
                    isMoving = true;
                }
                else
                {
                    isMoving = false;
                }

            }

            //jump
            if (pressJump)
            {
                if(isJumping == false)
                {
                    isJumping = true;
                    animator.SetBool("isJump", true);
                    StartCoroutine(JumpSequence());
                }
            }

            if (isJumping == true)
            {
                if(comingDown == false)
                {
                    transform.Translate(Vector3.up * Time.deltaTime * 4, Space.World);
                }
                if (comingDown == true)
                {
                    transform.Translate(Vector3.up * Time.deltaTime * -4, Space.World);
                    StartCoroutine(SetPosition());
                }
                

            }


            //idle
            if (!isMoving)
            {
                animator.SetBool("isRun", false);
            }

        }

    }

    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        comingDown = true;

        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;

        animator.SetBool("isJump", false);
    }

    IEnumerator SetPosition()
    {
        yield return new WaitForSeconds(0.45f);
        //set transform.position
        if (playerObject.transform.position.y > 2)
        {
            playerObject.transform.position += new Vector3(0, -playerObject.transform.position.y, 0);
            playerObject.transform.position += new Vector3(0, 2, 0);
        }

        if (playerObject.transform.position.y < 2)
        {
            playerObject.transform.position += new Vector3(0, -playerObject.transform.position.y, 0);
            playerObject.transform.position += new Vector3(0, 2, 0);
        }

    }
}

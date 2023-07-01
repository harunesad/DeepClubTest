using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public static Movement move;
    //Animator anim;
    //CharacterController characterController;
    public GameObject eye;
    public LayerMask buildLayer;
    public LayerMask sceneLayer;
    //float posX, posZ;
    //Vector3 movement, velocity;
    //float speed, gravity;
    private void Awake()
    {
        move = this;
        //characterController = GetComponent<CharacterController>();
        //anim = GetComponent<Animator>();

        //speed = 4;
        //gravity = .5f;
    }
    void Start()
    {
        
    }
    void Update()
    {
        //bool walk = false;
        //bool backWalk = false;
        //posX = Input.GetAxis("Horizontal");
        //posZ = Input.GetAxis("Vertical");
        //if (posZ > 0)
        //{
        //    walk = true;
        //    backWalk = false;
        //}
        //else if(posZ < 0)
        //{
        //    walk = false;
        //    backWalk = true;
        //}
        //else
        //{
        //    walk = false;
        //    backWalk = false;
        //}
        //anim.SetBool("Walk", walk);
        //anim.SetBool("BackWalk", backWalk);
    }
    private void FixedUpdate()
    {
        //if (characterController.isGrounded)
        //{
        //    velocity.y = 0;
        //}
        //else
        //{
        //    velocity.y -= gravity * Time.deltaTime;
        //}
        //movement = characterController.transform.forward * posZ;
        //if (posZ != 0)
        //{
        //    characterController.transform.Rotate(Vector3.up * posX * 100 * Time.deltaTime);
        //}
        //characterController.Move(movement * speed * Time.deltaTime);
        //characterController.Move(velocity);
    }
}

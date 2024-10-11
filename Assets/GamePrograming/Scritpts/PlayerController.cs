using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator anim;

    private float speed = 5;
    public float sensitivity = 2.0f;
    private void Update()
    {
        anim.SetFloat("move",Mathf.Abs(Input.GetAxis("Vertical"))+Mathf.Abs(Input.GetAxis("Horizontal")));
       
        
        // WSAD 키 입력을 받아 이동 처리
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-horizontalInput, 0f, -verticalInput) * speed * Time.deltaTime;
        transform.Translate(movement);
        
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // 마우스의 이동에 따라 캐릭터를 회전시킴
        transform.Rotate(Vector3.up * mouseX * sensitivity);
        
        
    }
}

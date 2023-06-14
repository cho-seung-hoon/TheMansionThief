using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private void Start()
    {
     
    }

    private bool isColliding = false;
    public float speed = 2f; // 이동 속도

    private void Update()
    {
        if (!isColliding) { 
            float moveHorizontal = Input.GetAxis("Horizontal"); // 수평 이동 입력(-1: A, 1: D)
            float moveVertical = Input.GetAxis("Vertical"); // 수직 이동 입력(-1: S, 1: W)
                                                        // 카메라의 전방 벡터 가져오기
            Vector3 cameraForward = Camera.main.transform.forward;
            cameraForward.y = 0f; // 수직 방향의 이동은 제한

            // 입력값과 카메라의 전방 벡터를 곱하여 이동 방향 설정
            Vector3 movement = (moveVertical * cameraForward + moveHorizontal * Camera.main.transform.right).normalized;

            // 플레이어 이동
            transform.Translate(movement * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // S키를 누르면 충돌 상태에서 빠져나오기
            isColliding = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            isColliding = true; // 충돌 상태 설정
            Debug.Log("Collision with Untagged object");
            GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            isColliding = false; // 충돌 상태 해제
            Debug.Log("Collision with Untagged object ended");
        }
    }
}
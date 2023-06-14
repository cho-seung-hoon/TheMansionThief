using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairInteraction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject stairObject;
    public Vector3 targetPosition = new Vector3(-7.9f, 3.5f, 2.2f); // 목표 위치
    public Vector3 mintargetPosition = new Vector3(-8.0f, 4.0f, 2.0f);
    public Vector3 maxtargetPosition = new Vector3(-7.0f, 3.0f, 3.0f);
    public Vector3 initialPosition = new Vector3(-4.0f, 0.5f, -0.1f); // 초기 위치
    public Vector3 mininitialPosition = new Vector3(-4.5f, 0f, -0.2f);
    public Vector3 maxinitialPosition = new Vector3(-3.5f, 1f, 0f);

    private bool isFacingStair = false;

    private void Update()
    {
        if (isFacingStair)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if ((transform.position.x > mininitialPosition.x && transform.position.z > mininitialPosition.z) && (transform.position.x < maxinitialPosition.x && transform.position.z < maxinitialPosition.z))
                {
                    TeleportToTargetPosition(targetPosition);
                }
                else if ((transform.position.x > mintargetPosition.x && transform.position.z > mintargetPosition.z) && (transform.position.x < maxtargetPosition.x && transform.position.z < maxtargetPosition.z))
                {
                    TeleportToTargetPosition(initialPosition);
                }
            }
        }
        LateUpdate();
    }

    private void TeleportToTargetPosition(Vector3 position)
    {
        // 플레이어 오브젝트의 위치를 목표 위치로 순간이동시킵니다.
        transform.position = position;
    }
    private void LateUpdate()
    {
        isFacingStair = CheckIfFacingStair();
    }
    private bool CheckIfFacingStair()
    {
        // 플레이어 오브젝트가 계단을 바라보고 있는지 여부를 체크합니다.
        Vector3 cameraDirection = stairObject.transform.position - Camera.main.transform.position;
        float angle = Vector3.Angle(cameraDirection, Camera.main.transform.forward);
        return angle < 90f; // 각도를 조정하여 계단을 바라보고 있는지 여부를 판단합니다.
    }
}

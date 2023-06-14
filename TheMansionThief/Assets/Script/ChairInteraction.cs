using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairInteraction : MonoBehaviour
{
    public GameObject chairObject1;
    public GameObject chairObject2;
    public GameObject chairObject3;
    public GameObject chairObject4;
    public Vector3 minWestPosition = new Vector3(-6f, 0.0f, -7.9f); 
    public Vector3 maxWestPosition = new Vector3(-5.1f, 1.0f, -7.2f); // 서쪽 의자
    public Vector3 minNorthPosition = new Vector3(-5.0f, 0.0f, -7.0f);
    public Vector3 maxNorthPosition = new Vector3(-4.0f, 1.0f, -6.0f); // 북쪽 의자
    public Vector3 minEastPosition = new Vector3(-3.9f, 0f, -7.8f);
    public Vector3 maxEastPosition = new Vector3(-2.8f, 1f, -5.2f); // 동쪽 의자
    public Vector3 minSouthPosition = new Vector3(-5.0f, 0f, -8.8f);
    public Vector3 maxSouthPosition = new Vector3(-4.1f, 1f, -7.7f); // 남쪽 의자
    

    private bool isFacingChair = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFacingChair)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if ((transform.position.x > minWestPosition.x && transform.position.z > minWestPosition.z) && (transform.position.x < maxWestPosition.x && transform.position.z < maxWestPosition.z))
                {
                    chairObject1.transform.rotation *= Quaternion.Euler(0f, 45f, 0f);
                }
                else if ((transform.position.x > minNorthPosition.x && transform.position.z > minNorthPosition.z) && (transform.position.x < maxNorthPosition.x && transform.position.z < maxNorthPosition.z))
                {
                    chairObject2.transform.rotation *= Quaternion.Euler(0f, 45f, 0f);
                }
                else if ((transform.position.x > minEastPosition.x && transform.position.z > minEastPosition.z) && (transform.position.x < maxEastPosition.x && transform.position.z < maxEastPosition.z))
                {
                    chairObject3.transform.rotation *= Quaternion.Euler(0f, 45f, 0f);
                }
                else if ((transform.position.x > minSouthPosition.x && transform.position.z > minSouthPosition.z) && (transform.position.x < maxSouthPosition.x && transform.position.z < maxSouthPosition.z))
                {
                    chairObject4.transform.rotation *= Quaternion.Euler(0f, 45f, 0f);
                }

            }
        }
        LateUpdate();
    }
    private void LateUpdate()
    {
        isFacingChair = CheckIfFacingChair();
    }
    private bool CheckIfFacingChair()
    {
        // 플레이어 오브젝트가 계단을 바라보고 있는지 여부를 체크합니다.
        Vector3 cameraDirection1 = chairObject1.transform.position - Camera.main.transform.position;
        Vector3 cameraDirection2 = chairObject2.transform.position - Camera.main.transform.position;
        Vector3 cameraDirection3 = chairObject3.transform.position - Camera.main.transform.position;
        Vector3 cameraDirection4 = chairObject4.transform.position - Camera.main.transform.position;
        float angle1 = Vector3.Angle(cameraDirection1, Camera.main.transform.forward);
        float angle2 = Vector3.Angle(cameraDirection2, Camera.main.transform.forward);
        float angle3 = Vector3.Angle(cameraDirection3, Camera.main.transform.forward);
        float angle4 = Vector3.Angle(cameraDirection4, Camera.main.transform.forward);
        return angle1 < 45f || angle2 < 45f || angle3 < 45f || angle4 < 45f; // 각도를 조정하여 계단을 바라보고 있는지 여부를 판단합니다.
    }
}

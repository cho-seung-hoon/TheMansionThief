using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChairInteraction : MonoBehaviour
{
    public GameObject chairObject1;
    public GameObject chairObject2;
    public GameObject chairObject3;
    public GameObject chairObject4;
    public Vector3 minWestPosition = new Vector3(-6f, 0.0f, -7.9f); 
    public Vector3 maxWestPosition = new Vector3(-5.1f, 1.0f, -7.2f); // ���� ����
    public Vector3 minNorthPosition = new Vector3(-5.0f, 0.0f, -7.0f);
    public Vector3 maxNorthPosition = new Vector3(-4.0f, 1.0f, -6.0f); // ���� ����
    public Vector3 minEastPosition = new Vector3(-3.9f, 0f, -7.8f);
    public Vector3 maxEastPosition = new Vector3(-2.8f, 1f, -5.2f); // ���� ����
    public Vector3 minSouthPosition = new Vector3(-5.0f, 0f, -8.8f);
    public Vector3 maxSouthPosition = new Vector3(-4.1f, 1f, -7.7f); // ���� ����

    public GameObject Current;
    public TextMeshProUGUI textComponent;
    public TextMeshProUGUI resultText;

    public bool debuglog = true;
    

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
        if ((chairObject1.transform.rotation.eulerAngles.y >= 175f && chairObject1.transform.rotation.eulerAngles.y <= 185f) && (chairObject2.transform.rotation.eulerAngles.y >= 85f && chairObject2.transform.rotation.eulerAngles.y <= 95f) && (chairObject3.transform.rotation.eulerAngles.y >= 310f && chairObject3.transform.rotation.eulerAngles.y <= 320f) && (chairObject4.transform.rotation.eulerAngles.y >= 40f && chairObject4.transform.rotation.eulerAngles.y <= 50f) && debuglog) {
            Print("Find The Second Hint");
        }
        
        LateUpdate();
        
    }
    private void LateUpdate()
    {
        isFacingChair = CheckIfFacingChair();
    }
    private bool CheckIfFacingChair()
    {
        // �÷��̾� ������Ʈ�� ����� �ٶ󺸰� �ִ��� ���θ� üũ�մϴ�.
        Vector3 cameraDirection1 = chairObject1.transform.position - Camera.main.transform.position;
        Vector3 cameraDirection2 = chairObject2.transform.position - Camera.main.transform.position;
        Vector3 cameraDirection3 = chairObject3.transform.position - Camera.main.transform.position;
        Vector3 cameraDirection4 = chairObject4.transform.position - Camera.main.transform.position;
        float angle1 = Vector3.Angle(cameraDirection1, Camera.main.transform.forward);
        float angle2 = Vector3.Angle(cameraDirection2, Camera.main.transform.forward);
        float angle3 = Vector3.Angle(cameraDirection3, Camera.main.transform.forward);
        float angle4 = Vector3.Angle(cameraDirection4, Camera.main.transform.forward);
        return angle1 < 45f || angle2 < 45f || angle3 < 45f || angle4 < 45f; // ������ �����Ͽ� ����� �ٶ󺸰� �ִ��� ���θ� �Ǵ��մϴ�.
    }
    public void Print(string str){
        textComponent.text = str;
        resultText.text = "0";
        Current.SetActive(true);
        StartCoroutine(AfterDelay());
    }

    IEnumerator AfterDelay(){
        float delay = 3f;
        yield return new WaitForSeconds(delay);
        Current.SetActive(false);
    }

}

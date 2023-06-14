using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour
{
    public GameObject targetObject;
    bool call = false;
    private Room4sc Room4sc;

    // Start is called before the first frame update
    void Start()
    {
        Room4sc = targetObject.GetComponent<Room4sc>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Animator objectAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("roll")) // ������ ������Ʈ�� �±װ� "roll"�� ���
        {
            Debug.Log("123");

            objectAnimator.SetBool("use", true); // �ִϸ��̼��� Use �Ķ���� ���� true�� ����
            other.gameObject.SetActive(false); // ������Ʈ ��Ȱ��ȭ

            if (!call)
            {
                Debug.Log("444");
                Room4sc.clear4();
                call = true;
            }
        }
    }
}

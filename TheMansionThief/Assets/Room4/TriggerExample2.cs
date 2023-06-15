using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample2 : MonoBehaviour
{
    public GameObject targetObject;
    bool call = false;
    private room4sc room4sc;

    // Start is called before the first frame update
    void Start()
    {
        room4sc = targetObject.GetComponent<room4sc>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public Animator objectAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("battery")) // ������ ������Ʈ�� �±װ� "roll"�� ���
        {

            objectAnimator.SetBool("Open_Anim", true); // �ִϸ��̼��� Use �Ķ���� ���� true�� ����

            objectAnimator.SetBool("Roll_Anim", true); // �ִϸ��̼��� Use �Ķ���� ���� true�� ����
            other.gameObject.SetActive(false); // ������Ʈ ��Ȱ��ȭ
            Invoke("stoproll", 5f);
            if (!call)
            {
                room4sc.clear4();
                call = true;
            }
        }
    }
    private void stoproll()
    {
        objectAnimator.SetBool("Roll_Anim", false);
    }
}

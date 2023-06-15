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
        if (other.gameObject.CompareTag("battery")) // 접촉한 오브젝트의 태그가 "roll"인 경우
        {

            objectAnimator.SetBool("Open_Anim", true); // 애니메이션의 Use 파라미터 값을 true로 설정

            objectAnimator.SetBool("Roll_Anim", true); // 애니메이션의 Use 파라미터 값을 true로 설정
            other.gameObject.SetActive(false); // 오브젝트 비활성화
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

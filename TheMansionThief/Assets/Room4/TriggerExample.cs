using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour
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
        if (other.gameObject.CompareTag("roll")) // 접촉한 오브젝트의 태그가 "roll"인 경우
        {
            Debug.Log("123");

            objectAnimator.SetBool("use", true); // 애니메이션의 Use 파라미터 값을 true로 설정
            other.gameObject.SetActive(false); // 오브젝트 비활성화

            if (!call)
            {
                Debug.Log("444");
                room4sc.clear4();
                call = true;
            }
        }
    }
}

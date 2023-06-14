using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample3: MonoBehaviour
{
    public GameObject targetObject;
    private Room4sc Room4sc;
    bool call = false;


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
        if (other.gameObject.CompareTag("ramp1")) // 접촉한 오브젝트의 태그가 "roll"인 경우
        {
            objectAnimator.SetBool("fix", true);
            other.gameObject.SetActive(false);
            if (!call)
            {
                Debug.Log("444");
                Room4sc.clear4();
                call = true;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample3: MonoBehaviour
{
    public GameObject targetObject;
    private room4sc room4sc;
    bool call = false;


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
        if (other.gameObject.CompareTag("ramp1")) // 접촉한 오브젝트의 태그가 "roll"인 경우
        {
            objectAnimator.SetBool("fix", true);
            other.gameObject.SetActive(false);
            if (!call)
            {
                room4sc.clear4();
                call = true;
            }
        }
    }
}

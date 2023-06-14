using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public string targetTag = "Book"; // 태그로 검색할 오브젝트의 태그
    public string targetTag2 = "Room1Answer";

    public int[] A = new int[4];
    public int[] B = { 1, 2, 3, 4 }; // 비교할 배열

    private int currentIndex = 0;

    private void Start()
    {
        InitializeArray();
    }

    public void SomeMethod(int value)
    {
        // 이미 존재하는 값인지 확인
        bool isDuplicate = false;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == value)
            {
                isDuplicate = true;
                break;
            }
        }

        if (!isDuplicate)
        {
            A[currentIndex] = value;
            currentIndex++;

            if (currentIndex >= A.Length)
            {
                if (ArraysEqual(A, B))
                {
                    Debug.Log("A 배열과 B 배열이 동일합니다!");
                }
            }
        }
    }

    // 배열 A를 초기화하는 메소드
    private void InitializeArray()
    {
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = -1; // 초기 값으로 배열을 채웁니다. 이 값은 실제로 입력되는 값과 중복되지 않아야 합니다.
        }
        currentIndex = 0; // currentIndex를 0으로 초기화합니다.
    }

    // 두 배열이 동일한지 확인하는 메소드
    private bool ArraysEqual(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }

        return true;
    }









    private void OnMouseDown()
    {
        InitializeArray();

        GameObject[] objects = GameObject.FindGameObjectsWithTag(targetTag); // 태그가 일치하는 모든 오브젝트를 찾습니다.
        GameObject[] objects2 = GameObject.FindGameObjectsWithTag(targetTag2);

        foreach (GameObject obj in objects)
        {
            Animator animator = obj.GetComponent<Animator>(); // 애니메이터 컨트롤러를 가져옵니다.
            if (animator != null)
            {
                animator.SetBool("Open", false); // 파라미터 값을 변경합니다.
            }
        }
    }
}





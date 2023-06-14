using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public string targetTag = "Book"; // �±׷� �˻��� ������Ʈ�� �±�
    public string targetTag2 = "Room1Answer";

    public int[] A = new int[4];
    public int[] B = { 1, 2, 3, 4 }; // ���� �迭

    private int currentIndex = 0;

    private void Start()
    {
        InitializeArray();
    }

    public void SomeMethod(int value)
    {
        // �̹� �����ϴ� ������ Ȯ��
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
                    Debug.Log("A �迭�� B �迭�� �����մϴ�!");
                }
            }
        }
    }

    // �迭 A�� �ʱ�ȭ�ϴ� �޼ҵ�
    private void InitializeArray()
    {
        for (int i = 0; i < A.Length; i++)
        {
            A[i] = -1; // �ʱ� ������ �迭�� ä��ϴ�. �� ���� ������ �ԷµǴ� ���� �ߺ����� �ʾƾ� �մϴ�.
        }
        currentIndex = 0; // currentIndex�� 0���� �ʱ�ȭ�մϴ�.
    }

    // �� �迭�� �������� Ȯ���ϴ� �޼ҵ�
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

        GameObject[] objects = GameObject.FindGameObjectsWithTag(targetTag); // �±װ� ��ġ�ϴ� ��� ������Ʈ�� ã���ϴ�.
        GameObject[] objects2 = GameObject.FindGameObjectsWithTag(targetTag2);

        foreach (GameObject obj in objects)
        {
            Animator animator = obj.GetComponent<Animator>(); // �ִϸ����� ��Ʈ�ѷ��� �����ɴϴ�.
            if (animator != null)
            {
                animator.SetBool("Open", false); // �Ķ���� ���� �����մϴ�.
            }
        }
    }
}





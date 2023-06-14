using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonClick : MonoBehaviour
{
    public GameObject Current; // UI -> CurrentPuzzle
    public TextMeshProUGUI textComponent; // UI -> CurrentPuzzle ->
    public TextMeshProUGUI resultText; // UI -> Hint -> Panel -> 1

    public string targetTag = "Book"; // �±׷� �˻��� ������Ʈ�� �±�
    public string targetTag2 = "Room1Answer";

    public int[] A = new int[4];
    public int[] B = { 1, 2, 3, 4 }; // ���� �迭

    private int currentIndex = 0;

    private bool isMouseOver = false;

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
                    Print("Find The First Hint"); // Ui 활성화 및 3초 후 비활성화되는 함수
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


    void Update()
    {
        if (isMouseOver && Input.GetKeyDown(KeyCode.E))
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

    void OnMouseEnter()
    {
        isMouseOver = true;
    }

    void OnMouseExit()
    {
        isMouseOver = false;
    }


    public void Print(string str){
        textComponent.text = str;
        resultText.text = "2";
        Current.SetActive(true);
        StartCoroutine(AfterDelay());
    }

    IEnumerator AfterDelay(){
        float delay = 3f;
        yield return new WaitForSeconds(delay);
        Current.SetActive(false);
    }
}





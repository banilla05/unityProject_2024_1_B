using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenChabge : MonoBehaviour
{
    public bool isPunch = false;             //���������� �Է��� �����°��� �������� Flag ��

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(!isPunch)            //��ġ üũ�� false �� ���
            {
                isPunch = true;         //��ġ üũ�� True ������༭ ��� �Է��� �������  ������ ���� ���� ���ϰ� ���´�.
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPunch);    //���� ȿ���� ���� ������ EndPunch �Լ�ȣ��
            }
        }
    }

    void EndPunch()
    {
        isPunch = false;
    }
}
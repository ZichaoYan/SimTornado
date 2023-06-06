using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; // Ŀ�������ϣ������Ķ���
    public Vector3 offset; // �����λ��ƫ��

    void Update()
    {      
        if(Vector3.Distance(transform.position, target.position) > 50)
        {
            //transform.position = target.position + offset;
            transform.position = new Vector3(target.position.x + offset.x, 0, target.position.z + offset.z);
        }
    }
}

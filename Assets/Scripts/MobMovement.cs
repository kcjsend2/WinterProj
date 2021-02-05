using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovement : MonoBehaviour
{
    float rightMax = 2.0f; //�·� �̵������� (x)�ִ밪
    float leftMax = -2.0f; //��� �̵������� (x)�ִ밪
    float currentPosition; //���� ��ġ(x) ����
    float direction = 2.0f; //�̵��ӵ�+����

    void Start()

    {
        currentPosition = transform.position.x;
    }

    void Update()

    {
        currentPosition += Time.deltaTime * direction;
        if (currentPosition >= rightMax) //���� ��ġ(x)�� ��� �̵������� (x)�ִ밪���� ũ�ų� ���ٸ�

        {
            direction *= -1; //�̵��ӵ�+���⿡ -1�� ���� ����
            currentPosition = rightMax; //������ġ�� ��� �̵������� (x)�ִ밪���� ����
        }

        else if (currentPosition <= leftMax) //���� ��ġ(x)�� �·� �̵������� (x)�ִ밪���� ũ�ų� ���ٸ�

        {
            direction *= -1; //�̵��ӵ�+���⿡ -1�� ���� ����
            currentPosition = leftMax; //������ġ�� �·� �̵������� (x)�ִ밪���� ����
        }

        transform.position = new Vector3(currentPosition, 0, 0); //��ġ�� ���� ������ġ�� ó��

    }
}

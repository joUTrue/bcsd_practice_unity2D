using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        //���� ������Ʈ�� ����� �� ���ʷ� ����
    }
    private void OnEnable()
    {
        //������Ʈ�� Ȱ��ȭ �ɶ�
    }

    private void OnDisable()
    {
        //������Ʈ�� ��Ȱ��ȭ �ɶ�
    }
    void Start()
    {
        //������Ʈ ���� ���� ����
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //���������� ����
        //cpu ���� ���
        //������ �����ֱ�� �������� �ڵ� �ۼ�(1�ʿ� �� 50��)
    }
    void Update()
    {
        //ȯ�濡 ���� �����ֱ� �ٲ�
    }

    private void LateUpdate()
    {
        //��� ������Ʈ ���� ����
        //ĳ���͸� ���󰡴� ī�޶�, ������ ��ó��
        //������Ʈ�� ������ �ֱ�
    }

    private void OnDestroy()
    {
        //������Ʈ�� ������ �� ����
    }
}

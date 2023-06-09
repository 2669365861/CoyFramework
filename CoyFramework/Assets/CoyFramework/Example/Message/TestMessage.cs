﻿using UnityEngine;

public class TestMessage : MonoBehaviour
{
    [SerializeField] private int loopCount = 100000;

    void Start()
    {
        MessageManager.Instance.Register<int>(MessageDefine.TEST_MESSAGE, TestTMessage);
    }

    private void OnDestroy()
    {
        MessageManager.Instance.Remove<int>(MessageDefine.TEST_MESSAGE, TestTMessage);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //MessageManager1.Instance.Send(MessageDefine.TEST_MESSAGE, new MessageData1());
            for (int i = 0; i < loopCount; i++)
            {
                MessageManager.Instance.Send<int>(MessageDefine.TEST_MESSAGE, 1);
            }
        }
    }

    void TestTMessage(int data)
    {
        int i = data + 1;
    }
}
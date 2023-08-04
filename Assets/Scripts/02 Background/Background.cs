using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum BackgroundType { blue=0, brown, gray, green, pink, purple, yellow }
public class Background : MonoBehaviour
{

    [SerializeField]
    private Sprite[] backgroundSprites;   // ��� ��������Ʈ�� �ֱ�
    [SerializeField]
    private MoveBackground[] panels;

    [Header("Settings")]
    [SerializeField]
    private BackgroundType backgroundType = BackgroundType.purple;
    [SerializeField]
    private float distance = 12f; // �� ���� ������ �Ÿ�
    [SerializeField]
    private float speed = 3; // ��� �̵� �ӵ�


    private void Start()
    {
        for( int i = 0 ; i < panels.Length; i++)
        {
            panels[i].Init(backgroundSprites[(int)backgroundType], distance, speed);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public enum BackgroundType { blue=0, brown, gray, green, pink, purple, yellow }
public class Background : MonoBehaviour
{

    [SerializeField]
    private Sprite[] backgroundSprites;   // 배경 스프라이트들 넣기
    [SerializeField]
    private MoveBackground[] panels;

    [Header("Settings")]
    [SerializeField]
    private BackgroundType backgroundType = BackgroundType.purple;
    [SerializeField]
    private float distance = 12f; // 각 배경들 사이의 거리
    [SerializeField]
    private float speed = 3; // 배경 이동 속도


    private void Start()
    {
        for( int i = 0 ; i < panels.Length; i++)
        {
            panels[i].Init(backgroundSprites[(int)backgroundType], distance, speed);
        }
    }

}

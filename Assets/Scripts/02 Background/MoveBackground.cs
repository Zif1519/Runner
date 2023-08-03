using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    private Transform target; // 현재 배경과 이어지는 배경 ( 이동 시 target 배경다음 위치로 이동됨 )
    [SerializeField]
    private float distance = 12.8f; // 각 배경들 사이의 거리
    [SerializeField]
    private float speed = 3; // 배경 이동 속도
    [SerializeField]
    private Vector3 moveDirection = Vector3.left;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.position += moveDirection * speed * Time.deltaTime;
        if ( transform.position.x <= -1.5 * distance)
        {
            transform.position = target.position - moveDirection * distance;
        }
    }

    public void Init(Sprite sprite, float distance, float speed)
    {
        spriteRenderer.sprite = sprite;

    }
}

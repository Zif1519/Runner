using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    private Transform _target; // 현재 배경과 이어지는 배경 ( 이동 시 target 배경다음 위치로 이동됨 )
    [SerializeField]
    private float _distance = 12.8f; // 각 배경들 사이의 거리
    [SerializeField]
    private float _speed = 3; // 배경 이동 속도
    [SerializeField]
    private Vector3 _moveDirection = Vector3.left;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        transform.position += _moveDirection * _speed * Time.deltaTime;
        if ( transform.position.x <= -1.5 * _distance)
        {
            transform.position = _target.position - _moveDirection * _distance;
        }
    }

    public void Init(Sprite sprite, float distance, float speed)
    {
        _spriteRenderer.sprite = sprite;
        _distance = distance;
        _speed = speed;
    }
}

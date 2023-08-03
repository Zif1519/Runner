using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    [SerializeField]
    private Transform target; // ���� ���� �̾����� ��� ( �̵� �� target ������ ��ġ�� �̵��� )
    [SerializeField]
    private float distance = 12.8f; // �� ���� ������ �Ÿ�
    [SerializeField]
    private float speed = 3; // ��� �̵� �ӵ�
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

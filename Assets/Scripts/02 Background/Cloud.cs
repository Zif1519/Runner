using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Cloud : MonoBehaviour
{
    [SerializeField]
    private float _maxSpeed = 2.5f; // 구름 이동 속도
    [SerializeField]
    private float _minSpeed = 1.5f; // 구름 이동 속도
    [SerializeField]
    private float _curSpeed = 2f; // 구름 이동 속도

    [SerializeField]
    private Vector3 _moveDirection = Vector3.left;
    [SerializeField]
    private Sprite[] cloudSprites;   // 구름 스프라이트들 넣기

    
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        int a = Random.Range(0, 3);
        _curSpeed = Mathf.Lerp(_minSpeed, _maxSpeed, a / 2f);
        _spriteRenderer.sortingOrder = -3 + a;
        _spriteRenderer.sprite = cloudSprites[Random.Range(0, cloudSprites.Length)];

        Color color = new Color((230 + a * 10) / 255f, (230 + a * 10) / 255f, (230 + a * 10) / 255f);
        _spriteRenderer.color = color;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += _moveDirection * _curSpeed * Time.deltaTime;
        if (transform.position.x <= -16)
        {
            int a = Random.Range(0, 3);
            transform.position = new Vector3(15+ Random.Range(0, 10) / 3f, -1f + Random.Range(0,150) / 25f,0);
            _curSpeed = Mathf.Lerp(_minSpeed, _maxSpeed, a/2f);
            _spriteRenderer.sortingOrder = -3 + a;
            _spriteRenderer.sprite = cloudSprites[Random.Range(0, cloudSprites.Length)];

            Color color = new Color((230+a*10)/255f, (230 + a * 10) / 255f, (230 + a * 10) / 255f);
            _spriteRenderer.color = color;
        }
    }
}

using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed;
    private Vector3 _targetPos;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        var xPos = (Input.mousePosition / Screen.width * 4f).x - 2;

        xPos = Mathf.Clamp(xPos, -2, 2);

        _rb.position = new Vector3(xPos, -4, 0);
    }
}

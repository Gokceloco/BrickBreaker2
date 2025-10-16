using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

    private Vector3 _dir = new Vector3(0,1,0);

    private void Start()
    {
        _dir.x = Random.Range(-.5f, .5f);
    }

    private void Update()
    {
        transform.position += _dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _dir = Vector3.Reflect(_dir, collision.contacts[0].normal);

        if (collision.gameObject.CompareTag("Brick"))
        {
            collision.gameObject.GetComponent<Brick>().GetHit(1);
        }
        if (collision.gameObject.CompareTag("BottomBorder"))
        {
            gameObject.SetActive(false);
        }
    }
}

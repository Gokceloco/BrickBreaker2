using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameDirector _gameDirector;
    public float speed;

    private Vector3 _dir = new Vector3(0,1,0);

    private Rigidbody2D _rb;

    public void StartBall(GameDirector gameDirector)
    {
        _rb = GetComponent<Rigidbody2D>();
        _gameDirector = gameDirector;
        _dir.x = Random.Range(-.5f, .5f);
    }

    private void Update()
    {   
        _rb.linearVelocity = _dir * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _dir = Vector3.Reflect(_dir, collision.contacts[0].normal);
        _gameDirector.audioManager.PlayImpactAS();


        if (collision.gameObject.CompareTag("Brick"))
        {
            collision.gameObject.GetComponentInParent<Brick>().GetHit(1);
            _gameDirector.audioManager.PlayBrickHitAS();
        }
        if (collision.gameObject.CompareTag("BottomBorder"))
        {
            _gameDirector.Lose();
            gameObject.SetActive(false);
            _gameDirector.audioManager.PlayFailAS();
        }
    }

    public void StopBall()
    {
        _dir = Vector3.zero;
    }
}

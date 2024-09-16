using UnityEngine.UI;
using UnityEngine;

public class Basket : MonoBehaviour
{
    int score = 0;
    public Text scoreText;

    private void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float mouseX = mousePosition.x;
        mouseX = Mathf.Clamp(mouseX, -7.5f, 7.5f);
        transform.position = new Vector3(mouseX, -3,-3 );
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        score++;
        scoreText.text = "Score: " + score;
        Destroy(collision.gameObject);
    }
}

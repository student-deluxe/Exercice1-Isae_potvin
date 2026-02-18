using UnityEngine;

public class TailleObstacle : MonoBehaviour
{
    public float min = 0.1f;
    public float max = 2f;
    public float taille = 0.1f;
    public int direction = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float nouvelleTaille = transform.localScale.x + (direction * taille);
        transform.localScale = new Vector2(nouvelleTaille, nouvelleTaille);

        if (nouvelleTaille < min || nouvelleTaille > max)
        {
            direction = -direction;
        }
    }
}

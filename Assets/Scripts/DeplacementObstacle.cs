using UnityEngine;
using UnityEngine.UIElements;

public class DeplacementObstacle : MonoBehaviour
{
    public float vitesse = 0.01f;
    public float limiteHaut = 10f;
    public float limiteBas = -10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, vitesse, 0);
        if (transform.position.y > limiteHaut)
        {
            float nouvellePositionX = transform.position.x;
            float nouvellePositionY = limiteBas;
            transform.position = new Vector2(nouvellePositionX, nouvellePositionY);
        }
        if (transform.position.y < limiteBas)
        {
            float nouvellePositionX = transform.position.x;
            float nouvellePositionY = limiteHaut;
            transform.position = new Vector2(nouvellePositionX, nouvellePositionY);
        }
    }
}

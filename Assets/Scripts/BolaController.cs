using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public Rigidbody2D meuRigidbody2D;
    private Vector2 minhaVelocidade;
    public float velocidade = 5f;

    // Start is called before the first frame update
    void Start()
    {
        int direcao = Random.Range(0, 4);

        if(direcao == 1)
        {
            minhaVelocidade.x = velocidade;
            minhaVelocidade.y = velocidade;
        } 
        else if (direcao == 2)
        {
            minhaVelocidade.x = -velocidade;
            minhaVelocidade.y = velocidade;
        } 
        else if(direcao == 3)
        {
            minhaVelocidade.x = -velocidade;
            minhaVelocidade.y = -velocidade;
        } 
        else
        {
            minhaVelocidade.x = velocidade;
            minhaVelocidade.y = -velocidade;
        }

        meuRigidbody2D.velocity = minhaVelocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

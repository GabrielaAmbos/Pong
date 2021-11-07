using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteController : MonoBehaviour
{

    private Vector3 minhaPosicao;
    private float meuY;
    public float velocidade = 5f;
    public float meuLimite = 3.5f;

    public bool player1;
    public bool automatico = false;

    // Start is called before the first frame update
    void Start()
    {
        minhaPosicao.x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        minhaPosicao.y = meuY;

        transform.position = minhaPosicao;

        float deltaVelocidade = velocidade * Time.deltaTime;

        if (!automatico)
        {

            if (player1)
            {
                if (Input.GetKey(KeyCode.UpArrow) && meuY < meuLimite)
                {
                    meuY += deltaVelocidade;
                }

                if (Input.GetKey(KeyCode.DownArrow) && meuY > (-meuLimite))
                {
                    meuY -= deltaVelocidade;
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.W) && meuY < meuLimite)
                {
                    meuY += deltaVelocidade;
                }

                if (Input.GetKey(KeyCode.S) && meuY > (-meuLimite))
                {
                    meuY -= deltaVelocidade;
                }
            }

        }
    }
}

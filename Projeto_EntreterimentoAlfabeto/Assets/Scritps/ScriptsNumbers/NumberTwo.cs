using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberTwo : MonoBehaviour
{
    [SerializeField]
    private Transform numberTwo;

    private Vector2 posicaoInicial;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    public static bool locked;
    void Start()
    {
        posicaoInicial = transform.position;


    }


    void Update()
    {
        ///
    }



    private void OnMouseDown()
    {
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;

        }



    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);

        }
    }


    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - numberTwo.position.x) <= 0.5f &&
            Mathf.Abs(transform.position.y - numberTwo.position.y) <= 0.5f)
        {
            transform.position = new Vector2(numberTwo.position.x, numberTwo.position.y);
            locked = true;
        }
        else
        {
            transform.position = new Vector2(posicaoInicial.x, posicaoInicial.y);
        }
    }
}

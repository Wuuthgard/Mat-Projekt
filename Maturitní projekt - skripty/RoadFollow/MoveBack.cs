using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    public BoxCollider2D Collider2D;
    public Rigidbody2D Rigid2D;
    public GameObject score;
    public GameObject AutoPrek;
    float width;
    public static float speed;
    void Start()
    {
        Collider2D = GetComponent<BoxCollider2D>();
        Rigid2D = GetComponent<Rigidbody2D>();

        width = Collider2D.size.x;
        Rigid2D.velocity = new Vector2(speed, 0);
        int RandomX1 = Random.Range(1, -1);
        int RandomY1 = Random.Range(1, -1);
        int RandomX2 = Random.Range(1, -1);
        int RandomY2 = Random.Range(1, -1);
        while (RandomX2 == RandomX1)
        {
            RandomX2 = Random.Range(1, -1);
            RandomY2 = Random.Range(1, -1);
        }
        transform.GetChild(0).localPosition = new Vector3(RandomX1, RandomY1, -2);
        transform.GetChild(1).localPosition = new Vector3(RandomX2, RandomY2, -1);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -width-8)
        {
            transform.position = (Vector2)transform.position + new Vector2(width+24f, 0);
            ResetOb();
        }
    }

    void ResetOb()
    {
        int RandomX1 = Random.Range(1, -1);
        int RandomY1 = Random.Range(1, -1);
        int RandomX2 = Random.Range(1, -1);
        int RandomY2 = Random.Range(1, -1);
        while (RandomX2 == RandomX1)
        {
            RandomX2 = Random.Range(1, -1);
            RandomY2 = Random.Range(1, -1);
        }
        transform.GetChild(0).localPosition = new Vector3(RandomX1, RandomY1, -2);
        score.SetActive(true);
        transform.GetChild(1).localPosition = new Vector3(RandomX2, RandomY2, -1);
        AutoPrek.SetActive(true);
    }
}

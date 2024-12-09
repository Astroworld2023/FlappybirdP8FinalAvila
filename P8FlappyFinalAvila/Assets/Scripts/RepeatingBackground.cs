using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHoziontalLength;

    // Start is called before the first frame update
    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void RepositionBackground()
    {
        Vector2 ground Offset = new Vector2(groundHorizontalLength * 2f, 0);
        transfrom.position = Vector2 transform.position 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    private int scoreCount;

    public int ScoreCount
    {
        get { return this.scoreCount; }
        private set { this.scoreCount = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        scoreCount += 1000;
    }
}

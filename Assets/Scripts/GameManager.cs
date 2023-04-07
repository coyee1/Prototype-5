using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    private float spawnrate = 1.0f;
    private int score
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTarget());
        score = 0;
        UpdateScore(0);
    }
IEnumerator SpawnTarget(){
    while (true){
        Updatescore(5);
        yield return new WaitForSeconds(spawnrate);
        int index = Random.Range(0,targets.Count);
        Instantiate (targets[index] );
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actionner : MonoBehaviour
{
    public GameObject electronPrefab;
    public float respawnTime = 1f;
    Vector2 ScreenBounds;
    

    // Start is called before the first frame update
    void Start()
    {
        //ScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        StartCoroutine(ElectronWave());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnElectron()
    {
        GameObject electron = Instantiate(electronPrefab) as GameObject;
        electron.transform.position = transform.position;
        
    }
    IEnumerator ElectronWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnElectron();
        }
    } 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            

        }
    }
}

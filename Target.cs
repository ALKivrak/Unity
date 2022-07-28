using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    private string PLAYER = "Player";
    public static int currentLevel = 1;
    private string levelName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(PLAYER))
        {
            currentLevel += 1;
            Invoke(nameof(nextLevel),1);
            if (currentLevel >= 6)
                currentLevel = 1;
        }
    }

    private void nextLevel()
    {
        levelName = currentLevel.ToString();
        SceneManager.LoadScene(levelName);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioAnimal : MonoBehaviour
{
    [SerializeField]
    List<AudioClip> clipList = new List<AudioClip>();
    [SerializeField]
    AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(latence(Random.Range(3, 6)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator latence(float time)
    {
        clip = clipList[Random.Range(0, clipList.Count)];
        yield return new WaitForSeconds(time);
        GetComponent<AudioSource>().PlayOneShot(clip);
        StartCoroutine(latence(Random.Range(5, 15)));
    }
}

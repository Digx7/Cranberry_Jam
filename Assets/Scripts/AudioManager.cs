using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private bool isPlayingMusic = true;
    [SerializeField] private AudioClip[] playList;
    [SerializeField] private AudioClip currentSongPlaying;
    [SerializeField] private AudioSource musicSource;

    //this function will return a random song from the playList[];
    public AudioClip getRandomSong ()
    {
      int start2 = UnityEngine.Random.Range(0, playList.Length);
      return playList[start2];
    }

    //this IEnumerator will always play the background music, when one song ends it starts up another
    IEnumerator Start()
    {
        while(isPlayingMusic)
        {
          AudioClip song = getRandomSong();
          musicSource.clip = song;
          musicSource.Play();

          yield return new WaitForSeconds(musicSource.clip.length);
        }
    }
}

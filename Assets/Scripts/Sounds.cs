using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

public class Sounds : MonoBehaviour
{
   [SerializeField]
   private List<AudioClip> sounds = new List<AudioClip>();
   
   public AudioClip meow01;
   public AudioClip meow02;
   public AudioClip meow03;
   public AudioClip meow04;
   public AudioClip meow05;
   public AudioClip meow06;
   public AudioClip meow07;

   private void Awake()
   {
      sounds.Add(meow01);
      sounds.Add(meow02);
      sounds.Add(meow03);
      sounds.Add(meow04);
      sounds.Add(meow05);
      sounds.Add(meow06);
      sounds.Add(meow07);
   }

   public List<AudioClip> getSounds()
   {
      return sounds;
   }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PropellerRoller : MonoBehaviour
{
   public float rotationSpeed;
   // Start is called before the first frame update
   void Start()
   {

      rotationSpeed = 200;
   }

   // Update is called once per frame
   void Update()
   {
      transform.Rotate(Vector3.forward * rotationSpeed);

   }
}

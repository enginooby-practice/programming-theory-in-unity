using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Polygon {
  protected override float GetArea() {
    return EdgeLength * EdgeLength;
  }
}

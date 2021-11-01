using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equilateral : Polygon {
  protected override float GetArea() {
    return Mathf.Sqrt(3) / 4 * EdgeLength * EdgeLength;
  }
}

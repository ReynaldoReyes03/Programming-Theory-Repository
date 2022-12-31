using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape {
    private void Start() {
        ShapeName = transform.name;
        ShapeLife = 5;
    }

    private void Update() {
        
    }

    protected override void OnMouseDown() {
        DisplayText("I am a sphere");
    }
}

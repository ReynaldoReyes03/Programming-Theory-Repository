using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape {
    private void Start() {
        ShapeName = transform.name;
        ShapeLife = 5;
    }

    private void Update() {
        
    }
    protected override void OnMouseDown() {
        DisplayText("I am a cube");
    }
}

﻿using UnityEditor;
using UnityEngine;

namespace TNRD.Automatron.Drawers {

    [CustomDrawer( typeof( double ) )]
    public class DoubleDrawer : SliderDrawer {

        public override void OnGUI( Rect rect, string name, ref object value ) {
            base.OnGUI( rect, name, ref value );
            EditorGUI.BeginDisabledGroup( IsReadOnly );
            EditorGUI.HandlePrefixLabel( rect, GetControlRect(), new GUIContent( name ) );
            if ( hasSlider ) {
                value = EditorGUI.Slider( GetControlRect(), (float)value, min, max );
            } else {
                value = EditorGUI.DoubleField( GetControlRect(), (double)value );
            }
            EditorGUI.EndDisabledGroup();
        }
    }
}
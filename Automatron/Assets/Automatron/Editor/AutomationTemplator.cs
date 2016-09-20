#if UNITY_EDITOR
#if AUTOMATRON_LIB
using Automatron.Properties;
#endif
using System;
using System.IO;
using System.Linq;
using UnityEditor;

namespace TNRD.Automatron {
    
    public class AutomationTemplator {

        private AutomatronEditor editor;

        public AutomationTemplator() { }
        public AutomationTemplator( AutomatronEditor editor ) {
            this.editor = editor;
        }

        public void CreateAutomation( string name ) {
            WriteIt( editor.Assets.Text( "AutomationTemplate.cs" ), name );
        }

        public void CreateConditionalAutomation( string name ) {
            WriteIt( editor.Assets.Text( "ConditionalTemplate.cs" ), name );
        }

        public void CreateLoopableAutomation( string name ) {
            WriteIt( editor.Assets.Text( "LoopableTemplate.cs" ), name );
        }

        private void WriteIt( string contents, string name ) {
            var cname = new string( name.Where( c => char.IsLetter( c ) || char.IsDigit( c ) ).ToArray() );
            var temp = contents.Replace( "_header_", name );
            temp = temp.Replace( "_classname_", cname );
            var path = string.Format( "Assets/Automatron/Editor/Automations/{0}.cs", cname );
            if ( File.Exists( path ) ) {
                path = string.Format( "Assets/Automatron/Editor/Automations/{0}_{1}{2}.cs", cname, DateTime.Now.Second, DateTime.Now.Millisecond );
            } else {
                File.WriteAllText( path, temp );
            }
            AssetDatabase.Refresh();
        }
    }
}
#endif
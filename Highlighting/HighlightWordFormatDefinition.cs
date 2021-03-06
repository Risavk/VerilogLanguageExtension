﻿using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System.Windows.Media;

// Code based on Walkthrough: Highlighting Text
// See: https://docs.microsoft.com/en-us/visualstudio/extensibility/walkthrough-highlighting-text?view=vs-2015

namespace VerilogLanguage.Highlighting
{
    // Step #5: Create a second class that inherits from MarkerFormatDefinition, 
    // and name it HighlightWordFormatDefinition. In order to use this format definition for your tag, 
    // you must export it with the following attributes:
    //
    // NameAttribute: tags use this to reference this format
    // UserVisibleAttribute: this causes the format to appear in the UI

    [Export(typeof(EditorFormatDefinition))]
    [Name("MarkerFormatDefinition/HighlightWordFormatDefinition")]
    [UserVisible(true)]
    internal class HighlightWordFormatDefinition : MarkerFormatDefinition
    {
        // the single word higlight that occurs when typing. called once at Visual Studio launch time.
        // this controls the color of all selected words in the document. 
        // currently commented out to use the default Visual Studio colorization
        public HighlightWordFormatDefinition()
        {
            // this.ForegroundColor = Colors.DarkBlue;
            // this.DisplayName = "Highlight Word";
            // this.ZOrder = 5;
        }
    }

}

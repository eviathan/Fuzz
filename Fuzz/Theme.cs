using Fuzz.Models;
using Fuzz.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Linq;

namespace Fuzz
{
    public sealed class Theme
    {
        private int majorVersion = 5;
        private string minorVersion = "10.0_370";
        private int schemaChangeCount = 1;
        private string creator = "Fuzz 1.0.0";
        private string revision = "b8761d5b3a670e00b16e716b603a7c9f50dcfcb0"; // NOTE: This needs to be changed

        private static Color defaultColor = Color.FromArgb(255, 255, 255, 255);
        private MainWindowViewModel model;

        public Theme() { }

        public Theme(MainWindowViewModel model)
        {
            foreach (var color in model.Colors)
            {
                Colors[color.Name] = color.Value;
            }

            foreach (var property in model.Properties)
            {
                Properties[property.Name].Value = property.FloatValue;
            }
        }

        public Dictionary<string, PropertyItem> Properties { get; set; } = new Dictionary<string, PropertyItem>
        {
            {  "MinVelocityNoteBlendFactor", new PropertyItem() },
            { "StripedBackgroundShadeFactor", new PropertyItem() },
            { "AutomationLaneHeaderAlpha", new PropertyItem { MaxValue = 255, Type = Enums.PropertyItemType.IntType } },
            { "AutomationLaneClipBodyAlpha", new PropertyItem { MaxValue = 255, Type = Enums.PropertyItemType.IntType } },
            { "DefaultBlendFactor", new PropertyItem() },
            { "IconBlendFactor", new PropertyItem() },
            { "ClipBlendFactor", new PropertyItem() },
            { "NoteBorderStandbyBlendFactor", new PropertyItem() },
            { "RetroDisplayBlendFactor", new PropertyItem() },
            { "CheckControlNotCheckedBlendFactor", new PropertyItem() },
            { "MixSurfaceAreaBlendFactor", new PropertyItem() },
            { "TextFrameSegmentBlendFactor", new PropertyItem() },
            { "VelocityEditorForegroundSelectedBlendFactor", new PropertyItem() },
            { "NoteDisabledSelectedBlendFactor", new PropertyItem() }
        };

        public Dictionary<string, Color> Colors { get; set; } = new Dictionary<string, Color>
        {
            {  "ControlForeground", defaultColor },
            { "TextDisabled", defaultColor },
            { "ControlDisabled", defaultColor },
            { "MeterBackground", defaultColor },
            { "SurfaceHighlight", defaultColor },
            { "SurfaceArea", defaultColor },
            { "Desktop", defaultColor },
            { "ViewCheckControlEnabledOn", defaultColor },
            { "ScrollbarInnerHandle", defaultColor },
            { "ScrollbarInnerTrack", defaultColor },
            { "ScrollbarOuterHandle", defaultColor },
            { "ScrollbarOuterTrack", defaultColor },
            { "ScrollbarLCDHandle", defaultColor },
            { "ScrollbarLCDTrack", defaultColor },
            { "DetailViewBackground", defaultColor },
            { "PreferencesTab", defaultColor },
            { "SelectionFrame", defaultColor },
            { "ControlBackground", defaultColor },
            { "ControlFillHandle", defaultColor },
            { "ChosenDefault", defaultColor },
            { "ChosenRecord", defaultColor },
            { "ChosenPreListen", defaultColor },
            { "ImplicitArm", defaultColor },
            { "RangeDefault", defaultColor },
            { "RangeDisabled", defaultColor },
            { "RangeDisabledOff", defaultColor },
            { "LearnMidi", defaultColor },
            { "LearnKey", defaultColor },
            { "LearnMacro", defaultColor },
            { "RangeEditField", defaultColor },
            { "RangeEditField2", defaultColor },
            { "BipolReset", defaultColor },
            { "ChosenAlternative", defaultColor },
            { "ChosenAlert", defaultColor },
            { "ChosenPlay", defaultColor },
            { "Clip1", defaultColor },
            { "Clip2", defaultColor },
            { "Clip3", defaultColor },
            { "Clip4", defaultColor },
            { "Clip5", defaultColor },
            { "Clip6", defaultColor },
            { "Clip7", defaultColor },
            { "Clip8", defaultColor },
            { "Clip9", defaultColor },
            { "Clip10", defaultColor },
            { "Clip11", defaultColor },
            { "Clip12", defaultColor },
            { "Clip13", defaultColor },
            { "Clip14", defaultColor },
            { "Clip15", defaultColor },
            { "Clip16", defaultColor },
            { "ClipText", defaultColor },
            { "ClipBorder", defaultColor },
            { "SelectionBackground", defaultColor },
            { "StandbySelectionBackground", defaultColor },
            { "SelectionForeground", defaultColor },
            { "StandbySelectionForeground", defaultColor },
            { "SurfaceBackground", defaultColor },
            { "AutomationColor", defaultColor },
            { "LoopColor", defaultColor },
            { "ArrangementRulerMarkings", defaultColor },
            { "DetailViewRulerMarkings", defaultColor },
            { "ShadowDark", defaultColor },
            { "ShadowLight", defaultColor },
            { "DisplayBackground", defaultColor },
            { "AbletonColor", defaultColor },
            { "WaveformColor", defaultColor },
            { "VelocityColor", defaultColor },
            { "Alert", defaultColor },
            { "ControlOnForeground", defaultColor },
            { "ControlOffForeground", defaultColor },
            { "ControlOnDisabledForeground", defaultColor },
            { "ControlOffDisabledForeground", defaultColor },
            { "ControlOnAlternativeForeground", defaultColor },
            { "ControlTextBack", defaultColor },
            { "ControlContrastFrame", defaultColor },
            { "ControlSelectionFrame", defaultColor },
            { "ControlContrastTransport", defaultColor },
            { "Progress", defaultColor },
            { "ProgressText", defaultColor },
            { "TransportProgress", defaultColor },
            { "ClipSlotButton", defaultColor },
            { "BrowserBar", defaultColor },
            { "BrowserBarOverlayHintTextColor", defaultColor },
            { "BrowserDisabledItem", defaultColor },
            { "BrowserSampleWaveform", defaultColor },
            { "AutomationDisabled", defaultColor },
            { "AutomationGrid", defaultColor },
            { "AutomationMouseOver", defaultColor },
            { "MidiNoteMaxVelocity", defaultColor },
            { "RetroDisplayBackground", defaultColor },
            { "RetroDisplayBackgroundLine", defaultColor },
            { "RetroDisplayForeground", defaultColor },
            { "RetroDisplayForeground2", defaultColor },
            { "RetroDisplayForegroundDisabled", defaultColor },
            { "RetroDisplayGreen", defaultColor },
            { "RetroDisplayRed", defaultColor },
            { "RetroDisplayHandle1", defaultColor },
            { "RetroDisplayHandle2", defaultColor },
            { "RetroDisplayScaleText", defaultColor },
            { "ThresholdLineColor", defaultColor },
            { "GainReductionLineColor", defaultColor },
            { "InputCurveColor", defaultColor },
            { "InputCurveOutlineColor", defaultColor },
            { "OutputCurveColor", defaultColor },
            { "OutputCurveOutlineColor", defaultColor },
            { "SpectrumDefaultColor", defaultColor },
            { "SpectrumAlternativeColor", defaultColor },
            { "Operator1", defaultColor },
            { "Operator2", defaultColor },
            { "Operator3", defaultColor },
            { "Operator4", defaultColor },
            { "DrumRackScroller1", defaultColor },
            { "DrumRackScroller2", defaultColor },
            { "FilledDrumRackPad", defaultColor },
            { "SurfaceAreaFocus", defaultColor },
            { "FreezeColor", defaultColor },
            { "GridLabel", defaultColor },
            { "ArrangerGridTiles", defaultColor },
            { "DetailGridTiles", defaultColor },
            { "TreeColumnHeadBackground", defaultColor },
            { "TreeColumnHeadForeground", defaultColor },
            { "TreeColumnHeadSelected", defaultColor },
            { "TreeColumnHeadFocus", defaultColor },
            { "TreeColumnHeadControl", defaultColor },
            { "TreeRowCategoryForeground", defaultColor },
            { "TreeRowCategoryBackground", defaultColor },
            { "SearchIndication", defaultColor },
            { "SearchIndicationStandby", defaultColor },
            { "KeyZoneBackground", defaultColor },
            { "KeyZoneCrossfadeRamp", defaultColor },
            { "VelocityZoneBackground", defaultColor },
            { "VelocityZoneCrossfadeRamp", defaultColor },
            { "SelectorZoneBackground", defaultColor },
            { "SelectorZoneCrossfadeRamp", defaultColor },
            { "ViewCheckControlEnabledOff", defaultColor },
            { "ViewCheckControlDisabledOn", defaultColor },
            { "ViewCheckControlDisabledOff", defaultColor },
            { "BackgroundClip", defaultColor },
            { "BackgroundClipFrame", defaultColor },
            { "WarperTimeBarRulerBackground", defaultColor },
            { "WarperTimeBarMarkerBackground", defaultColor },
            { "BipolarPotiTriangle", defaultColor },
            { "Poti", defaultColor },
            { "DeactivatedPoti", defaultColor },
            { "PotiNeedle", defaultColor },
            { "DeactivatedPotiNeedle", defaultColor },
            { "TransportOffBackground", defaultColor },
            { "TransportOffDisabledForeground", defaultColor },
            { "TransportSelectionBackground", defaultColor }
        };


        public static Theme Parse(string dataString)
        {
            var theme = new Theme();
            var document = XDocument.Parse(dataString);

            var abletonElement = document.Element("Ableton");
            theme.majorVersion = int.Parse(abletonElement.Attribute("MajorVersion").Value);
            theme.minorVersion = abletonElement.Attribute("MinorVersion").Value;
            theme.schemaChangeCount = int.Parse(abletonElement.Attribute("SchemaChangeCount").Value);
            theme.creator = abletonElement.Attribute("Creator").Value;
            theme.revision = abletonElement.Attribute("Revision").Value;

            theme.Colors = abletonElement.Element("SkinManager")
                .Descendants()
                .Where(x => !x.HasAttributes) // NOTE: This is not great but we get what we are given.
                .Select(x => {
                    var name = x.Name.LocalName;
                    var r = byte.Parse(x.Element("R").Attribute("Value").Value);
                    var g = byte.Parse(x.Element("G").Attribute("Value").Value);
                    var b = byte.Parse(x.Element("B").Attribute("Value").Value);
                    var a = byte.Parse(x.Element("Alpha").Attribute("Value").Value);

                    return new Tuple<string, Color>(name, Color.FromArgb(a, r, g, b));
                })
                .ToDictionary(x => x.Item1, x => x.Item2);

            theme.Properties = abletonElement.Element("SkinManager")
                .Descendants()
                .Where(x => x.HasAttributes && !string.IsNullOrWhiteSpace(x.Attribute("Value")?.Value) && !(new List<string> { "Alpha", "R", "G", "B" }.Contains(x.Name.LocalName))) // NOTE: This is not great but we get what we are given.
                .Select(x =>
                {
                    var name = x.Name.LocalName;
                    var value = float.Parse(x.Attribute("Value").Value);

                    return new Tuple<string, PropertyItem>(name, new PropertyItem
                    {
                        Value = value
                    });
                })
                .ToDictionary(x => x.Item1, x => x.Item2);

            return theme;
        }

        // TODO: refactor this so its OO and uses a grown up serialiser/ parser
        public static string Serialize(Theme theme)
        {
            var colors = string.Join(Environment.NewLine, theme.Colors.Select(x => $"<{x.Key}>\n<R Value=\"{x.Value.R}\" />\n<G Value=\"{x.Value.G}\" />\n<B Value=\"{x.Value.B}\" />\n<Alpha Value=\"{x.Value.A}\" />\n</{x.Key}>"));
            var props = string.Join(Environment.NewLine, theme.Properties.Select(x => $"<{x.Key} Value=\"{x.Value.GetValue()}\" />"));

            return $"<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<Ableton MajorVersion=\"{theme.majorVersion}\" MinorVersion=\"{theme.minorVersion}\" SchemaChangeCount=\"{theme.schemaChangeCount}\" Creator=\"{theme.creator}\" Revision=\"{theme.revision}\">\n<SkinManager>\n{props}{colors}</SkinManager>\n</Ableton>";
        }
    }
}

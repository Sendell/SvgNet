/*
	Copyright © 2003 RiskCare Ltd. All rights reserved.
	Copyright © 2010 SvgNet & SvgGdi Bridge Project. All rights reserved.
	Copyright © 2015-2019 Rafael Teixeira, Mojmír Němeček, Benjamin Peterson and Other Contributors

	Original source code licensed with BSD-2-Clause spirit, treat it thus, see accompanied LICENSE for more
*/

using SvgNet.SvgTypes;

namespace SvgNet.SvgElements
{
    /// <summary>
    /// Represents a <c>polygon</c> element
    /// </summary>
    public class SvgPolygonElement : SvgStyledTransformedElement
    {
        public SvgPolygonElement()
        {
        }

        public SvgPolygonElement(SvgPoints points) => Points = points;

        public override string Name => "polygon";

        public SvgPoints Points
        {
            get => (SvgPoints)_atts["points"];
            set => _atts["points"] = value;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Summary description for GhostForm
/// </summary>
/// 
namespace CustomForm
{
    public class GhostForm : System.Web.UI.HtmlControls.HtmlForm
    {
        protected bool _render;

        public bool RenderFormTag
        {
            get { return _render; }
            set { _render = value; }
        }
        public GhostForm()
        {
            //By default, show the form tag
            _render = true;
        }

        protected override void RenderBeginTag(HtmlTextWriter writer)
        {
            //Only render the tag when _render is set to true
            if (_render)
                base.RenderBeginTag(writer);
        }

        protected override void RenderEndTag(HtmlTextWriter writer)
        {
            //Only render the tag when _render is set to true
            if (_render)
                base.RenderEndTag(writer);
        }
    }
}
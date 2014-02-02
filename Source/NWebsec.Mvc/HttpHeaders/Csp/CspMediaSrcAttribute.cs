// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using NWebsec.HttpHeaders;

namespace NWebsec.Mvc.HttpHeaders.Csp
{
    /// <summary>
    /// When applied to a controller or action method, enables the media-src directive for the CSP header. 
    /// </summary>
    public class CspMediaSrcAttribute : CspDirectiveAttributeBase
    {
        protected override HttpHeaderHelper.CspDirectives Directive
        {
            get { return HttpHeaderHelper.CspDirectives.MediaSrc; }
        }

        protected override bool ReportOnly
        {
            get { return false; }
        }
    }
}
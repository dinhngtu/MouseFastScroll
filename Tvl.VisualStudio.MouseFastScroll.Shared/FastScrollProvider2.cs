// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.

namespace Tvl.VisualStudio.MouseFastScroll
{
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Text.Editor;
    using Microsoft.VisualStudio.Utilities;

    [Export(typeof(IKeyProcessorProvider))]
    [Order]
    [ContentType("text")]
    [Name("FastScroll2")]
    [TextViewRole(PredefinedTextViewRoles.Interactive)]
    internal class FastScrollProvider2 : IKeyProcessorProvider
    {
        public KeyProcessor GetAssociatedProcessor(IWpfTextView wpfTextView)
        {
            if (wpfTextView == null)
            {
                return null;
            }

            return new FastScrollProcessor2(wpfTextView);
        }
    }
}

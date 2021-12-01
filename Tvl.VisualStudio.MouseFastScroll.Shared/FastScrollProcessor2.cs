// Copyright (c) Tunnel Vision Laboratories, LLC. All Rights Reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE.txt in the project root for license information.

namespace Tvl.VisualStudio.MouseFastScroll
{
    using System.Windows.Input;
    using ITextView = Microsoft.VisualStudio.Text.Editor.ITextView;
    using KeyProcessor = Microsoft.VisualStudio.Text.Editor.KeyProcessor;

    internal class FastScrollProcessor2 : KeyProcessor
    {
        public FastScrollProcessor2(ITextView textView)
        {
            TextView = textView;
        }

        private ITextView TextView
        {
            get;
            set;
        }

        public override void KeyDown(KeyEventArgs args)
        {
            if (args.SystemKey == Key.LeftAlt || args.SystemKey == Key.RightAlt)
            {
                args.Handled = true;
            }

            base.KeyDown(args);
        }
    }
}

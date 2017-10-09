﻿// Copyright © 2010-2017 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

namespace Chromely.CefSharp.Winapi.Browser
{
    using System;
    using CefSharpGlobal = global::CefSharp;

    /// <summary>
    /// Winapi specific implementation, has events the
    /// <see cref="ChromiumWebBrowser" /> implementation exposes.
    /// </summary>
    /// <seealso cref="CefSharp.IWebBrowser" />
    public interface IWinapiWebBrowser : CefSharpGlobal.IWebBrowser
    {
        /// <summary>
        /// Occurs when the browser title changed.
        /// It's important to note this event is fired on a CEF UI thread, which by default is not the same as your application UI
        /// thread. It is unwise to block on this thread for any length of time as your browser will become unresponsive and/or hang..
        /// To access UI elements you'll need to Invoke/Dispatch onto the UI Thread. 
        /// </summary>
        event EventHandler<CefSharpGlobal.TitleChangedEventArgs> TitleChanged;

        /// <summary>
        /// Occurs when the browser address changed.
        /// It's important to note this event is fired on a CEF UI thread, which by default is not the same as your application UI
        /// thread. It is unwise to block on this thread for any length of time as your browser will become unresponsive and/or hang..
        /// To access UI elements you'll need to Invoke/Dispatch onto the UI Thread. 
        /// </summary>
        event EventHandler<CefSharpGlobal.AddressChangedEventArgs> AddressChanged;
    }
}
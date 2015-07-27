//-----------------------------------------------------------------------
// Copyright (c) 2015 Microsoft Corporation. All rights reserved.
// Use of this sample source code is subject to the terms of the Microsoft license 
// agreement under which you licensed this sample source code and is provided AS-IS.
// If you did not accept the terms of the license agreement, you are not authorized 
// to use this sample source code. For the terms of the license, please see the 
// license agreement between you and Microsoft.
//-----------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.MS_OXWSMTGS
{
    using System.Xml.XPath;
    using Microsoft.Protocols.TestSuites.Common;
    using Microsoft.Protocols.TestTools;
 
    /// <summary>
    /// The adapter interface which provides methods defined in MS-OXWSMTGS.
    /// </summary>
    public interface IMS_OXWSMTGSAdapter : IAdapter
    {
        /// <summary>
        /// Gets the raw XML request sent to protocol SUT
        /// </summary>
        IXPathNavigable LastRawRequestXml { get; }

        /// <summary>
        /// Gets the raw XML response received from protocol SUT
        /// </summary>
        IXPathNavigable LastRawResponseXml { get; }

        /// <summary>
        /// Get the calendar related item elements.
        /// </summary>
        /// <param name="request">A request to the GetItem operation.</param>
        /// <returns>The response message returned by GetItem operation.</returns>
        GetItemResponseType GetItem(GetItemType request);

        /// <summary>
        /// Delete the calendar related item elements.
        /// </summary>
        /// <param name="request">A request to the DeleteItem operation.</param>
        /// <returns>The response message returned by DeleteItem operation.</returns>
        DeleteItemResponseType DeleteItem(DeleteItemType request);

        /// <summary>
        /// Update the calendar related item elements.
        /// </summary>
        /// <param name="request">A request to the UpdateItem operation.</param>
        /// <returns>The response message returned by UpdateItem operation.</returns>
        UpdateItemResponseType UpdateItem(UpdateItemType request);

        /// <summary>
        /// Move the calendar related item elements.
        /// </summary>
        /// <param name="request">A request to the MoveItem operation.</param>
        /// <returns>The response message returned by MoveItem operation.</returns>
        MoveItemResponseType MoveItem(MoveItemType request);

        /// <summary>
        /// Copy the calendar related item elements.
        /// </summary>
        /// <param name="request">A request to the CopyItem operation.</param>
        /// <returns>The response message returned by CopyItem operation.</returns>
        CopyItemResponseType CopyItem(CopyItemType request);

        /// <summary>
        /// Create the calendar related item elements.
        /// </summary>
        /// <param name="request">A request to the CreateItem operation.</param>
        /// <returns>The response message returned by CreateItem operation.</returns>
        CreateItemResponseType CreateItem(CreateItemType request);

        /// <summary>
        /// Switch the current user to a new one, with the identity of the new user to communicate with Exchange Web Service.
        /// </summary>
        /// <param name="userName">The name of a user.</param>
        /// <param name="userPassword">The password of a user.</param>
        /// <param name="userDomain">The domain which the user belongs to.</param>
        void SwitchUser(string userName, string userPassword, string userDomain);
    }
}
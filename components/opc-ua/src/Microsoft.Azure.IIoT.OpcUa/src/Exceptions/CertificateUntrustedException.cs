// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Exceptions {
    using System;
    using System.Security;

    /// <summary>
    /// Thrown when the external resource is busy
    /// </summary>
    public class CertificateUntrustedException : SecurityException {

        /// <inheritdoc/>
        public CertificateUntrustedException(string message) :
            base(message) {
        }

        /// <inheritdoc/>
        public CertificateUntrustedException(string message, Exception innerException) :
            base(message, innerException) {
        }
    }
}

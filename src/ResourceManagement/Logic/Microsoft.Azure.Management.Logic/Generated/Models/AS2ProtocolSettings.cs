// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The AS2 agreement protocol settings.
    /// </summary>
    public partial class AS2ProtocolSettings
    {
        /// <summary>
        /// Initializes a new instance of the AS2ProtocolSettings class.
        /// </summary>
        public AS2ProtocolSettings() { }

        /// <summary>
        /// Initializes a new instance of the AS2ProtocolSettings class.
        /// </summary>
        /// <param name="messageConnectionSettings">The message connection
        /// settings.</param>
        /// <param name="acknowledgementConnectionSettings">The acknowledgement
        /// connection settings.</param>
        /// <param name="mdnSettings">The MDN settings.</param>
        /// <param name="securitySettings">The security settings.</param>
        /// <param name="validationSettings">The validation settings.</param>
        /// <param name="envelopeSettings">The envelope settings.</param>
        /// <param name="errorSettings">The error settings.</param>
        public AS2ProtocolSettings(AS2MessageConnectionSettings messageConnectionSettings, AS2AcknowledgementConnectionSettings acknowledgementConnectionSettings, AS2MdnSettings mdnSettings, AS2SecuritySettings securitySettings, AS2ValidationSettings validationSettings, AS2EnvelopeSettings envelopeSettings, AS2ErrorSettings errorSettings)
        {
            MessageConnectionSettings = messageConnectionSettings;
            AcknowledgementConnectionSettings = acknowledgementConnectionSettings;
            MdnSettings = mdnSettings;
            SecuritySettings = securitySettings;
            ValidationSettings = validationSettings;
            EnvelopeSettings = envelopeSettings;
            ErrorSettings = errorSettings;
        }

        /// <summary>
        /// Gets or sets the message connection settings.
        /// </summary>
        [JsonProperty(PropertyName = "messageConnectionSettings")]
        public AS2MessageConnectionSettings MessageConnectionSettings { get; set; }

        /// <summary>
        /// Gets or sets the acknowledgement connection settings.
        /// </summary>
        [JsonProperty(PropertyName = "acknowledgementConnectionSettings")]
        public AS2AcknowledgementConnectionSettings AcknowledgementConnectionSettings { get; set; }

        /// <summary>
        /// Gets or sets the MDN settings.
        /// </summary>
        [JsonProperty(PropertyName = "mdnSettings")]
        public AS2MdnSettings MdnSettings { get; set; }

        /// <summary>
        /// Gets or sets the security settings.
        /// </summary>
        [JsonProperty(PropertyName = "securitySettings")]
        public AS2SecuritySettings SecuritySettings { get; set; }

        /// <summary>
        /// Gets or sets the validation settings.
        /// </summary>
        [JsonProperty(PropertyName = "validationSettings")]
        public AS2ValidationSettings ValidationSettings { get; set; }

        /// <summary>
        /// Gets or sets the envelope settings.
        /// </summary>
        [JsonProperty(PropertyName = "envelopeSettings")]
        public AS2EnvelopeSettings EnvelopeSettings { get; set; }

        /// <summary>
        /// Gets or sets the error settings.
        /// </summary>
        [JsonProperty(PropertyName = "errorSettings")]
        public AS2ErrorSettings ErrorSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MessageConnectionSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MessageConnectionSettings");
            }
            if (AcknowledgementConnectionSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AcknowledgementConnectionSettings");
            }
            if (MdnSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MdnSettings");
            }
            if (SecuritySettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SecuritySettings");
            }
            if (ValidationSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ValidationSettings");
            }
            if (EnvelopeSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EnvelopeSettings");
            }
            if (ErrorSettings == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ErrorSettings");
            }
            if (MessageConnectionSettings != null)
            {
                MessageConnectionSettings.Validate();
            }
            if (AcknowledgementConnectionSettings != null)
            {
                AcknowledgementConnectionSettings.Validate();
            }
            if (MdnSettings != null)
            {
                MdnSettings.Validate();
            }
            if (SecuritySettings != null)
            {
                SecuritySettings.Validate();
            }
            if (ValidationSettings != null)
            {
                ValidationSettings.Validate();
            }
            if (EnvelopeSettings != null)
            {
                EnvelopeSettings.Validate();
            }
            if (ErrorSettings != null)
            {
                ErrorSettings.Validate();
            }
        }
    }
}


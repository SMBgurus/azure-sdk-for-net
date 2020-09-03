// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Request to validate export and import data details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("ValidateDataTransferDetails")]
    public partial class DataTransferDetailsValidationRequest : ValidationInputRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataTransferDetailsValidationRequest class.
        /// </summary>
        public DataTransferDetailsValidationRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DataTransferDetailsValidationRequest class.
        /// </summary>
        /// <param name="deviceType">Device type. Possible values include:
        /// 'DataBox', 'DataBoxDisk', 'DataBoxHeavy'</param>
        /// <param name="transferType">Type of the transfer. Possible values
        /// include: 'ImportToAzure', 'ExportFromAzure'</param>
        /// <param name="dataExportDetails">List of DataTransfer details to be
        /// used to export data from azure.</param>
        /// <param name="dataImportDetails">List of DataTransfer details to be
        /// used to import data to azure.</param>
        public DataTransferDetailsValidationRequest(SkuName deviceType, TransferType transferType, IList<DataExportDetails> dataExportDetails = default(IList<DataExportDetails>), IList<DataImportDetails> dataImportDetails = default(IList<DataImportDetails>))
        {
            DataExportDetails = dataExportDetails;
            DataImportDetails = dataImportDetails;
            DeviceType = deviceType;
            TransferType = transferType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of DataTransfer details to be used to export data
        /// from azure.
        /// </summary>
        [JsonProperty(PropertyName = "dataExportDetails")]
        public IList<DataExportDetails> DataExportDetails { get; set; }

        /// <summary>
        /// Gets or sets list of DataTransfer details to be used to import data
        /// to azure.
        /// </summary>
        [JsonProperty(PropertyName = "dataImportDetails")]
        public IList<DataImportDetails> DataImportDetails { get; set; }

        /// <summary>
        /// Gets or sets device type. Possible values include: 'DataBox',
        /// 'DataBoxDisk', 'DataBoxHeavy'
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public SkuName DeviceType { get; set; }

        /// <summary>
        /// Gets or sets type of the transfer. Possible values include:
        /// 'ImportToAzure', 'ExportFromAzure'
        /// </summary>
        [JsonProperty(PropertyName = "transferType")]
        public TransferType TransferType { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataExportDetails != null)
            {
                foreach (var element in DataExportDetails)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (DataImportDetails != null)
            {
                foreach (var element1 in DataImportDetails)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
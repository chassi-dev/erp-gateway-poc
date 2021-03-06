/*
 * Default/18.200.001
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 3
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Acumatica.RESTClient.Client.OpenAPIDateConverter;

namespace Acumatica.DefaultEndpoint.Model
{
    /// <summary>
    /// The parameters of the action.
    /// </summary>
    [DataContract]
    public partial class SalesOrderAddStockItemParameters :  IEquatable<SalesOrderAddStockItemParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesOrderAddStockItemParameters" /> class.
        /// </summary>
        /// <param name="barCode">barCode.</param>
        /// <param name="warehouseID">warehouseID.</param>
        /// <param name="inventory">inventory.</param>
        public SalesOrderAddStockItemParameters(StringValue barCode = default(StringValue), StringValue warehouseID = default(StringValue), StringValue inventory = default(StringValue))
        {
            this.BarCode = barCode;
            this.WarehouseID = warehouseID;
            this.Inventory = inventory;
        }

        /// <summary>
        /// Gets or Sets BarCode
        /// </summary>
        [DataMember(Name="BarCode", EmitDefaultValue=false)]
        public StringValue BarCode { get; set; }

        /// <summary>
        /// Gets or Sets WarehouseID
        /// </summary>
        [DataMember(Name="WarehouseID", EmitDefaultValue=false)]
        public StringValue WarehouseID { get; set; }

        /// <summary>
        /// Gets or Sets Inventory
        /// </summary>
        [DataMember(Name="Inventory", EmitDefaultValue=false)]
        public StringValue Inventory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesOrderAddStockItemParameters {\n");
            sb.Append("  BarCode: ").Append(BarCode).Append("\n");
            sb.Append("  WarehouseID: ").Append(WarehouseID).Append("\n");
            sb.Append("  Inventory: ").Append(Inventory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SalesOrderAddStockItemParameters);
        }

        /// <summary>
        /// Returns true if SalesOrderAddStockItemParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesOrderAddStockItemParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesOrderAddStockItemParameters input)
        {
            if (input == null)
                return false;

            return
                (
                    this.BarCode == input.BarCode ||
                    (this.BarCode != null &&
                    this.BarCode.Equals(input.BarCode))
                ) &&
                (
                    this.WarehouseID == input.WarehouseID ||
                    (this.WarehouseID != null &&
                    this.WarehouseID.Equals(input.WarehouseID))
                ) &&
                (
                    this.Inventory == input.Inventory ||
                    (this.Inventory != null &&
                    this.Inventory.Equals(input.Inventory))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BarCode != null)
                    hashCode = hashCode * 59 + this.BarCode.GetHashCode();
                if (this.WarehouseID != null)
                    hashCode = hashCode * 59 + this.WarehouseID.GetHashCode();
                if (this.Inventory != null)
                    hashCode = hashCode * 59 + this.Inventory.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

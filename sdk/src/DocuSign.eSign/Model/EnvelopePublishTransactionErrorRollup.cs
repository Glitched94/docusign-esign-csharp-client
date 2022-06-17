/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = DocuSign.eSign.Client.SwaggerDateConverter;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// EnvelopePublishTransactionErrorRollup
    /// </summary>
    [DataContract]
    public partial class EnvelopePublishTransactionErrorRollup :  IEquatable<EnvelopePublishTransactionErrorRollup>, IValidatableObject
    {
        public EnvelopePublishTransactionErrorRollup()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopePublishTransactionErrorRollup" /> class.
        /// </summary>
        /// <param name="Count">Count.</param>
        /// <param name="ErrorType">ErrorType.</param>
        public EnvelopePublishTransactionErrorRollup(string Count = default(string), string ErrorType = default(string))
        {
            this.Count = Count;
            this.ErrorType = ErrorType;
        }
        
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public string Count { get; set; }
        /// <summary>
        /// Gets or Sets ErrorType
        /// </summary>
        [DataMember(Name="errorType", EmitDefaultValue=false)]
        public string ErrorType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopePublishTransactionErrorRollup {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as EnvelopePublishTransactionErrorRollup);
        }

        /// <summary>
        /// Returns true if EnvelopePublishTransactionErrorRollup instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopePublishTransactionErrorRollup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopePublishTransactionErrorRollup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.ErrorType == other.ErrorType ||
                    this.ErrorType != null &&
                    this.ErrorType.Equals(other.ErrorType)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.ErrorType != null)
                    hash = hash * 59 + this.ErrorType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}

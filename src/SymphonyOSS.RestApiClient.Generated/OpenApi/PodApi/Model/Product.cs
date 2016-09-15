﻿// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model
{
    /// <summary>
    /// Application Product
    /// </summary>
    [DataContract]
    public partial class Product :  IEquatable<Product>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Product() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="AppId">App ID for the Product.</param>
        /// <param name="Name">Product Name (required).</param>
        /// <param name="Sku">Product SKU (required).</param>
        /// <param name="Subscribed">indicate whether the product is subscribed or not (required).</param>
        /// <param name="Type">Product Type (default or premium) (required).</param>
        public Product(string AppId = null, string Name = null, string Sku = null, bool? Subscribed = null, string Type = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Product and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Sku" is required (not null)
            if (Sku == null)
            {
                throw new InvalidDataException("Sku is a required property for Product and cannot be null");
            }
            else
            {
                this.Sku = Sku;
            }
            // to ensure "Subscribed" is required (not null)
            if (Subscribed == null)
            {
                throw new InvalidDataException("Subscribed is a required property for Product and cannot be null");
            }
            else
            {
                this.Subscribed = Subscribed;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Product and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            
            
                        this.AppId = AppId;
            
        }
        
        /// <summary>
        /// App ID for the Product
        /// </summary>
        /// <value>App ID for the Product</value>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public string AppId { get; set; }
        /// <summary>
        /// Product Name
        /// </summary>
        /// <value>Product Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Product SKU
        /// </summary>
        /// <value>Product SKU</value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }
        /// <summary>
        /// indicate whether the product is subscribed or not
        /// </summary>
        /// <value>indicate whether the product is subscribed or not</value>
        [DataMember(Name="subscribed", EmitDefaultValue=false)]
        public bool? Subscribed { get; set; }
        /// <summary>
        /// Product Type (default or premium)
        /// </summary>
        /// <value>Product Type (default or premium)</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
sb.Append("  Name: ").Append(Name).Append("\n");
sb.Append("  Sku: ").Append(Sku).Append("\n");
sb.Append("  Subscribed: ").Append(Subscribed).Append("\n");
sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="other">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AppId == other.AppId ||
                    this.AppId != null &&
                    this.AppId.Equals(other.AppId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Sku == other.Sku ||
                    this.Sku != null &&
                    this.Sku.Equals(other.Sku)
                ) && 
                (
                    this.Subscribed == other.Subscribed ||
                    this.Subscribed != null &&
                    this.Subscribed.Equals(other.Subscribed)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.AppId != null)
                    hash = hash * 59 + this.AppId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Sku != null)
                    hash = hash * 59 + this.Sku.GetHashCode();
                if (this.Subscribed != null)
                    hash = hash * 59 + this.Subscribed.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }
    }

}

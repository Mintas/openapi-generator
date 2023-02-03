// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Quadrilateral
    /// </summary>
    public partial class Quadrilateral : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quadrilateral" /> class.
        /// </summary>
        /// <param name="simpleQuadrilateral"></param>
        [JsonConstructor]
        internal Quadrilateral(SimpleQuadrilateral simpleQuadrilateral)
        {
            SimpleQuadrilateral = simpleQuadrilateral;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quadrilateral" /> class.
        /// </summary>
        /// <param name="complexQuadrilateral"></param>
        [JsonConstructor]
        internal Quadrilateral(ComplexQuadrilateral complexQuadrilateral)
        {
            ComplexQuadrilateral = complexQuadrilateral;
        }

        /// <summary>
        /// Gets or Sets SimpleQuadrilateral
        /// </summary>
        public SimpleQuadrilateral SimpleQuadrilateral { get; set; }

        /// <summary>
        /// Gets or Sets ComplexQuadrilateral
        /// </summary>
        public ComplexQuadrilateral ComplexQuadrilateral { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Quadrilateral {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type Quadrilateral
    /// </summary>
    public class QuadrilateralJsonConverter : JsonConverter<Quadrilateral>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Quadrilateral Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Utf8JsonReader simpleQuadrilateralReader = utf8JsonReader;
            bool simpleQuadrilateralDeserialized = Client.ClientUtils.TryDeserialize<SimpleQuadrilateral>(ref simpleQuadrilateralReader, jsonSerializerOptions, out SimpleQuadrilateral simpleQuadrilateral);

            Utf8JsonReader complexQuadrilateralReader = utf8JsonReader;
            bool complexQuadrilateralDeserialized = Client.ClientUtils.TryDeserialize<ComplexQuadrilateral>(ref complexQuadrilateralReader, jsonSerializerOptions, out ComplexQuadrilateral complexQuadrilateral);


            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        default:
                            break;
                    }
                }
            }

            if (simpleQuadrilateralDeserialized)
                return new Quadrilateral(simpleQuadrilateral);

            if (complexQuadrilateralDeserialized)
                return new Quadrilateral(complexQuadrilateral);

            throw new JsonException();
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="quadrilateral"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Quadrilateral quadrilateral, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();


            writer.WriteEndObject();
        }
    }
}

/*
 * Fingoti API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Fingoti.Client.OpenAPIDateConverter;

namespace Fingoti.Model
{
    /// <summary>
    /// Defines WebhookStatus
    /// </summary>
    public enum WebhookStatus
    {
        /// <summary>
        /// Enum Queued for value: 0
        /// </summary>
        Queued = 0,

        /// <summary>
        /// Enum Pending for value: 1
        /// </summary>
        Pending = 1,

        /// <summary>
        /// Enum Failed for value: 2
        /// </summary>
        Failed = 2,

        /// <summary>
        /// Enum Success for value: 3
        /// </summary>
        Success = 3

    }

}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// The properties that are associated with a function.
    /// Please note <see cref="FunctionProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AggregateFunctionProperties"/> and <see cref="ScalarFunctionProperties"/>.
    /// </summary>
    public partial class FunctionProperties
    {
        /// <summary> Initializes a new instance of FunctionProperties. </summary>
        public FunctionProperties()
        {
            Inputs = new ChangeTrackingList<FunctionInput>();
        }

        /// <summary> Initializes a new instance of FunctionProperties. </summary>
        /// <param name="functionPropertiesType"> Indicates the type of function. </param>
        /// <param name="eTag"> The current entity tag for the function. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </param>
        /// <param name="inputs"></param>
        /// <param name="output"> Describes the output of a function. </param>
        /// <param name="binding">
        /// The physical binding of the function. For example, in the Azure Machine Learning web service’s case, this describes the endpoint.
        /// Please note <see cref="FunctionBinding"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureMachineLearningStudioFunctionBinding"/>, <see cref="AzureMachineLearningServiceFunctionBinding"/>, <see cref="CSharpFunctionBinding"/> and <see cref="JavaScriptFunctionBinding"/>.
        /// </param>
        internal FunctionProperties(string functionPropertiesType, ETag? eTag, IList<FunctionInput> inputs, FunctionOutput output, FunctionBinding binding)
        {
            FunctionPropertiesType = functionPropertiesType;
            ETag = eTag;
            Inputs = inputs;
            Output = output;
            Binding = binding;
        }

        /// <summary> Indicates the type of function. </summary>
        internal string FunctionPropertiesType { get; set; }
        /// <summary> The current entity tag for the function. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </summary>
        public ETag? ETag { get; }
        /// <summary> Gets the inputs. </summary>
        public IList<FunctionInput> Inputs { get; }
        /// <summary> Describes the output of a function. </summary>
        internal FunctionOutput Output { get; set; }
        /// <summary> The (Azure Stream Analytics supported) data type of the function output. A list of valid Azure Stream Analytics data types are described at https://msdn.microsoft.com/en-us/library/azure/dn835065.aspx. </summary>
        public string OutputDataType
        {
            get => Output is null ? default : Output.DataType;
            set
            {
                if (Output is null)
                    Output = new FunctionOutput();
                Output.DataType = value;
            }
        }

        /// <summary>
        /// The physical binding of the function. For example, in the Azure Machine Learning web service’s case, this describes the endpoint.
        /// Please note <see cref="FunctionBinding"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureMachineLearningStudioFunctionBinding"/>, <see cref="AzureMachineLearningServiceFunctionBinding"/>, <see cref="CSharpFunctionBinding"/> and <see cref="JavaScriptFunctionBinding"/>.
        /// </summary>
        public FunctionBinding Binding { get; set; }
    }
}

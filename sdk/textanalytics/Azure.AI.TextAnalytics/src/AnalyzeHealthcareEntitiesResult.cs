﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// The result of the analyze heathlcare operation,
    /// containing the predicted healthcare entities, warning, and relations.
    /// </summary>
    public partial class AnalyzeHealthcareEntitiesResult : TextAnalyticsResult
    {
        private readonly IReadOnlyCollection<HealthcareEntity> _entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeHealthcareEntitiesResult"/>.
        /// </summary>
        internal AnalyzeHealthcareEntitiesResult(string id, TextDocumentStatistics statistics,
            IList<HealthcareEntity> healthcareEntities,
            IList<HealthcareEntityRelation> entityRelations,
            IList<TextAnalyticsWarning> warnings,
            IDictionary<string, object> fhirBundle)
            : this(id, statistics, healthcareEntities, entityRelations, warnings)
        {
            FhirBundle = new ReadOnlyDictionary<string, object>(fhirBundle);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeHealthcareEntitiesResult"/>.
        /// </summary>
        internal AnalyzeHealthcareEntitiesResult(string id, TextDocumentStatistics statistics,
            IList<HealthcareEntity> healthcareEntities,
            IList<HealthcareEntityRelation> entityRelations,
            IList<TextAnalyticsWarning> warnings)
            : base(id, statistics)
        {
            _entities = new ReadOnlyCollection<HealthcareEntity>(healthcareEntities);
            Warnings = new ReadOnlyCollection<TextAnalyticsWarning>(warnings);
            EntityRelations = new ReadOnlyCollection<HealthcareEntityRelation>(entityRelations);
            FhirBundle = new Dictionary<string, object>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyzeHealthcareEntitiesResult"/>.
        /// </summary>
        /// <param name="id">Analyze operation id.</param>
        /// <param name="error">Operation error object.</param>
        internal AnalyzeHealthcareEntitiesResult(string id, TextAnalyticsError error) : base(id, error) { }

        /// <summary>
        /// Warnings encountered while processing document.
        /// </summary>
        public IReadOnlyCollection<TextAnalyticsWarning> Warnings { get; } = new List<TextAnalyticsWarning>();

        /// <summary>
        /// Gets the collection of healthcare entities in the document.
        /// </summary>
        public IReadOnlyCollection<HealthcareEntity> Entities
        {
            get
            {
                if (HasError)
                {
#pragma warning disable CA1065 // Do not raise exceptions in unexpected locations
                    throw new InvalidOperationException($"Cannot access result for document {Id}, due to error {Error.ErrorCode}: {Error.Message}");
#pragma warning restore CA1065 // Do not raise exceptions in unexpected locations
                }
                return _entities;
            }
        }

        /// <summary>
        /// Gets the relations between the entities. <see cref="HealthcareEntityRelation"/>.
        /// </summary>
        public IReadOnlyCollection<HealthcareEntityRelation> EntityRelations { get; }

        /// <summary>
        /// If <see cref="AnalyzeHealthcareEntitiesOptions.FhirVersion"/> is set, this will contain a
        /// FHIR compatible object for consumption in other Healthcare tools.
        /// For additional information see <see href="https://www.hl7.org/fhir/overview.html"/> .
        /// </summary>
        /// <remarks>
        /// This property only applies for <see cref="TextAnalyticsClientOptions.ServiceVersion.V2022_04_01_Preview"/> and up.
        /// </remarks>
        public IReadOnlyDictionary<string, object> FhirBundle { get; }
    }
}

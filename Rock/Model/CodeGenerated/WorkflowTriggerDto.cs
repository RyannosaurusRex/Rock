//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

using Rock.Data;

namespace Rock.Model
{
    /// <summary>
    /// Data Transfer Object for WorkflowTrigger object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class WorkflowTriggerDto : Dto
    {
        /// <summary />
        [DataMember]
        public bool IsSystem { get; set; }

        /// <summary />
        [DataMember]
        public int EntityTypeId { get; set; }

        /// <summary />
        [DataMember]
        public string EntityTypeQualifierColumn { get; set; }

        /// <summary />
        [DataMember]
        public string EntityTypeQualifierValue { get; set; }

        /// <summary />
        [DataMember]
        public int WorkflowTypeId { get; set; }

        /// <summary />
        [DataMember]
        public WorkflowTriggerType WorkflowTriggerType { get; set; }

        /// <summary />
        [DataMember]
        public string WorkflowName { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public WorkflowTriggerDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="workflowTrigger"></param>
        public WorkflowTriggerDto ( WorkflowTrigger workflowTrigger )
        {
            CopyFromModel( workflowTrigger );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, object> ToDictionary()
        {
            var dictionary = base.ToDictionary();
            dictionary.Add( "IsSystem", this.IsSystem );
            dictionary.Add( "EntityTypeId", this.EntityTypeId );
            dictionary.Add( "EntityTypeQualifierColumn", this.EntityTypeQualifierColumn );
            dictionary.Add( "EntityTypeQualifierValue", this.EntityTypeQualifierValue );
            dictionary.Add( "WorkflowTypeId", this.WorkflowTypeId );
            dictionary.Add( "WorkflowTriggerType", this.WorkflowTriggerType );
            dictionary.Add( "WorkflowName", this.WorkflowName );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public override dynamic ToDynamic()
        {
            dynamic expando = base.ToDynamic();
            expando.IsSystem = this.IsSystem;
            expando.EntityTypeId = this.EntityTypeId;
            expando.EntityTypeQualifierColumn = this.EntityTypeQualifierColumn;
            expando.EntityTypeQualifierValue = this.EntityTypeQualifierValue;
            expando.WorkflowTypeId = this.WorkflowTypeId;
            expando.WorkflowTriggerType = this.WorkflowTriggerType;
            expando.WorkflowName = this.WorkflowName;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyFromModel( IEntity model )
        {
            base.CopyFromModel( model );

            if ( model is WorkflowTrigger )
            {
                var workflowTrigger = (WorkflowTrigger)model;
                this.IsSystem = workflowTrigger.IsSystem;
                this.EntityTypeId = workflowTrigger.EntityTypeId;
                this.EntityTypeQualifierColumn = workflowTrigger.EntityTypeQualifierColumn;
                this.EntityTypeQualifierValue = workflowTrigger.EntityTypeQualifierValue;
                this.WorkflowTypeId = workflowTrigger.WorkflowTypeId;
                this.WorkflowTriggerType = workflowTrigger.WorkflowTriggerType;
                this.WorkflowName = workflowTrigger.WorkflowName;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyToModel ( IEntity model )
        {
            base.CopyToModel( model );

            if ( model is WorkflowTrigger )
            {
                var workflowTrigger = (WorkflowTrigger)model;
                workflowTrigger.IsSystem = this.IsSystem;
                workflowTrigger.EntityTypeId = this.EntityTypeId;
                workflowTrigger.EntityTypeQualifierColumn = this.EntityTypeQualifierColumn;
                workflowTrigger.EntityTypeQualifierValue = this.EntityTypeQualifierValue;
                workflowTrigger.WorkflowTypeId = this.WorkflowTypeId;
                workflowTrigger.WorkflowTriggerType = this.WorkflowTriggerType;
                workflowTrigger.WorkflowName = this.WorkflowName;
            }
        }

    }


    /// <summary>
    /// WorkflowTrigger Extension Methods
    /// </summary>
    public static class WorkflowTriggerExtensions
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static WorkflowTrigger ToModel( this WorkflowTriggerDto value )
        {
            WorkflowTrigger result = new WorkflowTrigger();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<WorkflowTrigger> ToModel( this List<WorkflowTriggerDto> value )
        {
            List<WorkflowTrigger> result = new List<WorkflowTrigger>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<WorkflowTriggerDto> ToDto( this List<WorkflowTrigger> value )
        {
            List<WorkflowTriggerDto> result = new List<WorkflowTriggerDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static WorkflowTriggerDto ToDto( this WorkflowTrigger value )
        {
            return new WorkflowTriggerDto( value );
        }

        /// <summary>
        /// To the json.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public static string ToJson( this WorkflowTrigger value, bool deep = false )
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject( ToDynamic( value, deep ) );
        }

        /// <summary>
        /// To the dynamic.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public static List<dynamic> ToDynamic( this ICollection<WorkflowTrigger> values )
        {
            var dynamicList = new List<dynamic>();
            foreach ( var value in values )
            {
                dynamicList.Add( value.ToDynamic( true ) );
            }
            return dynamicList;
        }

        /// <summary>
        /// To the dynamic.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public static dynamic ToDynamic( this WorkflowTrigger value, bool deep = false )
        {
            dynamic dynamicWorkflowTrigger = new WorkflowTriggerDto( value ).ToDynamic();

            if ( !deep )
            {
                return dynamicWorkflowTrigger;
            }

            dynamicWorkflowTrigger.EntityType = value.EntityType.ToDynamic();
            dynamicWorkflowTrigger.WorkflowType = value.WorkflowType.ToDynamic();

            return dynamicWorkflowTrigger;
        }

        /// <summary>
        /// Froms the dynamic.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="obj">The obj.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        public static void FromDynamic( this WorkflowTrigger value, object obj, bool deep = false )
        {
            new PageDto().FromDynamic(obj).CopyToModel(value);

            if (deep)
            {
                var expando = obj as ExpandoObject;
                if (obj != null)
                {
                    var dict = obj as IDictionary<string, object>;
                    if (dict != null)
                    {

                        new EntityTypeDto().FromDynamic( dict["EntityType"] ).CopyToModel(value.EntityType);
                        new WorkflowTypeDto().FromDynamic( dict["WorkflowType"] ).CopyToModel(value.WorkflowType);

                    }
                }
            }
        }

    }
}
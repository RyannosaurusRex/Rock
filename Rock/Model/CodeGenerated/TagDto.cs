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
    /// Data Transfer Object for Tag object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class TagDto : DtoSecured<TagDto>
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
        public string Name { get; set; }

        /// <summary />
        [DataMember]
        public int Order { get; set; }

        /// <summary />
        [DataMember]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public TagDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="tag"></param>
        public TagDto ( Tag tag )
        {
            CopyFromModel( tag );
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
            dictionary.Add( "Name", this.Name );
            dictionary.Add( "Order", this.Order );
            dictionary.Add( "OwnerId", this.OwnerId );
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
            expando.Name = this.Name;
            expando.Order = this.Order;
            expando.OwnerId = this.OwnerId;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyFromModel( IEntity model )
        {
            base.CopyFromModel( model );

            if ( model is Tag )
            {
                var tag = (Tag)model;
                this.IsSystem = tag.IsSystem;
                this.EntityTypeId = tag.EntityTypeId;
                this.EntityTypeQualifierColumn = tag.EntityTypeQualifierColumn;
                this.EntityTypeQualifierValue = tag.EntityTypeQualifierValue;
                this.Name = tag.Name;
                this.Order = tag.Order;
                this.OwnerId = tag.OwnerId;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyToModel ( IEntity model )
        {
            base.CopyToModel( model );

            if ( model is Tag )
            {
                var tag = (Tag)model;
                tag.IsSystem = this.IsSystem;
                tag.EntityTypeId = this.EntityTypeId;
                tag.EntityTypeQualifierColumn = this.EntityTypeQualifierColumn;
                tag.EntityTypeQualifierValue = this.EntityTypeQualifierValue;
                tag.Name = this.Name;
                tag.Order = this.Order;
                tag.OwnerId = this.OwnerId;
            }
        }

    }


    /// <summary>
    /// Tag Extension Methods
    /// </summary>
    public static class TagExtensions
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Tag ToModel( this TagDto value )
        {
            Tag result = new Tag();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<Tag> ToModel( this List<TagDto> value )
        {
            List<Tag> result = new List<Tag>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<TagDto> ToDto( this List<Tag> value )
        {
            List<TagDto> result = new List<TagDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static TagDto ToDto( this Tag value )
        {
            return new TagDto( value );
        }

        /// <summary>
        /// To the json.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public static string ToJson( this Tag value, bool deep = false )
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject( ToDynamic( value, deep ) );
        }

        /// <summary>
        /// To the dynamic.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public static List<dynamic> ToDynamic( this ICollection<Tag> values )
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
        public static dynamic ToDynamic( this Tag value, bool deep = false )
        {
            dynamic dynamicTag = new TagDto( value ).ToDynamic();

            if ( !deep )
            {
                return dynamicTag;
            }

            dynamicTag.Owner = value.Owner.ToDynamic();
            dynamicTag.EntityType = value.EntityType.ToDynamic();
            dynamicTag.TaggedItems = value.TaggedItems.ToDynamic();

            return dynamicTag;
        }

        /// <summary>
        /// Froms the dynamic.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="obj">The obj.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        public static void FromDynamic( this Tag value, object obj, bool deep = false )
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

                        new PersonDto().FromDynamic( dict["Owner"] ).CopyToModel(value.Owner);
                        new EntityTypeDto().FromDynamic( dict["EntityType"] ).CopyToModel(value.EntityType);
                        var TaggedItemsList = dict["TaggedItems"] as List<object>;
                        if (TaggedItemsList != null)
                        {
                            value.TaggedItems = new List<TaggedItem>();
                            foreach(object childObj in TaggedItemsList)
                            {
                                var TaggedItem = new TaggedItem();
                                new TaggedItemDto().FromDynamic(childObj).CopyToModel(TaggedItem);
                                value.TaggedItems.Add(TaggedItem);
                            }
                        }


                    }
                }
            }
        }

    }
}
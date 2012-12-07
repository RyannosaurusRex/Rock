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
    /// Data Transfer Object for HtmlContent object
    /// </summary>
    [Serializable]
    [DataContract]
    public partial class HtmlContentDto : DtoSecured<HtmlContentDto>
    {
        /// <summary />
        [DataMember]
        public int BlockId { get; set; }

        /// <summary />
        [DataMember]
        public string EntityValue { get; set; }

        /// <summary />
        [DataMember]
        public int Version { get; set; }

        /// <summary />
        [DataMember]
        public string Content { get; set; }

        /// <summary />
        [DataMember]
        public bool IsApproved { get; set; }

        /// <summary />
        [DataMember]
        public int? ApprovedByPersonId { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? ApprovedDateTime { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? StartDateTime { get; set; }

        /// <summary />
        [DataMember]
        public DateTime? ExpireDateTime { get; set; }

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public HtmlContentDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="htmlContent"></param>
        public HtmlContentDto ( HtmlContent htmlContent )
        {
            CopyFromModel( htmlContent );
        }

        /// <summary>
        /// Creates a dictionary object.
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, object> ToDictionary()
        {
            var dictionary = base.ToDictionary();
            dictionary.Add( "BlockId", this.BlockId );
            dictionary.Add( "EntityValue", this.EntityValue );
            dictionary.Add( "Version", this.Version );
            dictionary.Add( "Content", this.Content );
            dictionary.Add( "IsApproved", this.IsApproved );
            dictionary.Add( "ApprovedByPersonId", this.ApprovedByPersonId );
            dictionary.Add( "ApprovedDateTime", this.ApprovedDateTime );
            dictionary.Add( "StartDateTime", this.StartDateTime );
            dictionary.Add( "ExpireDateTime", this.ExpireDateTime );
            return dictionary;
        }

        /// <summary>
        /// Creates a dynamic object.
        /// </summary>
        /// <returns></returns>
        public override dynamic ToDynamic()
        {
            dynamic expando = base.ToDynamic();
            expando.BlockId = this.BlockId;
            expando.EntityValue = this.EntityValue;
            expando.Version = this.Version;
            expando.Content = this.Content;
            expando.IsApproved = this.IsApproved;
            expando.ApprovedByPersonId = this.ApprovedByPersonId;
            expando.ApprovedDateTime = this.ApprovedDateTime;
            expando.StartDateTime = this.StartDateTime;
            expando.ExpireDateTime = this.ExpireDateTime;
            return expando;
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyFromModel( IEntity model )
        {
            base.CopyFromModel( model );

            if ( model is HtmlContent )
            {
                var htmlContent = (HtmlContent)model;
                this.BlockId = htmlContent.BlockId;
                this.EntityValue = htmlContent.EntityValue;
                this.Version = htmlContent.Version;
                this.Content = htmlContent.Content;
                this.IsApproved = htmlContent.IsApproved;
                this.ApprovedByPersonId = htmlContent.ApprovedByPersonId;
                this.ApprovedDateTime = htmlContent.ApprovedDateTime;
                this.StartDateTime = htmlContent.StartDateTime;
                this.ExpireDateTime = htmlContent.ExpireDateTime;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public override void CopyToModel ( IEntity model )
        {
            base.CopyToModel( model );

            if ( model is HtmlContent )
            {
                var htmlContent = (HtmlContent)model;
                htmlContent.BlockId = this.BlockId;
                htmlContent.EntityValue = this.EntityValue;
                htmlContent.Version = this.Version;
                htmlContent.Content = this.Content;
                htmlContent.IsApproved = this.IsApproved;
                htmlContent.ApprovedByPersonId = this.ApprovedByPersonId;
                htmlContent.ApprovedDateTime = this.ApprovedDateTime;
                htmlContent.StartDateTime = this.StartDateTime;
                htmlContent.ExpireDateTime = this.ExpireDateTime;
            }
        }

    }


    /// <summary>
    /// HtmlContent Extension Methods
    /// </summary>
    public static class HtmlContentExtensions
    {
        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static HtmlContent ToModel( this HtmlContentDto value )
        {
            HtmlContent result = new HtmlContent();
            value.CopyToModel( result );
            return result;
        }

        /// <summary>
        /// To the model.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<HtmlContent> ToModel( this List<HtmlContentDto> value )
        {
            List<HtmlContent> result = new List<HtmlContent>();
            value.ForEach( a => result.Add( a.ToModel() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static List<HtmlContentDto> ToDto( this List<HtmlContent> value )
        {
            List<HtmlContentDto> result = new List<HtmlContentDto>();
            value.ForEach( a => result.Add( a.ToDto() ) );
            return result;
        }

        /// <summary>
        /// To the dto.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static HtmlContentDto ToDto( this HtmlContent value )
        {
            return new HtmlContentDto( value );
        }

        /// <summary>
        /// To the json.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        /// <returns></returns>
        public static string ToJson( this HtmlContent value, bool deep = false )
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject( ToDynamic( value, deep ) );
        }

        /// <summary>
        /// To the dynamic.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        public static List<dynamic> ToDynamic( this ICollection<HtmlContent> values )
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
        public static dynamic ToDynamic( this HtmlContent value, bool deep = false )
        {
            dynamic dynamicHtmlContent = new HtmlContentDto( value ).ToDynamic();

            if ( !deep )
            {
                return dynamicHtmlContent;
            }

            dynamicHtmlContent.ApprovedByPerson = value.ApprovedByPerson.ToDynamic();

            return dynamicHtmlContent;
        }

        /// <summary>
        /// Froms the dynamic.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="obj">The obj.</param>
        /// <param name="deep">if set to <c>true</c> [deep].</param>
        public static void FromDynamic( this HtmlContent value, object obj, bool deep = false )
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

                        new PersonDto().FromDynamic( dict["ApprovedByPerson"] ).CopyToModel(value.ApprovedByPerson);

                    }
                }
            }
        }

    }
}
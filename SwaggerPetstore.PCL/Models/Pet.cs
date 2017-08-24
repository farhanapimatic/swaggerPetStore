/*
 * SwaggerPetstore.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerPetstore.PCL;
using SwaggerPetstore.PCL.Utilities;


namespace SwaggerPetstore.PCL.Models
{
    public class Pet : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string name;
        private List<string> photoUrls;
        private long? id;
        private Models.Category category;
        private List<Models.Tag> tags;
        private Models.Status7Enum? status;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("name")]
        public string Name 
        { 
            get 
            {
                return this.name; 
            } 
            set 
            {
                this.name = value;
                onPropertyChanged("Name");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("photoUrls")]
        public List<string> PhotoUrls 
        { 
            get 
            {
                return this.photoUrls; 
            } 
            set 
            {
                this.photoUrls = value;
                onPropertyChanged("PhotoUrls");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("id")]
        public long? Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("category")]
        public Models.Category Category 
        { 
            get 
            {
                return this.category; 
            } 
            set 
            {
                this.category = value;
                onPropertyChanged("Category");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("tags")]
        public List<Models.Tag> Tags 
        { 
            get 
            {
                return this.tags; 
            } 
            set 
            {
                this.tags = value;
                onPropertyChanged("Tags");
            }
        }

        /// <summary>
        /// pet status in the store
        /// </summary>
        [JsonProperty("status", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.Status7Enum? Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }
    }
} 
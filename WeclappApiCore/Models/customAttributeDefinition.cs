using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class customAttributeDefinition
    {
        //        id(string, optional),
        //version(string, optional),
        //active(boolean),
        //attributeKey(string),
        //attributeLabels(Array[customAttributeDefinitionLabel], optional),
        //attributeType(string),
        //createdDate(integer, optional),
        //lastModifiedDate(integer, optional),
        //mandatory(boolean, optional),
        //selectableValues (Array[customAttributeDefinitionListValue], optional)
    

    public string id { get; set; }
        public string version { get; set; }
        public bool active { get; set; }
        public string attributeKey { get; set; }
        List<customAttributeDefinitionLabel> attributeLabels = new List<customAttributeDefinitionLabel>();
        public string attributeType { get; set; }
        public Int32 createdDate { get; set; }
        public Int32 lastModifiedDate { get; set; }
        public bool mandatory { get; set; }
        
        List<customAttributeDefinitionListValue> selectableValues = new List<customAttributeDefinitionListValue>();
        

    }
}
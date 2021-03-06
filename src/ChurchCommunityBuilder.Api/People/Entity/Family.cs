﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChurchCommunityBuilder.Api.Entity;
using System.Xml;
using System.Xml.Serialization;

namespace ChurchCommunityBuilder.Api.People.Entity {
    [XmlRoot]
    public class Family {
        [XmlAttribute("id")]
        public int ID { get; set; }

        [XmlElement("individuals")]
        public IndividualCollection Individuals { get; set; }

    }
}
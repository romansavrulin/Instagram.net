﻿using System;

namespace Instagram.api.classes{
    [Serializable]
    public class Relation : InstagramBaseObject
    {
        public string outgoing_status;
        public string incoming_status;
    }
}
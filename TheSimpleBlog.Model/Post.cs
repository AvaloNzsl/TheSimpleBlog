using System;
using System.Collections.Generic;

namespace TheSimpleBlog.Model
{
    public class Post
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string ShortDescription { get; set; }
        public virtual string Description { get; set; }

        // -> Meta - that property is used to store the metadata description for the post
        public virtual string Meta { get; set; }
        // UrlSlug -> is an alternate for the Title property to use in address
        public virtual string UrlSlug { get; set; } 

        public virtual DateTime PostedOn { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual IList<Tag> Tags { get; set; }
    }
}

/*  All properties are maked as virtual -> it is important 
 *  because NHibernate creates a runtime proxy for this class 
 *  and for that all the properties needs to be - virtual - 
*/

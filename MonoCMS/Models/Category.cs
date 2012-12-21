using System;
using PetaPoco;
using System.ComponentModel.DataAnnotations;


namespace MonoCMS.Models
{
	[TableName("category")]
	[PrimaryKey("id_category")]
	public class Category
	{
		[Column("id_category")]
		public int IDCategory { get; set; }
		
		[Column("parent_id")]
		public int ParentID { get; set; }

		[Column("level")]
		public int Level { get; set; }

		[Required]
		[Column("category_name")]
		public string CategoryName { get; set; }

		[Column("description")]
		public string Description {get; set;}

		[Column("user_id")]
		public int UserID {get; set;}

		[Column("link_rewrite")]
		public string LinkRewrite { get; set; }

		[Column("page_title")]
		public string PageTitle { get; set; }

		[Column("meta_description")]
		public string MetaDescription {get; set;}

		[Column("meta_keywords")]
		public string MetaKeyword { get; set; }

		[Column("created")]
		public DateTime DateAdd {get; set;}

		[Column("modified")]
		public DateTime DateUpdate { get; set; }

	}
}


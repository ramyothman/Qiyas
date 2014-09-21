using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using DataAccessLayer.DataAccessComponents.ContentManagement;
using BusinessLogicLayer.Entities.ContentManagement;
namespace BusinessLogicLayer.Components.ContentManagement
{
	/// <summary>
	/// This is a Business Logic Component Class  for Article table
	/// This class RAPs the ArticleDAC class and helps the UI to insert,select,update and delete data
	/// </summary>
	[DataObject(true)]
	public partial class ArticleLogic : BusinessLogic
	{
		public ArticleLogic(){}

        [DataObjectMethod(DataObjectMethodType.Select)]
         public List<Article> GetAll()
         {
             ArticleDAC _articleComponent = new ArticleDAC();
             IDataReader reader =  _articleComponent.GetAllArticle().CreateDataReader();
             List<Article> _articleList = new List<Article>();
             while(reader.Read())
             {
             if(_articleList == null)
                 _articleList = new List<Article>();
                 Article _article = new Article();
                 if(reader["ArticleId"] != DBNull.Value)
                     _article.ArticleId = Convert.ToInt32(reader["ArticleId"]);
                 if(reader["SiteSectionId"] != DBNull.Value)
                     _article.SiteSectionId = Convert.ToInt32(reader["SiteSectionId"]);
                 if(reader["CreatorId"] != DBNull.Value)
                     _article.CreatorId = Convert.ToInt32(reader["CreatorId"]);
                 if(reader["ArticleStatusId"] != DBNull.Value)
                     _article.ArticleStatusId = Convert.ToInt32(reader["ArticleStatusId"]);
                 if(reader["AuthorId"] != DBNull.Value)
                     _article.AuthorId = Convert.ToInt32(reader["AuthorId"]);
                 if(reader["PostDate"] != DBNull.Value)
                     _article.PostDate = Convert.ToDateTime(reader["PostDate"]);
                 if(reader["AllowLanguageSpecificTags"] != DBNull.Value)
                     _article.AllowLanguageSpecificTags = Convert.ToBoolean(reader["AllowLanguageSpecificTags"]);
                 if(reader["RowGuid"] != DBNull.Value)
                     _article.RowGuid = new Guid(reader["RowGuid"].ToString());
                 if(reader["ModifiedDate"] != DBNull.Value)
                     _article.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);
                 if(reader["CommentsTypeId"] != DBNull.Value)
                     _article.CommentsTypeId = Convert.ToInt32(reader["CommentsTypeId"]);
                 if(reader["EnableModeteration"] != DBNull.Value)
                     _article.EnableModeteration = Convert.ToBoolean(reader["EnableModeteration"]);
                 if (reader["SiteId"] != DBNull.Value)
                     _article.SiteId = Convert.ToInt32(reader["SiteId"]);
             _article.NewRecord = false;
             _articleList.Add(_article);
             }             reader.Close();
             return _articleList;
         }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Article> GetAllBySiteId(string SiteId)
        {
            ArticleDAC _articleComponent = new ArticleDAC();
            string whereCondition = "";
            if (!string.IsNullOrEmpty(SiteId) && SiteId != "0")
            {
                whereCondition = "SiteId = " + SiteId;
            }
            IDataReader reader = _articleComponent.GetAllArticle(whereCondition).CreateDataReader();
            List<Article> _articleList = new List<Article>();
            while (reader.Read())
            {
                if (_articleList == null)
                    _articleList = new List<Article>();
                Article _article = new Article();
                if (reader["ArticleId"] != DBNull.Value)
                    _article.ArticleId = Convert.ToInt32(reader["ArticleId"]);
                if (reader["SiteSectionId"] != DBNull.Value)
                    _article.SiteSectionId = Convert.ToInt32(reader["SiteSectionId"]);
                if (reader["CreatorId"] != DBNull.Value)
                    _article.CreatorId = Convert.ToInt32(reader["CreatorId"]);
                if (reader["ArticleStatusId"] != DBNull.Value)
                    _article.ArticleStatusId = Convert.ToInt32(reader["ArticleStatusId"]);
                if (reader["AuthorId"] != DBNull.Value)
                    _article.AuthorId = Convert.ToInt32(reader["AuthorId"]);
                if (reader["PostDate"] != DBNull.Value)
                    _article.PostDate = Convert.ToDateTime(reader["PostDate"]);
                if (reader["AllowLanguageSpecificTags"] != DBNull.Value)
                    _article.AllowLanguageSpecificTags = Convert.ToBoolean(reader["AllowLanguageSpecificTags"]);
                if (reader["RowGuid"] != DBNull.Value)
                    _article.RowGuid = new Guid(reader["RowGuid"].ToString());
                if (reader["ModifiedDate"] != DBNull.Value)
                    _article.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);
                if (reader["CommentsTypeId"] != DBNull.Value)
                    _article.CommentsTypeId = Convert.ToInt32(reader["CommentsTypeId"]);
                if (reader["EnableModeteration"] != DBNull.Value)
                    _article.EnableModeteration = Convert.ToBoolean(reader["EnableModeteration"]);
                if (reader["SiteId"] != DBNull.Value)
                    _article.SiteId = Convert.ToInt32(reader["SiteId"]);
                _article.NewRecord = false;
                _articleList.Add(_article);
            } reader.Close();
            return _articleList;
        }



        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Article> GetAllBySectionId(string SiteSectionId)
        {
            ArticleDAC _articleComponent = new ArticleDAC();
            string whereCondition = "";
            if (!string.IsNullOrEmpty(SiteSectionId) && SiteSectionId != "0")
            {
                whereCondition = "SiteSectionId = " + SiteSectionId;
            }
            IDataReader reader = _articleComponent.GetAllArticle(whereCondition).CreateDataReader();
            List<Article> _articleList = new List<Article>();
            while (reader.Read())
            {
                if (_articleList == null)
                    _articleList = new List<Article>();
                Article _article = new Article();
                if (reader["ArticleId"] != DBNull.Value)
                    _article.ArticleId = Convert.ToInt32(reader["ArticleId"]);
                if (reader["SiteSectionId"] != DBNull.Value)
                    _article.SiteSectionId = Convert.ToInt32(reader["SiteSectionId"]);
                if (reader["CreatorId"] != DBNull.Value)
                    _article.CreatorId = Convert.ToInt32(reader["CreatorId"]);
                if (reader["ArticleStatusId"] != DBNull.Value)
                    _article.ArticleStatusId = Convert.ToInt32(reader["ArticleStatusId"]);
                if (reader["AuthorId"] != DBNull.Value)
                    _article.AuthorId = Convert.ToInt32(reader["AuthorId"]);
                if (reader["PostDate"] != DBNull.Value)
                    _article.PostDate = Convert.ToDateTime(reader["PostDate"]);
                if (reader["AllowLanguageSpecificTags"] != DBNull.Value)
                    _article.AllowLanguageSpecificTags = Convert.ToBoolean(reader["AllowLanguageSpecificTags"]);
                if (reader["RowGuid"] != DBNull.Value)
                    _article.RowGuid = new Guid(reader["RowGuid"].ToString());
                if (reader["ModifiedDate"] != DBNull.Value)
                    _article.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);
                if (reader["CommentsTypeId"] != DBNull.Value)
                    _article.CommentsTypeId = Convert.ToInt32(reader["CommentsTypeId"]);
                if (reader["EnableModeteration"] != DBNull.Value)
                    _article.EnableModeteration = Convert.ToBoolean(reader["EnableModeteration"]);
                if (reader["SiteId"] != DBNull.Value)
                    _article.SiteId = Convert.ToInt32(reader["SiteId"]);
                _article.NewRecord = false;
                _articleList.Add(_article);
            } reader.Close();
            return _articleList;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Article> GetAllBySectionId(string SiteSectionId,int LanguageID)
        {
            ArticleDAC _articleComponent = new ArticleDAC();
            string whereCondition = "";
            if (!string.IsNullOrEmpty(SiteSectionId) && SiteSectionId != "0")
            {
                whereCondition = "SiteSectionId = " + SiteSectionId;
            }
            IDataReader reader = _articleComponent.GetAllArticle(whereCondition).CreateDataReader();
            List<Article> _articleList = new List<Article>();
            while (reader.Read())
            {
                if (_articleList == null)
                    _articleList = new List<Article>();
                Article _article = new Article();
                if (reader["ArticleId"] != DBNull.Value)
                    _article.ArticleId = Convert.ToInt32(reader["ArticleId"]);
                if (reader["SiteSectionId"] != DBNull.Value)
                    _article.SiteSectionId = Convert.ToInt32(reader["SiteSectionId"]);
                if (reader["CreatorId"] != DBNull.Value)
                    _article.CreatorId = Convert.ToInt32(reader["CreatorId"]);
                if (reader["ArticleStatusId"] != DBNull.Value)
                    _article.ArticleStatusId = Convert.ToInt32(reader["ArticleStatusId"]);
                if (reader["AuthorId"] != DBNull.Value)
                    _article.AuthorId = Convert.ToInt32(reader["AuthorId"]);
                if (reader["PostDate"] != DBNull.Value)
                    _article.PostDate = Convert.ToDateTime(reader["PostDate"]);
                if (reader["AllowLanguageSpecificTags"] != DBNull.Value)
                    _article.AllowLanguageSpecificTags = Convert.ToBoolean(reader["AllowLanguageSpecificTags"]);
                if (reader["RowGuid"] != DBNull.Value)
                    _article.RowGuid = new Guid(reader["RowGuid"].ToString());
                if (reader["ModifiedDate"] != DBNull.Value)
                    _article.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);
                if (reader["CommentsTypeId"] != DBNull.Value)
                    _article.CommentsTypeId = Convert.ToInt32(reader["CommentsTypeId"]);
                if (reader["EnableModeteration"] != DBNull.Value)
                    _article.EnableModeteration = Convert.ToBoolean(reader["EnableModeteration"]);
                if (reader["SiteId"] != DBNull.Value)
                    _article.SiteId = Convert.ToInt32(reader["SiteId"]);
                _article.DefaultLanguage = LanguageID;
                _article.NewRecord = false;
                _articleList.Add(_article);
            } reader.Close();
            return _articleList;
        }

        #region Insert And Update
		public bool Insert(Article article)
		{
			ArticleDAC articleComponent = new ArticleDAC();
            int id = 0;
            BusinessLogicLayer.Common.ContentEntityLogic.Insert(ref id, "CA", Guid.NewGuid(), DateTime.Now);
            article.ArticleId = id;
            article.RowGuid = Guid.NewGuid();
            article.ModifiedDate = DateTime.Now;
            article.CommentsTypeId = 1;
			return articleComponent.InsertNewArticle( article.ArticleId,  article.SiteSectionId,  article.CreatorId,  article.ArticleStatusId,  article.AuthorId,  article.PostDate,  article.AllowLanguageSpecificTags,  article.RowGuid,  article.ModifiedDate,  article.CommentsTypeId,  article.EnableModeteration);
		}
         [DataObjectMethod(DataObjectMethodType.Insert)]
		public bool Insert( int ArticleId,  int SiteSectionId,  int CreatorId,  int ArticleStatusId,  int AuthorId,  DateTime PostDate,  bool AllowLanguageSpecificTags,  Guid RowGuid,  DateTime ModifiedDate,  int CommentsTypeId,  bool EnableModeteration)
		{
			ArticleDAC articleComponent = new ArticleDAC();
            int id = 0;
            BusinessLogicLayer.Common.ContentEntityLogic.Insert(ref id, "CA", Guid.NewGuid(), DateTime.Now);
            ArticleId = id;
			return articleComponent.InsertNewArticle( ArticleId,  SiteSectionId,  CreatorId,  ArticleStatusId,  AuthorId,  PostDate,  AllowLanguageSpecificTags,  RowGuid,  ModifiedDate,  CommentsTypeId,  EnableModeteration);
		}
		public bool Update(Article article ,int old_articleId)
		{
			ArticleDAC articleComponent = new ArticleDAC();
			return articleComponent.UpdateArticle( article.ArticleId,  article.SiteSectionId,  article.CreatorId,  article.ArticleStatusId,  article.AuthorId,  article.PostDate,  article.AllowLanguageSpecificTags,  article.RowGuid,  article.ModifiedDate,  article.CommentsTypeId,  article.EnableModeteration,  old_articleId);
		}
		[DataObjectMethod(DataObjectMethodType.Update)]
		public bool Update( int ArticleId,  int SiteSectionId,  int CreatorId,  int ArticleStatusId,  int AuthorId,  DateTime PostDate,  bool AllowLanguageSpecificTags,  Guid RowGuid,  DateTime ModifiedDate,  int CommentsTypeId,  bool EnableModeteration,  int Original_ArticleId)
		{
			ArticleDAC articleComponent = new ArticleDAC();
			return articleComponent.UpdateArticle( ArticleId,  SiteSectionId,  CreatorId,  ArticleStatusId,  AuthorId,  PostDate,  AllowLanguageSpecificTags,  RowGuid,  ModifiedDate,  CommentsTypeId,  EnableModeteration,  Original_ArticleId);
		}

        #endregion

        #region DeleteData

        [DataObjectMethod(DataObjectMethodType.Delete)]
		public void Delete(int Original_ArticleId)
		{
			ArticleDAC articleComponent = new ArticleDAC();
			articleComponent.DeleteArticle(Original_ArticleId);
		}

        #endregion

        public Article GetCurrentAnnouncement()
        {
            ArticleDAC _articleComponent = new ArticleDAC();
            IDataReader reader = _articleComponent.GetCurrentAnnouncement();
            Article _article = null;
            while (reader.Read())
            {
                _article = new Article();
                if (reader["ArticleId"] != DBNull.Value)
                    _article.ArticleId = Convert.ToInt32(reader["ArticleId"]);
                if (reader["SiteSectionId"] != DBNull.Value)
                    _article.SiteSectionId = Convert.ToInt32(reader["SiteSectionId"]);
                if (reader["CreatorId"] != DBNull.Value)
                    _article.CreatorId = Convert.ToInt32(reader["CreatorId"]);
                if (reader["ArticleStatusId"] != DBNull.Value)
                    _article.ArticleStatusId = Convert.ToInt32(reader["ArticleStatusId"]);
                if (reader["AuthorId"] != DBNull.Value)
                    _article.AuthorId = Convert.ToInt32(reader["AuthorId"]);
                if (reader["PostDate"] != DBNull.Value)
                    _article.PostDate = Convert.ToDateTime(reader["PostDate"]);
                if (reader["AllowLanguageSpecificTags"] != DBNull.Value)
                    _article.AllowLanguageSpecificTags = Convert.ToBoolean(reader["AllowLanguageSpecificTags"]);
                if (reader["RowGuid"] != DBNull.Value)
                    _article.RowGuid = new Guid(reader["RowGuid"].ToString());
                if (reader["ModifiedDate"] != DBNull.Value)
                    _article.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);
                if (reader["CommentsTypeId"] != DBNull.Value)
                    _article.CommentsTypeId = Convert.ToInt32(reader["CommentsTypeId"]);
                if (reader["EnableModeteration"] != DBNull.Value)
                    _article.EnableModeteration = Convert.ToBoolean(reader["EnableModeteration"]);
                if (reader["SiteId"] != DBNull.Value)
                    _article.SiteId = Convert.ToInt32(reader["SiteId"]);
                _article.NewRecord = false;
            } reader.Close();
            return _article;
        }

         public Article GetByID(int _articleId)
         {
             ArticleDAC _articleComponent = new ArticleDAC();
             IDataReader reader = _articleComponent.GetByIDArticle(_articleId);
             Article _article = null;
             while(reader.Read())
             {
                 _article = new Article();
                 if(reader["ArticleId"] != DBNull.Value)
                     _article.ArticleId = Convert.ToInt32(reader["ArticleId"]);
                 if(reader["SiteSectionId"] != DBNull.Value)
                     _article.SiteSectionId = Convert.ToInt32(reader["SiteSectionId"]);
                 if(reader["CreatorId"] != DBNull.Value)
                     _article.CreatorId = Convert.ToInt32(reader["CreatorId"]);
                 if(reader["ArticleStatusId"] != DBNull.Value)
                     _article.ArticleStatusId = Convert.ToInt32(reader["ArticleStatusId"]);
                 if(reader["AuthorId"] != DBNull.Value)
                     _article.AuthorId = Convert.ToInt32(reader["AuthorId"]);
                 if(reader["PostDate"] != DBNull.Value)
                     _article.PostDate = Convert.ToDateTime(reader["PostDate"]);
                 if(reader["AllowLanguageSpecificTags"] != DBNull.Value)
                     _article.AllowLanguageSpecificTags = Convert.ToBoolean(reader["AllowLanguageSpecificTags"]);
                 if(reader["RowGuid"] != DBNull.Value)
                     _article.RowGuid = new Guid(reader["RowGuid"].ToString());
                 if(reader["ModifiedDate"] != DBNull.Value)
                     _article.ModifiedDate = Convert.ToDateTime(reader["ModifiedDate"]);
                 if(reader["CommentsTypeId"] != DBNull.Value)
                     _article.CommentsTypeId = Convert.ToInt32(reader["CommentsTypeId"]);
                 if(reader["EnableModeteration"] != DBNull.Value)
                     _article.EnableModeteration = Convert.ToBoolean(reader["EnableModeteration"]);
                 if (reader["SiteId"] != DBNull.Value)
                     _article.SiteId = Convert.ToInt32(reader["SiteId"]);
             _article.NewRecord = false;             }             reader.Close();
             return _article;
         }

		public int UpdateDataset(System.Data.DataSet dataset)
		{
			ArticleDAC articlecomponent = new ArticleDAC();
			return articlecomponent.UpdateDataset(dataset);
		}



	}
}

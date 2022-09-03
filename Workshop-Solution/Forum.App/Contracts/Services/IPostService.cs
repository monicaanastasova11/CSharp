namespace Forum.App.Contracts
{
    using Forum.App.Contracts.ViewModels;
    using Forum.DataModels;
    using System;
    using System.Collections.Generic;

	using System.Linq;
	public interface IPostService
	{
		IEnumerable<ICategoryInfoViewModel> GetAllCategories();

		IEnumerable<IPostInfoViewModel> GetCategoryPostsInfo(int categoryId);

		string GetCategoryName(int categoryId);

		IPostViewModel GetPostViewModel(int postId);
		int AddPost(int userId, string postTitle, string postCategory, string postContent);
		void AddReplyToPost(int postId, string replyContents, int userId);

		

		


	}
}


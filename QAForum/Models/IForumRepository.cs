using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QAForum.Models
{
    public interface IForumRepository
    {
        IEnumerable<Forum> GetAllForums();

        Forum GetForumByID(int ForumID);

        IEnumerable<Thread> GetAllThreads();
        IEnumerable<Post> GetAllPosts();

        IEnumerable<Thread> GetThreadsByForum(int ForumID);
        Thread GetThreadByID(int ThreadID);

        IEnumerable<Post> GetPostsByThread(int ThreadID);
        Post GetPostByID(int PostID);

        User GetUserByID(Guid UserID);

        void AddForum(Forum forum);
        void UpdateForum(Forum forum);
        void DeleteForum(Forum forum);

        void AddThread(Thread thread);
        void UpdateThread(Thread thread);
        void DeleteThread(Thread thread);

        void AddPost(Post post);
        void UpdatePost(Post post);
        void DeletePost(Post post);

    }
}

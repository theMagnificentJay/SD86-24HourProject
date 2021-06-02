﻿using Project.Data;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourHourAssignment.Models;

namespace Project.Services
{
    public class PostService
    {
        private readonly Guid _userId;

        public PostService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePost(PostCreate model)
        {
            var entity =
                new Post()
                {
                    AuthorId = _userId,
                    Title = model.Title,
                    Text = model.Text,
                    Created = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PostListItem> GetPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Posts
                        .Where(e => e.AuthorId == _userId)
                        .Select(
                            e =>
                                new PostListItem
                                {
                                    PostId = e.PostId,
                                    Title = e.Title,
                                    Created = e.Created
                                }
                                );

                return query.ToArray();
            }
        }

        public PostDetail GetPostById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Posts
                    .Single(e => e.PostId == id && e.AuthorId == _userId);
                return
                    new PostDetail
                    {
                        PostId = entity.PostId,
                        Title = entity.Title,
                        Text = entity.Text,
                        CreatedUtc = entity.Created,
                        ModifiedUtc = entity.Modified
                    };
            }
        }

        public bool UpdatePost(PostEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Posts
                    .Single(e => e.PostId == model.PostId && e.AuthorId == _userId);

                entity.Title = model.Title;
                entity.Text = model.Text;
                entity.Modified = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePost(int noteId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .Posts
                    .Single(e => e.PostId == noteId && e.AuthorId == _userId);

                ctx.Posts.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}

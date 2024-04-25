using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using BlazorApp1.CarModels;
using BlazorApp1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace BlazorApp1.Repositories
{
    public class PostRepository
    {
        private readonly ApplicationDbContext _context;

        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Retrieve a post by its ID, including associated tags
        public Post GetPost(int postId)
        {
            return _context.Posts.Include(p => p.Tags).FirstOrDefault(p => p.Id == postId);
        }

        // Add a new post
        public void AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        // Delete a post
        public void DeletePost(int postId)
        {
            var post = GetPost(postId);
            if (post != null)
            {
                _context.Posts.Remove(post);
                _context.SaveChanges();
            }
        }

        // Retrieve a tag by its ID, including associated posts
        public Tag GetTag(int tagId)
        {
            return _context.Tags.Include(t => t.Posts).FirstOrDefault(t => t.Id == tagId);
        }

        // Add a new tag
        public void AddTag(Tag tag)
        {
            _context.Tags.Add(tag);
            _context.SaveChanges();
        }

        // Attach a tag to a post
        public void AttachTagToPost(int postId, int tagId)
        {
            var post = GetPost(postId);
            var tag = GetTag(tagId);
            if (post != null && tag != null)
            {
                post.Tags.Add(tag);
                _context.SaveChanges();
            }
        }

        // Remove a tag from a post
        public void DetachTagFromPost(int postId, int tagId)
        {
            var post = GetPost(postId);
            var tag = GetTag(tagId);
            if (post != null && tag != null)
            {
                post.Tags.Remove(tag);
                _context.SaveChanges();
            }
        }
    }
}

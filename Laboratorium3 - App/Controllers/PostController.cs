using Laboratorium3___App.Models;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorium3App.Controllers
{
    public class PostController : Controller
    {
        private static List<Post> _posts = new List<Post>();

        public IActionResult Index()
        {
            return View(_posts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid)
            {
                post.Id = _posts.Any() ? _posts.Max(p => p.Id) + 1 : 1;
                _posts.Add(post);
                return RedirectToAction("Index");
            }
            return View(post);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        [HttpPost]
        public IActionResult Edit(int id, Post post)
        {
            if (id != post.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingPost = _posts.FirstOrDefault(p => p.Id == id);
                if (existingPost == null)
                {
                    return NotFound();
                }
                _posts.Remove(existingPost);
                _posts.Add(post);

                return RedirectToAction("Index");
            }
            return View(post);
        }

        public IActionResult Delete(int id)
        {
            var post = _posts.FirstOrDefault(p => p.Id == id);
            if (post == null)
            {
                return NotFound();
            }

            _posts.Remove(post);
            return RedirectToAction("Index");
        }
    }
}
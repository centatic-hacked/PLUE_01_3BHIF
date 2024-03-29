﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.PluePos._01.Model
{
    public class TextPost : Post
    {
        public string? Content { get; set; }

		private int length;

		public int Length
		{
			get { return Content?.Length ?? 0; }
		}

        public override string HTML
		{
			get { return  Content == null ? throw new ArgumentNullException("Content war NULL!") : $"<h1>{Content}</h1><p>{Length}</p>"; }
		}

        public TextPost(string title) : base(title)
		{

		}

		public TextPost(string title, DateTime created) : base(title, created) { }



	}
}

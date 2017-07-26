﻿using Microsoft.AspNetCore.Http;

namespace Bundler
{
    /// <summary>
    /// A configuration object for Bundler.
    /// </summary>
    public class BundlerProcess
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BundlerProcess"/> class.
        /// </summary>
        public BundlerProcess(HttpContext httpContext, IBundle bundle)
        {
            HttpContext = httpContext;
            Bundle = bundle;
        }

        /// <summary>
        /// Gets or sets the content of the response.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets the HTTP context.
        /// </summary>
        public HttpContext HttpContext { get; }

        /// <summary>
        /// Gets the transform.
        /// </summary>
        public IBundle Bundle { get; }
    }
}
/*
        MIT License
       
       Copyright (c) 2024 Alastair Lundy
       
       Permission is hereby granted, free of charge, to any person obtaining a copy
       of this software and associated documentation files (the "Software"), to deal
       in the Software without restriction, including without limitation the rights
       to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
       copies of the Software, and to permit persons to whom the Software is
       furnished to do so, subject to the following conditions:
       
       The above copyright notice and this permission notice shall be included in all
       copies or substantial portions of the Software.
       
       THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
       IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
       FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
       AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
       LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
       OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
       SOFTWARE.
   */

using System;
// ReSharper disable RedundantIfElseBlock

namespace AlastairLundy.Extensions.System.Urls
{
    /// <summary>
    /// 
    /// </summary>
    public class UrlBuilder
    {
        private Url _url;

        /// <summary>
        /// 
        /// </summary>
        public UrlBuilder()
        {
            _url = new Url(string.Empty);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static UrlBuilder Create()
        {
            return new UrlBuilder();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="portNumber"></param>
        public UrlBuilder(string baseUrl, int? portNumber = null)
        {
            if (portNumber != null)
            {
                _url = new Url(baseUrl, string.Empty, string.Empty, portNumber);
            }
            else
            {
                _url =  new Url(baseUrl);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        private UrlBuilder(Url url)
        {
            _url = url;
        }
        
        /// <summary>
        ///
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="urlPrefix"></param>
        /// <param name="portNumber"></param>
        private UrlBuilder(string baseUrl, string urlPrefix = null, string urlScheme = null, int? portNumber = null)
        {
            if (string.IsNullOrEmpty(urlPrefix) == false)
            {
                if (portNumber != null)
                {
                    _url = new Url(baseUrl, urlPrefix, urlScheme, portNumber);
                }
                else
                {
                    _url = new Url(baseUrl, urlPrefix, urlScheme, null);
                }
            }
            else
            {
                _url = new Url(baseUrl);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        public UrlBuilder AppendSegment(string segment)
        {
            return new UrlBuilder(string.Concat(_url.BaseUrl, segment), _url.Prefix, _url.Scheme, _url.PortNumber);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UrlBuilder AddForwardSlash()
        {
            return AppendSegment("/");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public UrlBuilder WithPrefix(string prefix)
        {
            return new UrlBuilder(_url.BaseUrl, prefix, _url.Scheme, _url.PortNumber);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="addWww"></param>
        /// <returns></returns>
        public UrlBuilder WithHttpsScheme(bool addWww)
        {
            if (addWww)
            {
                return new UrlBuilder(_url.BaseUrl, _url.Prefix, "https://www.", _url.PortNumber);
            }
            else
            {
                return new UrlBuilder(_url.BaseUrl, _url.Prefix, "https://", _url.PortNumber);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public UrlBuilder WithFileScheme()
        {
            return new UrlBuilder(_url.BaseUrl, _url.Prefix, "file://", _url.PortNumber);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Url Build()
        {
            return _url;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public new string ToString()
        {
            return _url.ToString();
        }
    }
}
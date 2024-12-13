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
    public class Url : IEquatable<Url>
    {
        public string UrlPrefix { get; protected set; }
        public string BaseUrl { get; protected set; }
        public int? PortNumber { get; protected set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseUrl"></param>
        public Url(string baseUrl)
        {
            BaseUrl = baseUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="urlPrefix"></param>
        /// <param name="portNumber"></param>
        public Url(string baseUrl, string urlPrefix, int? portNumber)
        {
            BaseUrl = baseUrl;
            UrlPrefix = urlPrefix;
            PortNumber = portNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseUrl"></param>
        public Url(Uri baseUrl)
        {
            BaseUrl = baseUrl.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (PortNumber != null)
            {
                return $"{UrlPrefix}.{BaseUrl}:{PortNumber}";
            }
            else
            {
                return $"{UrlPrefix}.{BaseUrl}";
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Url other)
        {
            if (other is null)
            {
                return false;
            }
            
            return UrlPrefix == other.UrlPrefix && BaseUrl == other.BaseUrl && PortNumber == other.PortNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }
            if (obj.GetType() != GetType())
            {
                return false;
            }
            
            return Equals((Url)obj);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (UrlPrefix != null ? UrlPrefix.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (BaseUrl != null ? BaseUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ PortNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
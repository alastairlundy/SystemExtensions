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
        public string Scheme { get; protected set; }
        public string Prefix { get; protected set; }
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
        public Url(string baseUrl, string urlPrefix, string urlScheme, int? portNumber)
        {
            BaseUrl = baseUrl;
            Prefix = urlPrefix;
            Scheme = urlScheme;
            PortNumber = portNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseUrl">A Uri to conver to a Url.</param>
        public Url(Uri baseUrl)
        {
           var url = FromUri(baseUrl);
           this.Scheme = url.Scheme;
           this.Prefix = url.Prefix;
           this.BaseUrl = url.BaseUrl;
           this.PortNumber = url.PortNumber;
        }
        
        /// <summary>
        /// Converts a Uri to a Url.
        /// </summary>
        /// <param name="uri">The Uri object to be converted.</param>
        /// <returns>The newly created Url object.</returns>
        public static Url FromUri(Uri uri)
        {
           return new Url(uri.ToString(), string.Empty, uri.Scheme, uri.Port);
        }

        /// <summary>
        /// Returns a string representation of this Url object.
        /// </summary>
        /// <returns>a string representation of this Url object.</returns>
        public override string ToString()
        {
            if (PortNumber != null)
            {
                if (Prefix.Equals("https://") || Prefix.Equals("http://") || Prefix.Equals("file://") || string.IsNullOrEmpty(Prefix))
                {
                    return $"{Scheme}{Prefix}{BaseUrl}:{PortNumber}";
                }
                else
                {
                    return $"{Scheme}{Prefix}.{BaseUrl}:{PortNumber}";
                }
            }
            else
            {
                if (Prefix.Equals("https://") || Prefix.Equals("http://") || Prefix.Equals("file://") || string.IsNullOrEmpty(Prefix))
                {
                    return $"{Scheme}{Prefix}{BaseUrl}";
                }
                else
                {
                    return $"{Scheme}{Prefix}.{BaseUrl}";
                }
            }
        }
        
        /// <summary>
        /// Returns whether a Url is equal to this Url.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>True if the Url is Equal to this Url; returns false otherwise.</returns>
        public bool Equals(Url other)
        {
            if (other is null)
            {
                return false;
            }
            
            return Scheme == other.Scheme && Prefix == other.Prefix && BaseUrl == other.BaseUrl && PortNumber == other.PortNumber;
        }

        /// <summary>
        /// Returns whether an object is equal to this Url.
        /// </summary>
        /// <param name="obj">The object to be compared.</param>
        /// <returns>True if the object is a Url and is Equal to this Url; returns false otherwise.</returns>
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
        /// Returns the hashcode for this Url.
        /// </summary>
        /// <returns>A 32-bit signed integer hashcode.</returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Windows Azure Document Database.
    /// </summary>
    public partial class DocumentDbLinkedService : LinkedServiceProperties
    {
        private string _connectionString;
        
        /// <summary>
        /// Required. Gets or sets the connection string.
        /// </summary>
        public string ConnectionString
        {
            get { return this._connectionString; }
            set { this._connectionString = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DocumentDbLinkedService class.
        /// </summary>
        public DocumentDbLinkedService()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the DocumentDbLinkedService class
        /// with required arguments.
        /// </summary>
        public DocumentDbLinkedService(string connectionString)
            : this()
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException("connectionString");
            }
            this.ConnectionString = connectionString;
        }
    }
}
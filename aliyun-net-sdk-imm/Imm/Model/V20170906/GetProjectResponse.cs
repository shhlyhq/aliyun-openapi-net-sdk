/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class GetProjectResponse : AcsResponse
	{

		private string requestId;

		private string project;

		private string serviceRole;

		private string endpoint;

		private string createTime;

		private string modifyTime;

		private string type;

		private int? cU;

		private List<GetProject_IndexersItem> indexers;

		private List<GetProject_EnginesItem> engines;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
			}
		}

		public string ServiceRole
		{
			get
			{
				return serviceRole;
			}
			set	
			{
				serviceRole = value;
			}
		}

		public string Endpoint
		{
			get
			{
				return endpoint;
			}
			set	
			{
				endpoint = value;
			}
		}

		public string CreateTime
		{
			get
			{
				return createTime;
			}
			set	
			{
				createTime = value;
			}
		}

		public string ModifyTime
		{
			get
			{
				return modifyTime;
			}
			set	
			{
				modifyTime = value;
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public int? CU
		{
			get
			{
				return cU;
			}
			set	
			{
				cU = value;
			}
		}

		public List<GetProject_IndexersItem> Indexers
		{
			get
			{
				return indexers;
			}
			set	
			{
				indexers = value;
			}
		}

		public List<GetProject_EnginesItem> Engines
		{
			get
			{
				return engines;
			}
			set	
			{
				engines = value;
			}
		}

		public class GetProject_IndexersItem
		{

			private string name;

			private string status;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}
		}

		public class GetProject_EnginesItem
		{

			private string name;

			private long? jobTtl;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public long? JobTtl
			{
				get
				{
					return jobTtl;
				}
				set	
				{
					jobTtl = value;
				}
			}
		}
	}
}
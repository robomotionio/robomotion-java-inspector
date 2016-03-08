﻿// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.Text;

namespace CodeGen.Definitions {
  public class FunctionDefinition {
    private List<ParameterDefinition> _parameters = new List<ParameterDefinition>();

    public TypeReference ReturnType { get; set; }
    public string Name { get; set; }

    public List<ParameterDefinition> Parameters {
      get { return _parameters; }
      set { _parameters = value; }
    }

    public override string ToString() {
      var sb = new StringBuilder();
      sb.Append(ReturnType);
      sb.Append(" ");
      sb.Append(Name ?? "");
      sb.Append("(");
      bool first = true;
      foreach (var p in Parameters) {
        if (first)
          first = false;
        else {
          sb.Append(", ");
        }
        sb.Append(p);
      }
      sb.Append(")");
      return sb.ToString();
    }
  }
}
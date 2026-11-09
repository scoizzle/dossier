# django/template/library

- Subject: django/template/library (id `c57a249a-38f1-40b2-8e22-15ef4b754ee3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 14 of 55
- Conflicts: 0
- Gaps: 0

## Facts

- args, kwargs = parse_bits( parser, bits, params, varargs, varkw, defaults, kwonly, kwonly_defaults, function_name, ) [d7b0aa27]
- if params and params[0] == "context": del params[0] else: raise TemplateSyntaxError( f"{function_name!r} is decorated with takes_context=True so it " "must have a first argument of 'context'" ) elif params and params[0] == "content": del params[0] else: raise TemplateSyntaxError( f"{function_name!r} must have a first argument of 'content'" ) [38817b5d]
- nodelist = parser.parse((end_name,)) parser.delete_first_token() [c976db8e]
- return SimpleBlockNode( nodelist, func, takes_context, args, kwargs, target_var ) [aa501801]
- return dec elif name is not None and compile_function is not None: # register.tag('somename', somefunc) self.tags[name] = compile_function return compile_function else: raise ValueError( "Unsupported arguments to Library.tag: (%r, %r)" % (name, compile_function), ) [9cd55d6c]
- return dec elif name is not None and filter_func is not None: # register.filter('somename', somefunc) self.filters[name] = filter_func for attr in ("expects_localtime", "is_safe", "needs_autoescape"): if attr in flags: value = flags[attr] # set the flag on the filter for FilterExpression.resolve setattr(filter_func, attr, value) # set the flag on the innermost decorated function # for decorators that need it, e.g. stringfilter setattr(unwrap(filter_func), attr, value) filter_func._filter_name = name return filter_func else: raise ValueError( "Unsupported arguments to Library.filter: (%r, %r)" % (name, filter_func), ) [cd6fb7c0]
- @wraps(func) def compile_func(parser, token): bits = token.split_contents()[1:] args, kwargs = parse_bits( parser, bits, params, varargs, varkw, defaults, kwonly, kwonly_defaults, function_name, ) return InclusionNode( func, takes_context, args, kwargs, filename, ) [a902c2ba]
- @wraps(func) def compile_func(parser, token): bits = token.split_contents()[1:] target_var = None if len(bits) >= 2 and bits[-2] == "as": target_var = bits[-1] bits = bits[:-2] [bce30df6]
- @wraps(func) def compile_func(parser, token): bits = token.split_contents()[1:] target_var = None if len(bits) >= 2 and bits[-2] == "as": target_var = bits[-1] bits = bits[:-2] args, kwargs = parse_bits( parser, bits, params, varargs, varkw, defaults, kwonly, kwonly_defaults, function_name, ) return SimpleNode(func, takes_context, args, kwargs, target_var) [a6990e9f]
- if end_name is None: end_name = f"end{function_name}" [eb1b845a]
- if takes_context: if len(params) >= 2 and params[1] == "content": del params[1] else: raise TemplateSyntaxError( f"{function_name!r} is decorated with takes_context=True so" " it must have a first argument of 'context' and a second " "argument of 'content'" ) [190cbfa6]
- return dec elif name is not None and filter_func is None: if callable(name): # @register.filter return self.filter_function(name, **flags) else: # @register.filter('somename') or # @register.filter(name='somename') def dec(func): return self.filter(name, func, **flags) [bfdf6cbe]
- self.tag(function_name, compile_func) return func [8487bbc1b6694eca]
- @register.simple_block_tag def hello(content): return 'world' """ [d3d1cf22]

## Beyond the budget

33 more facts did not fit in the budget: [7270c4b6] [476d65b2] [f0e0c4c2] [5c0f561c] [121c65e7b30c954c] [9a127496] [2cb6c2e3] [53f8c089] [b1f83fc3] [1f455822] [1ff9cd28] [1c2242dc] [307559a1] [b82fc222] [6ce01186] [397f367a] [1c6c3bf3] [08e81af7] [b8f297f1] [6c4b2b5a] [6dc1afaa] [bb45a19e] [ef4d80ab] [384aec4c] [18a803a2] [e1654055] [659b6321] [c2931029] [eacc7b98] [52683af4] [30a331d9] [08ab6490] [26224b3b]

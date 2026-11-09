# django/template/loader_tags

- Subject: django/template/loader_tags (id `170f9b99-4925-4613-a1a6-ac92f19ba9d3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 9 of 42
- Conflicts: 0
- Gaps: 0

## Facts

- # Add the block nodes from this node to the block context block_context.add_blocks(self.blocks) [1a7ef42e]
- # Call Template._render explicitly so the parser context stays # the same. with context.render_context.push_state(compiled_parent, isolated_context=False): return compiled_parent._render(context) [95e695f0]
- # If this block's parent doesn't have an extends node it is the root, # and its block nodes also need to be added to the block context. for node in compiled_parent.nodelist: # The ExtendsNode has to be the first non-text node. if not isinstance(node, TextNode): if not isinstance(node, ExtendsNode): blocks = { n.name: n for n in compiled_parent.nodelist.get_nodes_by_type(BlockNode) } block_context.add_blocks(blocks) break [821a43aa]
- if BLOCK_CONTEXT_KEY not in context.render_context: context.render_context[BLOCK_CONTEXT_KEY] = BlockContext() block_context = context.render_context[BLOCK_CONTEXT_KEY] [0db52768]
- {% include "foo/some_include" %} {% include "foo/some_include" with bar="BAZZ!" baz="BING!" %} [daf9f69c]
- {% include "foo/some_include" only %} {% include "foo/some_include" with bar="1" only %} """ bits = token.split_contents() if len(bits) < 2: raise TemplateSyntaxError( "%r tag takes at least one argument: the name of the template to " "be included." % bits[0] ) options = {} remaining_bits = bits[2:] while remaining_bits: option = remaining_bits.pop(0) if option in options: raise TemplateSyntaxError( "The %r option was specified more than once." % option ) if option == "with": value = token_kwargs(remaining_bits, parser, support_legacy=False) if not value: raise TemplateSyntaxError( '"with" in %r tag needs at least one keyword argument.' % bits[0] ) elif option == "only": value = True else: raise TemplateSyntaxError( "Unknown argument for %r tag: %r." % (bits[0], option) ) options[option] = value isolated_context = options.get("only", False) namemap = options.get("with", {}) bits[1] = construct_relative_path( parser.origin.template_name, bits[1], allow_recursion=True, ) return IncludeNode( parser.compile_filter(bits[1]), extra_context=namemap, isolated_context=isolated_context, ) [3479daec]
- # This check is kept for backwards-compatibility. See #3100. endblock = parser.next_token() acceptable_endblocks = ("endblock", "endblock %s" % block_name) if endblock.contents not in acceptable_endblocks: parser.invalid_block_tag(endblock, "endblock", acceptable_endblocks) [d2b935c6]
- Example:: [24ca13eabf54f502-2]
- This tag may be used in two ways: ``{% extends "base" %}`` (with quotes) uses the literal value "base" as the name of the parent template to extend, or ``{% extends variable %}`` uses the value of ``variable`` as either the name of the parent template to extend (if it evaluates to a string) or as the parent template itself (if it evaluates to a Template object). """ bits = token.split_contents() if len(bits) != 2: raise TemplateSyntaxError("'%s' takes one argument" % bits[0]) bits[1] = construct_relative_path(parser.origin.template_name, bits[1]) parent_name = parser.compile_filter(bits[1]) nodelist = parser.parse() if nodelist.get_nodes_by_type(ExtendsNode): raise TemplateSyntaxError( "'%s' cannot appear more than once in the same template" % bits[0] ) return ExtendsNode(nodelist, parent_name) [75a52ca3]

## Beyond the budget

33 more facts did not fit in the budget: [bdadc029] [d71c94b6] [387cf94d] [810c2721] [593caf46] [9eab0bca] [87690928] [0be172f4] [11f28b20] [42ffed1e] [b7333d3c] [e8d06729] [9c8c7b93] [36746ea5] [e3b75cc7] [32d2a43e] [49bd5ea7] [32174a39] [1e96ed42] [28c3a42e] [a66504a2] [c4e4a92a] [6f8fb31d] [bd253190] [71960027] [c1516950] [0824570e] [5d9088a2] [6bfa8c17] [b65baa36] [13a08622] [491da038] [c8c0ccd629deb6b1-5]

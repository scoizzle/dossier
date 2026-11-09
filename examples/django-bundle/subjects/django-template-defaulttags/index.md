# django/template/defaulttags

- Subject: django/template/defaulttags (id `a77b3d7e-f394-4632-8c1e-71604211208b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 899 tokens
- Facts shown: 18 of 268
- Conflicts: 0
- Gaps: 0

## Facts

- for node in self.nodelist_loop: nodelist.append(node.render_annotated(context)) [4ef9b8f2]
- if pop_context: # Pop the loop variables pushed on to the context to avoid # the context ending up in an inconsistent state when other # tags (e.g., include and with) push data to context. context.pop() return mark_safe("".join(nodelist)) [b2b0d1b2]
- pop_context = False if unpack: # If there are multiple loop variables, unpack the item # into them. try: len_item = len(item) except TypeError: # not an iterable len_item = 1 # Check loop variable count before unpacking if num_loopvars != len_item: raise ValueError( "Need {} values to unpack in for loop; got {}. ".format( num_loopvars, len_item ), ) unpacked_vars = dict(zip(self.loopvars, item)) pop_context = True context.update(unpacked_vars) else: context[self.loopvars[0]] = item [8c69da9b]
- <h1>Archive for {{ year }}</h1> [e21d63b7]
- <tr class="{% cycle 'row1' 'row2' 'row3' as rowcolors %}">...</tr> <tr class="{% cycle rowcolors %}">...</tr> <tr class="{% cycle rowcolors %}">...</tr> [6b898ac2]
- if match: return nodelist.render(context) [dd6ecbff]
- {% for date in days %} {% ifchanged %}<h3>{{ date|date:"F" }}</h3>{% endifchanged %} <a href="{{ date|date:"M/d"|lower }}/">{{ date|date:"j" }}</a> {% endfor %} [0d24fa49]
- {% for date in days %} {% ifchanged date.date %} {{ date.date }} {% endifchanged %} {% ifchanged date.hour date.date %} {{ date.hour }} {% endifchanged %} {% endfor %} """ bits = token.split_contents() nodelist_true = parser.parse(("else", "endifchanged")) token = parser.next_token() if token.contents == "else": nodelist_false = parser.parse(("endifchanged",)) parser.delete_first_token() else: nodelist_false = NodeList() values = [parser.compile_filter(bit) for bit in bits[1:]] return IfChangedNode(nodelist_true, nodelist_false, *values) [d7362282]
- * Guitar: * Django Reinhardt * Emily Remler * Piano: * Lovie Austin * Bud Powell * Trumpet: * Duke Ellington [b830fc01]
- <img src="bar.png" alt="Bar" height="10" width="{% widthratio this_value max_value max_width %}"> [6fed91ed]
- <p><a href="foo/">Foo</a></p> [c4443a34]
- <pre> {% debug %} </pre> """ return DebugNode() [d164a454]
- <ul> {% for athlete in athlete_list %} <li>{{ athlete.name }}</li> {% empty %} <li>Sorry, no athletes in this list.</li> {% endfor %} <ul> [f8af58da]
- <ul> {% if athlete_list %} {% for athlete in athlete_list %} <li>{{ athlete.name }}</li> {% endfor %} {% else %} <li>Sorry, no athletes in this list.</li> {% endif %} </ul> [a79d3f62]
- <ul> {% for athlete in athlete_list %} <li>{{ athlete.name }}</li> {% endfor %} </ul> [5355b1ea]
- It is {% now "jS F Y H:i" %} """ bits = token.split_contents() asvar = None if len(bits) == 4 and bits[-2] == "as": asvar = bits[-1] bits = bits[:-2] if len(bits) != 2: raise TemplateSyntaxError("'now' statement takes one argument") format_string = bits[1][1:-1] return NowNode(format_string, asvar) [69a798ad]
- from pprint import pformat [2796931e]
- if self.asvar: context[self.asvar] = formatted return "" else: return formatted [a3f323cb]

## Beyond the budget

248 more facts did not fit in the budget: [8fbe5d54] [b8f7e2b8] [b0613b73] [58c5ecf0] [fe352fc2] [f4ff3143] [e753dec7] [94d1380d] [96674364] [ea1073f0] [f9a05d340c6ebe2f-2] [2862218c] [51044e08] [6d462532] [ad04b691] [fbf26d37] [88cd131d] [dd17604e] [b022c1c4] [dcef474d] [db436933] [4890e523] [2a7cb85c] [f6734e20] [84853bd6] [15b38412] [9c0ca6f2] [c2be74a4] [71d89fef] [dfdf4bc1] [041da12e] [d4e3bec3] [5d7859dd] [69eb67ec] [6a660d36] [db5c273c] [680d3dfa] [2ef33a64] [d32a8eb9] [b8171730] [6076b178] [d429529b] [7d821d1f] [21737c74] [0409ef60] [1c31b08e] [cf46174b] [76878e28] [4773425e] [68996156] [5bbdaba5] [14b410d2] [64117bfa] [dacfa1a9] [30dfb876] [e45f4721] [4a4eb754] [04a22028] [1cccbeba] [9c41946d] [e25b49ca] [5bebd606] [2423f23a] [ab21fbca] [3191493c] [87242468] [0d2e22957311b784-2] [9c8b5517] [abe39617] [bbcd4adb] [7f7a1cd6] [65700cd8] [37a5e6123c19a755] [37a5e6123c19a755-2] [37a5e6123c19a755-3] [e656fb64] [5ff50521] [5e8b96a2] [bb814515] [cdfbd152] [c97ddf52] [51ff697b] [63c93c2b] [4136194a] [03abc4a3] [6ebab8dc] [a3a5d147] [bd72df74] [02cd8d2f] [4d6874ca] [b9d3da9d] [2a5c6dd4ec548fdd] [2a5c6dd4ec548fdd-2] [2a5c6dd4ec548fdd-3] [2a5c6dd4ec548fdd-4] [ea6d5adc] [8bdc3069] [16c3fdd9] [9a9e20b2] [24104fd9] [07b950b6] [9e98ff6e] [efbbc1fe] [0ad9903f] [f7be80c5] [f5922563] [f1ae5ef5] [8d0dce1b] [5df9dbcf] [5b8566b4] [860c871e] [ea3d628d] [e2577c0d] [00c579ce] [60225e38] [1dd9b1b8] [a898892ae0cdf6fe-4] [a898892ae0cdf6fe-5] [a898892ae0cdf6fe-6] [63d8bc5b] [ce0d23e8] [a6685b8f] [388efd38] [7588b835] [9bcf88b3] [fd44502d] [57798b18] [ff8697fa] [aebdf064] [72a88bb3] [aeef517a] [13e090a6] [ba296684] [6badfed1] [5dfb350a] [25b0c124] [6563248b] [b6c22bab] [9f3ca1db] [2af17a39] [631d713a] [15ebdb30] [791ef1e88e5bd5fd] [0ddf6867] [d416c213] [be9a6b07] [d7cee652] [340aa269] [98aaedf9] [c2c3cad3] [6ec413ef] [12c0a15e] [22dde2ca] [75516758] [f0f48ed4] [090dff8c] [872a379c] [7d737b03] [a09921ac] [d0b1d128986f1f84] [90b5ff5d] [826d2405] [4f4760ea] [4f86beff] [e8159143] [da7f7b12] [c1a25e8f] [58769ab1] [f40eba08] [51649987] [90221cd6] [618f1db0] [d6d731be] [25d407fc] [27576ed5] [ca61e0cc] [642ddb97] [0e385488] [2eb11217] [34f421c9] [e11eb375] [4a37b0fd] [1e963740] [6213eeb3] [7c2567c4] [202632b9] [7a451d91] [861440f3] [8a3ad729] [fac6d1d5] [9bcf983f] [9e354710] [0f1f2cde] [0e51eec4] [4fdf8a63] [ceba0125] [163ad2d8] [a1cf6a91] [74a7aba5] [69d467ca] [9acc6b72] [91df3362] [3c6b5c66] [36f35e9d] [7c0581d4] [6c5a603d] [3816733e] [c742cc0a] [48b33ee7] [1d6f04ae] [14804d37] [46bed9b0] [3e7a8639] [ea3a01ed] [76086c10] [554899c6] [4ed8de0d] [9bcdca3e] [9a90f564] [c6b8eb57] [b87f69a5] [b97227d8] [5472a644] [d4c35ba7] [8d048721] [1a279bf2] [4f48ede8] [c6a38900] [f782ecba] [6f86bdac] [dc72d4d5] [242543e6] [c5ec6d3a] [46addd27] [275e4748] [831bdb63] [4c452b88] [4e95790d] [5ba2db8e] [17a57dcf] [666cb997] [f3e97e95] [027c1ae4] [c53cfcd0] [b73b4c6e] [b6903135] [e587345d] [c8c0ccd629deb6b1-4]

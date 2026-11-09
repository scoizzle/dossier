# docs/ref/forms/widgets

- Subject: docs/ref/forms/widgets (id `b46d49a4-1388-428d-af04-0108a35510dc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 22 of 292
- Conflicts: 0
- Gaps: 0

## Facts

- def decompress(self, value): if value: return [value.date(), value.time()] return [None, None] [937c42c4]
- # A custom empty label with string field1 = forms.DateField(widget=SelectDateWidget(empty_label="Nothing")) [3881b8dd]
- # A custom empty label with tuple field1 = forms.DateField( widget=SelectDateWidget( empty_label=("Choose Year", "Choose Month", "Choose Day"), ), ) [33b003f7]
- >>> from django import forms >>> name = forms.TextInput(attrs={"size": 10, "title": "Your name"}) >>> name.render("name", "A name") '<input title="Your name" type="text" name="name" value="A name" size="10">' [3e5f59bf]
- >>> from django.forms import MultiWidget, TextInput >>> widget = MultiWidget(widgets=[TextInput, TextInput]) >>> widget.render("name", ["john", "paul"]) '<input type="text" name="name_0" value="john"><input type="text" name="name_1" value="paul">' [7f43e342]
- >>> name = forms.TextInput(attrs={"required": True}) >>> name.render("name", "A name") '<input name="name" type="text" value="A name" required>' >>> >>> name = forms.TextInput(attrs={"required": False}) >>> name.render("name", "A name") '<input name="name" type="text" value="A name">' [853597e2]
- >>> widget = MultiWidget(widgets={"": TextInput, "last": TextInput}) >>> widget.render("name", ["john", "paul"]) '<input type="text" name="name" value="john"><input type="text" name="name_last" value="paul">' [c501d5d7]
- DateInput(attrs={"type": "date"}, format="%Y-%m-%d") [c63d3236]
- MONTHS = { 1: _("jan"), 2: _("feb"), 3: _("mar"), 4: _("apr"), 5: _("may"), 6: _("jun"), 7: _("jul"), 8: _("aug"), 9: _("sep"), 10: _("oct"), 11: _("nov"), 12: _("dec"), } [f2d43d44]
- Note that :class:`~django.forms.MultiValueField` has a complementary method :meth:`~django.forms.MultiValueField.compress` with the opposite responsibility - to combine cleaned values of all member fields into one. [f392147c]
- class MyDateInput(forms.DateInput): input_type = "date" format = "%Y-%m-%d" [7133d55e]
- class SplitDateTimeWidget(MultiWidget): # ... [078c468e]
- def decompress(self, value): if isinstance(value, date): return [value.day, value.month, value.year] elif isinstance(value, str): year, month, day = value.split("-") return [day, month, year] return [None, None, None] [67e78c0f]
- def value_from_datadict(self, data, files, name): day, month, year = super().value_from_datadict(data, files, name) # DateField expects a single string that it can parse into a date. return "{}-{}-{}".format(year, month, day) [5a3e60fe]
- from django.forms import MultiWidget [be13d184]
- {% for subwidget in widget.subwidgets %} {% include subwidget.template_name with widget=subwidget %} {% endfor %} [749028c0]
- .. _HTML5 "date" input type: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date [68659d7f]
- .. code-block:: html+django [685d15dfb6eb2285-77]
- .. code-block:: pycon [eaf050be34acb41d-345]
- .. code-block:: pycon [eaf050be34acb41d-346]
- .. code-block:: pycon [eaf050be34acb41d-347]
- .. tip:: [54e0fd4400a566cb-2]

## Beyond the budget

253 more facts did not fit in the budget: [6cdb6d14] [eaf050be34acb41d-348] [dfa717732ab88b73-3] [691620be] [c4d0c434] [fcc4aa1d] [b2846fc6] [5a1dffb9] [ef5224fe] [73817e2f] [ba168db3] [42f761d2] [32630194] [ceafe727] [87522211] [e4c74728] [20469648] [cf9ae226] [80e6b8dd] [8ee2b7ef] [ee008353] [1d7a74e4] [424b8114] [4339ee68] [2988490c] [f76162a2] [98440d02] [be6377db] [4f3acb77] [aac09b0e] [e03fcc7e] [3defa15d] [597d1ec4] [c8c09793] [a4810416] [5a8a1781296c882d] [db1b43e1] [787fd128] [3675e607] [86da9c88] [e049f406] [aedeb6f7] [2a2e1c1b] [1dfcb001] [51a459e5] [258ee9fc] [70da77f7] [96c560d6] [afe97e69] [c52dceff] [91f7f509] [f5dcc619] [24863b6f] [11c1936c] [04c34e24] [b8d1e877] [3311b506] [1e11ae9b] [1fcb3a02] [cbdfb32a] [38846fa0] [b649e6fd] [8c743d0a] [d9b68849] [e214a37e] [af021d81] [e2423552] [a6f0fbd3] [5f59d3f4] [c3cef5e1] [37e07860] [4b08cc1b] [2e112dad] [3feec4b5] [102197aa] [3380ed2c] [47a8728c] [34b29db5] [879b8853] [dfffa420] [3f216ee8] [32f026cb] [78844cfa] [1f8eaf28] [3f1366d7] [d014ea7a] [da597417] [57394e60] [127ca227] [f1634b861a77cfdb-13] [f1634b861a77cfdb-14] [f1634b861a77cfdb-15] [f1634b861a77cfdb-16] [4e885956f001b283-2] [488475b4] [ff0b91a107b83b10] [760158af] [bce63f83] [431edfb9] [08a19636] [266d4df9] [2b1c11b0] [60a32ea4] [8011115b] [357225a9] [d4e8c764] [a8e7afad] [f60ec754] [2578fb65] [17abe905] [30b74aed] [291a9dc9] [fb69bc66] [7693cb5a] [cd54e6cd] [bd95c47e] [4f9dba66] [ee95298a] [aafacad1] [b5242b2c] [f59893bd] [25e3c10c] [7feecba0] [986ababb] [5ec83d99] [454e9635] [3a9950388e0fad45-5] [0a2418c3753eb7c6] [0cfe3919] [32fd0962] [4af30558] [5b22f157] [33d8b345d994b5cd] [9be7734f] [077d88ce] [c81354e3] [78f20538] [96488a01] [27662870] [11213111] [fab49878] [8b0d706cc49a7819] [c1fe3599] [fd434074] [33e1db6c] [a4e647b8] [9ee3a9405e27875c-7] [d406b42b] [101e9e02] [ffb875a5] [52a58e8f] [17e9d310] [c51e873f] [1c218c8c] [61b90b1a] [e9fa8eeb] [8837e11b] [e06c4ba3] [4121a83b] [76c06720] [3af92c4a] [f761f71f] [e29b1657] [acee1cc6] [d83f8ad8] [14f87438] [4254f0c6] [4dcd307a] [c164fa32] [11f3ba9e] [88e9ee1d] [82b10335] [83078306] [9907bed0] [e6354c0d] [70ba84d4] [75a3b387] [f0cd7001] [0189c449] [023f6492] [085290f4] [19749afd] [0529ac2c] [eaf050be34acb41d-349] [23954fefb31ab08f-4] [2bd588ff] [54e0fd4400a566cb-3] [c889b79c] [9d4803e0] [f3948c09] [f34eee03] [2fc57970] [9db520e7] [52a12864] [881bf1e0] [5f59019b] [dda579ae] [474be9ec] [bf6f3727] [65923dcd] [e4fba1a0] [57362a71] [90da2acf] [1766c543] [4adcb179] [a93f5d8f] [cb3ebf5a] [5d8cc78a] [53bd1011] [25060e14] [87530a9d] [d9377085] [03babd1a] [19745133] [7d495206] [6971426c] [6e4f20ff] [8c80c2e5] [0247e8ec] [c095d538] [29a806bd] [6a75b65f] [23018843] [8248f56c] [54020d40] [30bd7a03] [1266bb12] [d0655d2b] [037eaaaa] [400b044b] [f7305cd8] [c1125634] [68af75c1] [ff09ea12] [14371da4] [34580d8f] [f0b6922c] [0931464e] [34a19f28] [033ca6d7] [98d3b258] [b41b50e2] [6fb51a4e] [f9a93a91] [e7dfe8e7] [19182f46] [78778b9a] [6212db88] [97773b64] [e09aa794] [177f901b] [871866d9] [9d5fec7d]

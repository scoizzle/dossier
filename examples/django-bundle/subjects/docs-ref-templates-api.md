# docs/ref/templates/api

- Subject: docs/ref/templates/api (id `5f85971e-2632-4b23-b2e1-1c11ae8e9564`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 19 of 318
- Conflicts: 0
- Gaps: 0

## Facts

- Engine( builtins=["myapp.builtins"], ) [4821f47d]
- Engine( libraries={ "myapp_tags": "path.to.myapp.tags", "admin.urls": "django.contrib.admin.templatetags.admin_urls", }, ) [b27d6a6f]
- Only set it to ``False`` if you're rendering non-HTML templates! [15bf49650ff6b391]
- :class:`django.template.loaders.cached.Loader` requires all of its wrapped loaders to set this attribute, typically by instantiating the ``Origin`` with ``loader=self``. [5c892d3a]
- >>> context = Context({"my_name": "Adrian"}) >>> template.render(context) "My name is Adrian." [861f2b08]
- >>> context = Context({"my_name": "Dolores"}) >>> template.render(context) "My name is Dolores." [6135090e]
- >>> from django.template import Context, Template >>> template = Template("My name is {{ my_name }}.") [baf4cbf0]
- A method that takes a ``template_name`` and yields :class:`~django.template.base.Origin` instances for each possible source. [4709c67a]
- All of the built-in Django template tags are safe to use with the cached loader, but if you're using custom template tags that come from third party packages, or that you wrote yourself, you should ensure that the ``Node`` implementation for each tag is thread-safe. For more information, see :ref:`template tag thread safety considerations <template_tag_thread_safety>`. [e17ea46e]
- For example, the filesystem loader may receive ``'index.html'`` as a ``template_name`` argument. This method would yield origins for the full path of ``index.html`` as it appears in each template directory the loader looks at. [e6f80f44]
- INSTALLED_APPS = ["myproject.polls", "myproject.music"] [43c98a11]
- If the template is instantiated directly rather than through a template loader, this is ``None``. [8f846ca16d3a65ec]
- If the template is instantiated directly rather than through a template loader, this is a string value of ``<unknown_source>``. [fdda5382]
- In general, it is enough to define :meth:`get_template_sources` and :meth:`get_contents` for custom template loaders. ``get_template()`` will usually not need to be overridden. [74d05251]
- Returns a ``Template`` object for a given ``template_name`` by looping through results from :meth:`get_template_sources` and calling :meth:`get_contents`. This returns the first matching template. If no template is found, :exc:`~django.template.TemplateDoesNotExist` is raised. [dd089e08]
- Returns the contents for a template given a :class:`~django.template.base.Origin` instance. [4f5c430f]
- TEMPLATES = [ { "BACKEND": "django.template.backends.django.DjangoTemplates", "APP_DIRS": True, } ] [4cf67aa3]
- TEMPLATES = [ { "BACKEND": "django.template.backends.django.DjangoTemplates", "DIRS": [BASE_DIR / "templates"], "OPTIONS": { "loaders": [ ( "django.template.loaders.cached.Loader", [ "django.template.loaders.filesystem.Loader", "django.template.loaders.app_directories.Loader", "path.to.custom.Loader", ], ), ], }, } ] [b63576a8]
- TEMPLATES = [ { "BACKEND": "django.template.backends.django.DjangoTemplates", "DIRS": [BASE_DIR / "templates"], } ] [d9f75540]

## Beyond the budget

286 more facts did not fit in the budget: [d154b641] [146dfc0c] [a2b7e667] [cf699e04] [3e01d1b3] [6682267e] [0765460f] [40132f9b] [18836416] [3317b1725d58d326] [d3059360] [9f2efc71] [b00d8253] [c54b54cb0805732a-82] [c54b54cb0805732a-83] [22acd32e] [9c7e27cd] [c41e7d3c76cf30ad] [b51f7b866a15b887] [5fecfc476221cc40] [2b380d1e] [90e1c2de3cec758e] [abf776db] [192a4e8d] [5596c6ae] [0c39965d] [9873974f] [7d1874aa] [23c5ab36] [ac4e584c] [772bf17e] [edb3fc20] [9ed2785e] [093a6f80] [1f47997f] [624b90ab50807ee5] [cf410000] [d05efffe] [c581f5a8] [eebb8339] [15349a5b] [2fbddc91] [02adb644] [80db87ab] [fadfa247] [80d47dc5547c9038-14] [47ff310de933b083-5] [eaf050be34acb41d-583] [7077775f] [800dfc64] [61c70d23] [942ae6c11625c81c-149] [6d0889ac] [c1acdde7] [65bed4cd] [6cab8987] [e4f119c9] [a6bedde5] [0ade6755] [a7715b9d] [7fcb0356] [1edde0db] [c0d5bb3e] [b4f7b926] [4349caf8] [85b15ce9] [fc7d778f] [395fe3a9] [affea0fc] [ae3d66ba] [7c427a4f] [b07c4d3f] [ef9b0143] [69f7e0f1] [6d93e2aa] [4e47d046] [015cc516] [b039461e] [39f3a28d] [9b07d869] [f0d3d78e] [b559e87e] [b0f0e23d] [406b1ba7] [c715f335] [bd7eeaf9] [7a9c3210] [b057e9ac] [13b6c176] [4a947ea1] [3ff505b8] [9acb7c26] [55b78b33] [75612711] [e40b9ca2] [e0aecd69] [85989208] [a5aa9878] [855bf681] [2220503f] [ee4efdf9] [c5232f11] [7fbbe9e9] [f92b21e1] [9acb257a] [a6f42fc6] [8879fb89] [1c27cf4c] [733431e4] [df37ff9e] [314bf8b4] [c009d650] [82e7df87] [b34f983f] [e0d111f1d44acb07-3] [ec0a2ec2] [b62fa520] [685d15dfb6eb2285-84] [eaf050be34acb41d-584] [43013600] [bd9aa75d] [9290d859] [443b4058] [0a61e705] [41dd2324] [f1e45fba] [d38917b6] [bbd78286] [af0f55b9] [7a3d9248] [7b95b158] [f6c40a58] [fc2e5c48] [441e0a8b] [56157b91] [4a4f03c1] [52ca6e06] [12dd199b] [e4b8969d] [2b898fd1] [8eb33a95] [6c9400f0] [6aeec3ab63d3bfd4-2] [d0bd6242] [3f4a903c] [f6d5d9c8] [66ef2ca0] [f6df183c] [da3b06c5] [ac23afcf] [d676c713] [ec8018a7] [b0275c6e] [8a457acc] [90ea4847] [a38c56c0] [eaf050be34acb41d-585] [eaf050be34acb41d-586] [eaf050be34acb41d-587] [eaf050be34acb41d-588] [eaf050be34acb41d-589] [eaf050be34acb41d-590] [eaf050be34acb41d-591] [eaf050be34acb41d-592] [eaf050be34acb41d-593] [eaf050be34acb41d-594] [8f4cb94d] [c84ffe90] [1901fb97] [9d2b4b6c] [ab23af35] [54314cb7] [c34645ea] [c9035d94] [4560e3c4] [7bec32bb] [b4f816de] [ddb0f012] [fcf2c5ba] [43d6e872] [86174977] [4e3fe103] [88297ef2] [1205f289] [a1e5989f] [ed04ba39] [90ca8993] [eb1ff918] [a1eb26d754a3d60c-35] [62602b4a] [d8128bd6] [cb8683b9] [eb0dac3a] [6563c20c] [7252aa35] [2630f741] [cd2afc10] [05f7f957] [4f395a1d] [3fc608a9] [1b767fb5] [f707ec41] [aec80df2] [6ba14660] [9ed64e06] [d6addb19] [b88bfaf6] [2c98b0b4] [556ec88a] [ee2329f2] [16092c90] [e5a8be8b] [fc5ac7f0] [1418b88e] [a2d3403c] [e7a4616b] [c2823e29] [f9120cdd] [e999b035] [a07a9ff6] [df292555] [0e79b7ba] [953d2cd9] [0db9ddcc] [50cecfcc] [67d5b6da37976b23] [29bcaf15] [cc93477c] [7ff5bd9c] [42cd713b] [e070c007] [3b52096c] [5bf06049] [19565790] [c2393504] [e616d7ac] [5aac9504] [a827fcb9] [f4614da8] [3765dd6b] [2a662845] [059af285478e7ee4] [12b0198cec145720-2] [72fac09d] [75696e16fcbb84ec-10] [2ed2d0df] [686cb98e] [de5096de] [d109327e] [07097373] [6e39cf1c] [a4827a40] [e2b055a2] [efa8dc19] [9ac0ed10] [4035f659] [5ee9b901] [685842c4] [b8ad09e4] [2fd287cf] [17d781af] [3f928052] [528324fd] [b5a17ac2] [b463e4ba] [1533fe6f] [b72fb25d] [682f7e40] [37e98889] [24a48510] [b3bb8ee8] [68e98475] [0bd716bd] [3e489fcc] [4439160b] [fba7eaab] [e0eabba5] [10a0e18d] [fed9668b] [dc32758d] [800565e7] [16ec7492] [5e7403bb] [6cbaf5c6] [a4f6c5fb] [981ad31c]

# docs/ref/utils

- Subject: docs/ref/utils (id `75e59a13-cda3-469d-b8bd-7a44949c0903`)
- Kind: subject
- Budget: 1200 tokens
- Used: 893 tokens
- Facts shown: 25 of 388
- Conflicts: 0
- Gaps: 0

## Facts

- @cache_page(3600) def my_view(request): pass [ec1eece5]
- cache_page = decorator_from_middleware_with_args(CacheMiddleware) [0c04ae9c]
- # Or more succinctly: @keep_lazy(str) def fancy_utility_function(s, *args, **kwargs): ... [5760bb28]
- # Our previous example was: @keep_lazy(str) def fancy_utility_function(s, *args, **kwargs): ... [3b245570]
- # Which can be rewritten as: @keep_lazy_text def fancy_utility_function(s, *args, **kwargs): ... [5fdf5162]
- # clear it, requiring re-computation next time it's called person.__dict__.pop("friends", None) [8b99977f]
- # in the view: if person.friends(): ... [d832c6fd]
- # set a value manually, that will persist on the instance until cleared person.friends = ["Huckleberry Finn", "Tom Sawyer"] [58f187bc]
- # the model class Person(models.Model): def friends(self): # expensive computation ... return friends [79ef4ca0]
- * ``categories`` should be a sequence of strings. * ``stylesheets`` should be a sequence of either strings or :class:`Stylesheet` instances. [9ad1b17a]
- >>> json_script({"hello": "world"}, element_id="hello-data") '<script id="hello-data" type="application/json">{"hello": "world"}</script>' [9ebb53e2]
- >>> mystr = "<b>Hello World</b> " >>> mystr = mark_safe(mystr) >>> type(mystr) <class 'django.utils.safestring.SafeString'> [5a32ca2e]
- >>> mystr = mystr.strip() # removing whitespace >>> type(mystr) <type 'str'> [0a997328]
- >>> slugify(" Joel is a slug ") 'joel-is-a-slug' [f718cc72]
- >>> slugify("你好 World", allow_unicode=True) '你好-world' [44d8392f]
- Add elements in the root (i.e. feed/channel) element. Called from ``write()``. [24acf94e]
- Add elements on each item (i.e. item/entry) element. [8e0c64dc]
- Add stylesheet information to the document. Called from ``write()``. [efa3fab1]
- Adds an item to the feed. All args are expected to be strings except ``pubdate`` and ``updateddate``, which are ``datetime.datetime`` objects, and ``enclosures``, which is a list of ``Enclosure`` instances. [9f72b810]
- All parameters should be strings, except for two: [43608c48c853a2ec-2]
- An optional string containing the MIME type of the stylesheet. If not specified, Django will attempt to guess it by using Python's :func:`mimetypes.guess_type`. Use ``mimetype=None`` if you don't want your stylesheet to have a MIME type specified. [23e2e921]
- An optional string which will be used as the ``media`` attribute of the stylesheet. Defaults to ``"screen"``. Use ``media=None`` if you don't want your stylesheet to have a ``media`` attribute. [0b9184df]
- Any extra keyword arguments you pass to ``__init__`` will be stored in ``self.feed``. [cc7e2a5a]
- ISO 8601 duration parsing now supports weeks (``PnW``). [273131d4]
- ISO 8601 years (``Y``) and months (``M``) are unsupported as they cannot be represented by :class:`~datetime.timedelta`. [0c8b014e]

## Beyond the budget

346 more facts did not fit in the budget: [7d0c8eb2] [1011a5c0] [a0fd2532] [73584061] [2362ed7a] [a648281d] [414f70bf] [1d7da9d4] [ec6fd8f9] [f5103083] [7395b2b7] [e70491ae] [ba72e5e4] [46e00872] [ff1c2aac] [e2148d20c78ef2f1-2] [7f07ce6c] [bec0cb4c083270c0] [11fc1d3e] [e0eae71e] [6efc4730] [93366162] [074577e8] [2d67c7de] [768e9aee] [7b4496d7] [bcf9c4ea] [da9a9507] [8b0c4ded] [e44c8492] [bea40eab] [cfa6117a] [eab81998] [bbc00776] [f829ce117aa64776-3] [685d15dfb6eb2285-303] [eaf050be34acb41d-600] [eaf050be34acb41d-601] [eaf050be34acb41d-602] [eaf050be34acb41d-603] [5702895d] [310fc139] [bc7f2969] [f9493dfd] [60f49337] [9e68425b] [4c88a5e8] [b81a3a39] [480a8826] [8e275625] [9f60e9d5] [2a966a198e13032b-27] [f237f29a] [15f5185e] [82660985] [3af5e9a5] [e056dcf3] [d355ece9] [48399e2c] [e6a06c00] [dd320e42] [27783845] [1024147f] [a38f4781] [bab598f7] [d98cf984] [f498a3ee] [0056d8e5] [7c86d189] [02e21e28] [f8f7069c] [5934a476] [9fdf0612] [464565f8] [97c25ba1] [6e00b0b6] [4dd71ed6] [9529e3ee] [e4014c96] [758ad723] [ca6a1902] [7c148ee7] [9865f7fa] [54bc78ea] [12415494] [120cf83e] [43da92a6] [3cf0a0b1] [2c51d6357c8c8750] [50a86bb7] [ce855e70] [7d815005] [fe99ab4a] [9e6b87f0] [cb6e3c5e] [8101d08b] [20cb9f45] [1a80cc8c] [bc295f9831206ba3-62] [28edef836ab93f57-26] [28edef836ab93f57-27] [0884d2d0] [d91ebeb2] [01efcfc9] [e7a65723] [f217b466] [4c5910b5] [fed5e47c] [e7f2b095509e968e] [92abd82b] [35cf8116] [85cb2ff7] [3f87c54d] [014de295] [8060cecd] [30c7ad5b] [c85ad1bf] [f8dbe961] [c67ed089] [ce856608] [769c9d92] [75caf759] [42286cbe] [4f1d5dd1] [a7a92f9d] [68653d44] [9168d4af] [2a073ed5] [8657d79e] [3b01a0c0] [cd5327ee] [d6b97033] [3385eabd] [c15ce1eb] [6d81146f] [c6516117] [aed23dc4] [bc0f69c6] [ca3ab10b] [3ddfcde3] [becea75a] [0499f8b4] [4fe6e05c] [8360ad36] [6b306fbe] [6f8af153] [5f61d7a9] [8f97a6a4] [f0a26884] [c93f2580] [84accd767ed5e480] [6569a14c] [af60bf4195904d59] [77a61e50] [a2c9d97a] [10af643b] [47b288fb] [c1a8350b] [af3e35bf] [f59a1622] [e7b3c243] [a1958f3a] [6aa18a6f] [1a101e55] [e0aa2cce] [74fbe540] [4e2f907d] [4c5d6a3f] [1a9404227222af62-2] [b3093c9b] [cc7524d5] [90fd02f3] [81682f13] [2bc808df] [7e1d3ac3] [1b0f9ef0] [cd338786] [bd4d9d7e] [d901ce5f] [832d2f54] [3b27746f] [a9a647ea] [82d052c1] [1a0f8af9] [66cbbafb] [5eb87b19] [ba1e8844] [80f67b13] [97c54cde] [d79698dd] [4523779a] [c6b52326] [17c6817a] [cd03ae96] [533befefe94b9886] [e9421fe9] [0ccdaf10] [97a0de5c] [10493625] [9d84d0e7] [a844d166] [ac17dc87] [a8c0ea5d] [fb927add] [b00b818d2f557164] [3cc81b7e80043ec5-2] [a784f23b] [ef6577f6] [8a57c5b1] [b1b0f551] [cace25ac] [e00d68f6] [66431493] [d0f68afe] [04952b37] [bc28cbcb] [28a848cf] [03314313] [eaf050be34acb41d-604] [e4b0f027] [46a371ca] [740864a5] [e7363631] [fc5ced23] [a4dd56b2] [ed153803] [35c911de] [a560bbe7] [de4cb3a216e127a6] [de4cb3a216e127a6-2] [10c90413] [89709718] [be678bb4] [3b1b2919] [a7323bef] [1b2d6ed3] [353b4ac8] [fcf09f8f] [80b838f8] [02bf9611] [1f2de1d2] [3fe427db] [1ea3e704] [234de62d] [7d8fc604] [7e25b076] [ea2d8afe] [e8424fd9] [f79eac58] [f5ffed5b] [f15f1cc5] [c8af81bc] [18b9bcb9] [2403afef] [1685cb47] [0d1aa17d] [edc58756] [fec95896] [fb8e9f02] [c9234445] [8114bab0] [54d3c6c7] [d67142f1] [4f70497d] [2ae0a2a6] [d57921b5] [1e345554] [d90e2e19] [da5d710a] [b4b96905] [4e099c82] [669d9142] [4873e6cb] [42ee5f73] [846a3f66] [c6bf98f1] [91fef250] [0af6fbae] [28080b6b] [2550c58d] [8b9b9430] [0ffb9ff2] [5791bc19] [a82014de] [01bc521f] [0038d287] [885b7992] [eba145e4] [6954833c] [1a576965] [b83475ab] [28ea0930] [d78dadba] [911df979] [18c446a9] [ace2e450] [a22e25b5] [6690cc80] [f1dda360] [531a80cf] [73084163] [1a300a67] [24e073a0] [fceeb70d] [e3aade9c] [3c37ef24] [603d114e] [b6671e0e] [f97e015b] [2721a63a] [6e2aac72] [cf2c1c25] [bdd382d7] [67ebdac8] [0e670586] [b1e100f7] [2812b2e0] [7429a991] [d0bacb3c] [b131a549] [43db11ec] [dd8338abcb4e506e-6] [51e780ed] [b980ccc2] [89a60e46] [e4e3a503] [a260815a] [5a481928] [904ffc31] [6d825af0] [d9052ad9] [7060c878] [227de3b2] [a434a307] [5417bb22] [d08e9f7b] [77db57d0] [8c2c2a90] [054c8b19] [08674a16] [21843264] [57723b42] [50575b3b] [23eaf0c5] [9225c85e] [97dfdbdb]

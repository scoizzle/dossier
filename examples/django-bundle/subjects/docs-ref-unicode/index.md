# docs/ref/unicode

- Subject: docs/ref/unicode (id `f11bca58-71de-4372-b655-109b9ea38486`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 24 of 91
- Conflicts: 0
- Gaps: 0

## Facts

- >>> from django.utils.encoding import uri_to_iri >>> uri_to_iri("/%E2%99%A5%E2%99%A5/?utf8=%E2%9C%93") '/♥♥/?utf8=✓' >>> uri_to_iri("%A9hello%3Fworld") '%A9hello%3Fworld' [a9046e88]
- >>> from urllib.parse import quote >>> from django.utils.encoding import iri_to_uri >>> quote("Paris & Orléans") 'Paris%20%26%20Orl%C3%A9ans' >>> iri_to_uri("/favorites/François/%s" % quote("Paris & Orléans")) '/favorites/Fran%C3%A7ois/Paris%20%26%20Orl%C3%A9ans' [ff347e69]
- A bytestring does not carry any information with it about its encoding. For that reason, we have to make an assumption, and Django assumes that all bytestrings are in UTF-8. [c1d899e4]
- If you pass a string to Django that has been encoded in some other format, things will go wrong in interesting ways. Usually, Django will raise a ``UnicodeDecodeError`` at some point. [acfbacd2]
- def get_absolute_url(self): url = "/person/%s/?x=0&y=0" % quote(self.location) return iri_to_uri(url) [5f3eeda4]
- def some_view(request): # We know that the data must be encoded as KOI8-R (for some reason). request.encoding = "koi8-r" ... [3aacbac1]
- export LANG="en_US.UTF-8" [86afc754]
- from django.template import Template [3317b1725d58d326-2]
- from urllib.parse import quote from django.utils.encoding import iri_to_uri [fb65ece0]
- import sys [9764c58b]
- iri_to_uri(iri_to_uri(some_string)) == iri_to_uri(some_string) uri_to_iri(uri_to_iri(some_string)) == uri_to_iri(some_string) [14b147b5]
- sys.getfilesystemencoding() [23285f09]
- t2 = Template("This is a string template.") [f610290b]
- * Always return strings from a template tag's ``render()`` method and from template filters. [883f98b4]
- * MySQL users, refer to the `MySQL manual`_ for details on how to set or alter the database character set encoding. [6369fd10]
- * Oracle users, refer to the `Oracle manual`_ for details on how to set (`section 2`_) or alter (`section 11`_) the database character set encoding. [47fc46fe]
- * PostgreSQL users, refer to the `PostgreSQL manual`_ for details on creating databases with the correct encoding. [504a6716]
- * SQLite users, there is nothing you need to do. SQLite always uses UTF-8 for internal encoding. [8a365015]
- * The :func:`django.utils.encoding.iri_to_uri` function, which implements the conversion from IRI to URI as required by :rfc:`3987#section-3.1`. [7618ca3a]
- * The :func:`urllib.parse.quote` and :func:`urllib.parse.quote_plus` functions from Python's standard library. [491bdea2]
- * Use ``force_str()`` in preference to ``smart_str()`` in these places. Tag rendering and filter calls occur as the template is being rendered, so there is no advantage to postponing the conversion of lazy translation objects into strings. It's easier to work solely with strings at that point. [9e2228ed]
- .. _above: `URI and IRI handling`_ [7c692886]
- .. _unicode-files: [7ae4e2b1]
- .. _uri-and-iri-handling: [69878320]

## Beyond the budget

66 more facts did not fit in the budget: [29664800] [269f7f20] [1a2f4414] [faf19aa4] [eaf050be34acb41d-595] [eaf050be34acb41d-596] [8aa7203c166b13be-115] [6d662fb3] [c54b54cb0805732a-86] [9ae25ce1] [40333b9b] [1ed32e83] [0daca599] [c90f9e71] [1cda605d] [68b36cec] [98e88b93] [11399dff] [ebc4f8c2] [94773d20] [4a5e18bf] [de786ea7] [10a3cf46] [3baa46b1] [f472fb69] [fd36c2be] [850194de] [b6200653] [f6efa64d] [e9eb5263] [3ac4387e] [51b4b30f] [0f9daf4e] [02965830] [4efb472b] [a008878e] [2a38c545] [abcef819] [e62bf0ef] [6f14d294] [08dadfab] [0f8f215e610fb29a-2] [312c4cbb] [4fa76090] [205c79f2] [06ee9939] [7c35b834] [a272cd61] [06354fea] [50b4735ad9254de8-2] [4cf6db7d] [1a3f67b2] [cb64d8e2] [d4cd3e96] [4e37a8a3] [eae9a22e] [738cb51e] [bf50d9ad] [f7ddb347] [f67a5f91] [ffc6f5ed] [443312f8] [8902b4a2] [b24b0bfb] [32d203ee] [04f739be]

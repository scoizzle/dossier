# docs/internals/howto-release-django

- Subject: docs/internals/howto-release-django (id `528adb73-5f1c-4a63-8e26-fadcba94e6c6`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 32 of 240
- Conflicts: 0
- Gaps: 0

## Facts

- $ cd django $ django-admin makemessages -l en --domain=django processing locale en $ django-admin makemessages -l en --domain=djangojs processing locale en [0c9543bb]
- $ git checkout stable/A.B.x $ git checkout -b update-translations-catalog-A.B.x [74120d87]
- $ PGP_KEY_ID=<key-id> PGP_KEY_URL=<key-url> DEST_FOLDER=~/releases scripts/do_django_release.py [4c911491]
- $ VERSION=5.2.1 scripts/verify_release.sh [921d51af]
- $ cd dist $ md5sum * $ sha1sum * $ sha256sum * [01df8176]
- $ cd docs $ make man $ man _build/man/django-admin.1 # do a quick sanity check $ cp _build/man/django-admin.1 man/django-admin.1 [83f69183]
- $ cve publish <cve-number> --cve-json-file <path-to-file> [a212f7f9]
- $ git checkout stable/4.1.x $ git merge --ff-only security/4.1.x [52d81b5d]
- $ git checkout stable/4.1.x $ git pull [313773af]
- $ git checkout stable/4.2.x $ git pull $ python manage_translations.py robots_txt [71c805a9]
- $ git diff --name-only stable/5.0.x | grep "\.po" | xargs sed -ri "s/PO-Revision-Date: [0-9\-]+ /PO-Revision-Date: $(date -I) /g" [c9c12274]
- $ git fetch upstream $ git checkout -b security/5.2.x upstream/stable/5.2.x $ git push origin -u security/5.2.x:security/5.2.x [329ff429]
- $ git push $ git push --tags [e2906542]
- $ git tag --sign --message="Tag 4.1.1" 4.1.1 [5fbc3e9d]
- $ python -m pip install build twine --uploaded-prior-to=P7D [b01e584e]
- $ python scripts/manage_translations.py fetch -v 1 --since=<some date> [898387ad]
- curl https://github.com/<<RELEASE MANAGER GITHUB USERNAME>>.gpg | gpg --import - [c940e735]
- gpg --verify <<THIS FILENAME>> [2c771a3a]
- $ cve --interactive reserve <quantity> [a4286ef7]
- $ export CVE_USER=<user-email>@djangoproject.com CVE_ORG=DSF [fd146f69]
- $ twine upload --repository django dist/* [2e075031]
- #. Create a tag for the EOL stable branch and delete the stable branch. Inspect and use the ``scripts/archive_eol_stable_branches.py`` helper. [a7b5e5a5]
- #. Ensure that the EOL versions are mentioned in the blog post. See `example announcement <https://www.djangoproject.com/weblog/2025/apr/02/django-52-released/>`__. [9b377f69]
- $ gpg --clearsign --digest-algo SHA256 prenotification-email.txt [735ccbd8]
- .. code-block:: shell [8aa7203c166b13be-51]
- .. code-block:: shell [8aa7203c166b13be-52]
- .. code-block:: shell [8aa7203c166b13be-53]
- .. code-block:: shell [8aa7203c166b13be-54]
- .. code-block:: shell [8aa7203c166b13be-55]
- [distutils] index-servers = pypi django [37100f92]
- [django] repository = https://upload.pypi.org/legacy/ username = __token__ password = # A project token. [068bf3f0]
- [https://www.transifex.com] rest_hostname = https://rest.api.transifex.com token = # API token [e710c8ae]

## Beyond the budget

208 more facts did not fit in the budget: [0caa6bd7] [27ba0307] [5918265d] [5d9151be] [dd0ce2cf] [8aa7203c166b13be-56] [8aa7203c166b13be-57] [62574182] [dc587cfb] [f70ac568] [080f9993] [c81af7b0] [2dbb7808] [def36e03] [1aca49ff] [b1c3888c] [12379b74] [6becb5e0] [9c7b8c70] [7825d3e1] [7be530f2] [f1ae5d8c] [1519d4ca] [15f872a7] [86c36c19] [39b75dba] [c5407a1a] [95aa95a6] [3c5aee8d] [9f4d5006] [efc5b625] [4933fd7c] [a4ad2df9] [7702fe4f] [21061199] [3c0b4164] [04ce92be] [f519fe54] [7d0c6688] [7fd46031] [3b891eef] [3c71f09d] [2681f72e] [8aa7203c166b13be-58] [8aa7203c166b13be-59] [8aa7203c166b13be-60] [8aa7203c166b13be-61] [8aa7203c166b13be-62] [8aa7203c166b13be-63] [8aa7203c166b13be-64] [8aa7203c166b13be-65] [8aa7203c166b13be-66] [8aa7203c166b13be-67] [8aa7203c166b13be-68] [8aa7203c166b13be-69] [8aa7203c166b13be-70] [8aa7203c166b13be-71] [8aa7203c166b13be-72] [3a9340cd0d877339-6] [3a9340cd0d877339-7] [463eb4b7] [ec621726] [95c99675] [ed9e6f48] [05f00e43] [f6248356] [fa2141c0] [7094f43e] [1160b13a] [719d7fd6] [b3d7fb26] [2837b709] [f3a3311a] [afcac1dc] [c7d8923b] [7bfca401] [1a1f6d3d] [8f2cdeb4fca1bdd2] [b0747e27] [aee3f807] [2a67c835] [4e646811] [78dd04e7] [8810cad9] [1048077a] [e3d08bb6] [e7e5af2c] [2ccd8e47] [6c722d78] [c013e34b] [2193a101] [cde1c88a] [541065da] [c7e222cf] [196b227c] [94a3f06c] [777bad68] [745967c0] [3f3a5e59] [32fdd7d5] [a5e8e3ee] [1e85cfd1] [29f5ef9e] [c6f33215] [6c759f80] [bb98aca3] [7315edde] [27797ec8] [f47b1b33] [71c5cccc] [53fff730] [d6e8ef2c] [6c29a2d0] [e3363098] [a20eca10] [054c7b9a] [b5f5389a] [835e13a4] [83f7d49e] [512a3ba5] [9a83da93] [609a7177] [76c4fe56] [671eeb20] [ba9b1cdc] [d312f4c7] [7ad549bd] [e8ed8069] [9d1ad422] [b348e98b] [cf082599] [29a4159e] [604688ae] [c782ef13] [1867bd7a] [84ae1dda] [a53eda10] [59f3f7d9] [e2efb8e8] [3e938cb2] [6f76baf3] [6b739640] [e2e95ab4] [c182df37] [c926e44b] [ac5d7ab3] [be22dbaa] [33b11ac0] [50682e6a] [d4cbe4dc] [27e9c800] [8efbd565] [1a20f53a] [8cfb251d] [284a8dc5] [f2a553cc] [9c0a2fc7] [f6666435] [8a499428] [b48a06d8] [d8e01021] [e193f6cb] [eafc633b] [198f83b6] [fac409d3] [c4fde4ee] [899ef41f] [dfe1bb59] [d18ae73a] [071b3d4b] [258d327e] [de56a69d] [701a5415] [f8dc7f40] [040829c4] [a7801951] [7d24dca4] [d8209752] [f63e035c] [6d213967] [d59e62bd] [d2050a8c] [26ddfaf7] [1fa41f06] [acd407c9] [59da5ceb] [2b53f6ac] [d5fdfe86] [8279f57c] [dcec729c] [55431993] [841a6629] [1acd2ef0] [8882e64f] [b0e9fb54] [6bc2d08b] [75696e16fcbb84ec] [e89a40c7] [349458e1] [9edec822] [c5d19d6b728490f9] [d139e281] [0c9876e7] [8bf52831] [7af00bc3] [a43b0550] [2426507e] [3e70299e]

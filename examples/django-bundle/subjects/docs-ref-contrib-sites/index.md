# docs/ref/contrib/sites

- Subject: docs/ref/contrib/sites (id `fa62c888-eb6a-4d0f-a12e-e8692acc9a22`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 23 of 125
- Conflicts: 0
- Gaps: 0

## Facts

- # ... [820935f903511f30]
- # ... [820935f903511f30-2]
- A human-readable "verbose" name for the website. [256b77f9]
- Sets the ``name`` and ``domain`` attributes to the value of :meth:`~django.http.HttpRequest.get_host`. [06d32c4d]
- The fully qualified domain name associated with the website. For example, ``www.example.com``. [99906576]
- current_site = get_current_site(request) send_mail( "Thanks for subscribing to %s alerts" % current_site.name, "Thanks for your subscription. We appreciate it.\n\n-The %s team." % (current_site.name,), "editor@%s" % current_site.domain, [user.email], ) [05ce41a1]
- subject = loader.get_template("alerts/subject.txt").render({}) message = loader.get_template("alerts/message.txt").render({}) send_mail(subject, message, "editor@ljworld.com", [user.email]) [017093c1]
- def article_detail(request, article_id): try: a = Article.objects.get(id=article_id, sites__id=get_current_site(request).id) except Article.DoesNotExist: raise Http404("Article does not exist on this site") # ... [03b28c2b]
- from django.contrib.sites.shortcuts import get_current_site [6640ffcc7d240625]
- # First call; current site fetched from database. current_site = Site.objects.get_current() # ... [851843b5]
- # Force a database query for the third call. Site.objects.clear_cache() current_site = Site.objects.get_current() [77cc00a4]
- # Second call; current site fetched from cache. current_site = Site.objects.get_current() # ... [2c234fa6]
- .. attribute:: domain [d4a7141e]
- .. attribute:: name [80d47dc5547c9038-12]
- .. method:: __init__(request) [2f372659]
- >>> from django.contrib.sites.models import Site >>> obj = MyModel.objects.get(id=3) >>> obj.get_absolute_url() '/mymodel/objects/3/' >>> Site.objects.get_current().domain 'example.com' >>> "https://%s%s" % (Site.objects.get_current().domain, obj.get_absolute_url()) 'https://example.com/mymodel/objects/3/' [78361175]
- A class that shares the primary interface of :class:`~django.contrib.sites.models.Site` (i.e., it has ``domain`` and ``name`` attributes) but gets its data from a Django :class:`~django.http.HttpRequest` object rather than from a database. [3459ebd2]
- A function that checks if ``django.contrib.sites`` is installed and returns either the current :class:`~django.contrib.sites.models.Site` object or a :class:`~django.contrib.sites.requests.RequestSite` object based on the request. It looks up the current site based on :meth:`request.get_host() <django.http.HttpRequest.get_host>` if the :setting:`SITE_ID` setting is not defined. [c5f373aa]
- A model for storing the ``domain`` and ``name`` attributes of a website. [194b36da]
- Photo.objects.filter(site=settings.SITE_ID) Photo.on_site.all() [a3ab53be]
- SITE_ID = 1 [fbc7ac26]
- The ``CurrentSiteManager`` is only usable when the :setting:`SITE_ID` setting is defined in your settings. [d4e3bd4c]
- def my_view(request): site = Site.objects.get_current() ... [fe0376fc]

## Beyond the budget

93 more facts did not fit in the budget: [ef325524] [c3b8fce4] [534331f7] [04f0b4fc] [07ceed98] [c2e855cb] [e85bb237] [cb89d7bf881951cc] [e0d111f1d44acb07-2] [0183f3a9b10540ba] [a469f631d2ceb5f6] [aa2bfb4a] [ca638471] [6d887609] [2732ad65] [0991b409] [45b0006f] [ab797a90] [581fbd53] [3ae0131a] [f2a6bafd] [8539004f] [ffa9328d] [4a5326b5] [9526dc65] [1e9b3366] [8d6efe78] [2be4228c] [434028c3] [23bc44af] [99de847a] [e2ed8b1f] [e829db63] [0336ad50] [eaf050be34acb41d-266] [3222a9bb] [a77646bf] [c8f59b8c] [c875687a] [3ef324a9] [ec1bb048] [9d0e8fa8] [64add0a8] [b800c8ab] [cea22b3d] [7b517bc7] [42dafa68] [bce99cf2] [1c7f827c] [432cca1a] [0e74b6b2] [f681fcb5] [a9729483] [93c716a2] [e62d24fc] [7533230a] [09b4db39] [4d5ca060] [6b59befa] [56da7242] [db52ada1] [ee8eeccd] [189dbc21] [b383862a] [a57aa941] [a7de4f26] [f3333f0b] [5f1e832e] [e6bf3c0e] [236953c0] [9d0a4a86] [193ff407] [8d51a312] [4bfa67aa] [313d88c9] [167fccc3] [a3c33891] [2e72ca6e] [a4ab7282] [85512b95] [d2c95b3b] [8628fc25] [0fa8992b] [a26413f9] [7fe4e9f0] [20aa6f44] [ed3c01d8] [a5921840] [70fde8c0] [67d5a6dd] [475c322b] [9b1b1a36] [4d468feb]

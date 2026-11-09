# docs/ref/contrib/flatpages

- Subject: docs/ref/contrib/flatpages (id `93850351-2c1b-48f7-9e71-c118cfa9c48a`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 25 of 121
- Conflicts: 0
- Gaps: 0

## Facts

- Boolean. This field is not used by :mod:`~django.contrib.flatpages` by default and does not appear in the admin interface. Please see :ref:`flatpages admin interface section <flatpages-admin>` for a detailed explanation. [5d74ff28]
- Boolean. When ``True``, restricts the page access to logged-in users only. [67eb7803]
- Many-to-many relationship to :class:`~django.contrib.sites.models.Site`, which determines the :doc:`sites </ref/contrib/sites>` the flatpage is available on. [61227f18]
- Optional (:attr:`blank=True <django.db.models.Field.blank>`). :class:`~django.db.models.TextField` that typically, contains the HTML content of the page. [34ff3f3b]
- Optional (:attr:`blank=True <django.db.models.Field.blank>`). 70 characters or fewer. Specifies the template used to render the page. Defaults to :file:`flatpages/default.html` if not provided. [fe592bed]
- Required. 100 characters or fewer. Indexed for faster lookups. [8bc55d44]
- Required. 200 characters or fewer. [d72539f0]
- Returns the relative URL path of the page based on the :attr:`~django.contrib.flatpages.models.FlatPage.url` attribute. [99b7de84]
- # Define a new FlatPageAdmin class FlatPageAdmin(FlatPageAdmin): fieldsets = [ (None, {"fields": ["url", "title", "content", "sites"]}), ( _("Advanced options"), { "classes": ["collapse"], "fields": [ "enable_comments", "registration_required", "template_name", ], }, ), ] [f9ec3a7c]
- # Re-register FlatPageAdmin admin.site.unregister(FlatPage) admin.site.register(FlatPage, FlatPageAdmin) [05d4fd71]
- # Your other patterns here urlpatterns += [ re_path(r"^(?P<url>.*/)$", views.flatpage), ] [0c96cf21]
- * If the flatpage has a custom template, it loads that template. Otherwise, it loads the template :file:`flatpages/default.html`. [4ec30911]
- * It passes that template a single context variable, ``flatpage``, which is the flatpage object. It uses :class:`~django.template.RequestContext` in rendering the template. [fa43b7e6]
- .. attribute: registration_required [425f96f3]
- .. attribute:: content [9113d5a6]
- .. attribute:: enable_comments [f3ca8736]
- .. attribute:: sites [776c028e]
- .. attribute:: template_name [47ff310de933b083-2]
- .. attribute:: title [a6040a0d]
- .. attribute:: url [f829ce117aa64776-2]
- .. method:: get_absolute_url() [15f269e0]
- <!DOCTYPE html> <html lang="en"> <head> <title>{{ flatpage.title }}</title> </head> <body> {{ flatpage.content }} </body> </html> [ce4c13cf]
- Each time any Django application raises a 404 error, this middleware checks the flatpages database for the requested URL as a last resort. Specifically, it checks for a flatpage with the given URL with a site ID that corresponds to the :setting:`SITE_ID` setting. [a47f5577]
- If it doesn't find a match, the request continues to be processed as usual. [0f79992c]
- If it finds a match, it follows this algorithm: [f81b1380]

## Beyond the budget

89 more facts did not fit in the budget: [c47fc40d] [ee4c020c] [049a8c12] [3e444928] [07d85f61] [b8d0e7548b192bff] [1cfc84be] [cd5c9082] [56bfdb07e34bb2a1] [bc4ae10a] [e54c142b] [9ad22ded] [2a61d97969e83c2a] [f5f0d954] [fd30cf3c] [9ca8f647] [a6d6ee15] [8e8122c4] [3aba9c37] [59dac90f] [0b1d7376] [60e6ddf4] [e1b82724] [473267ef] [75c8ea879f4a56ca] [685d15dfb6eb2285-63] [6a94ebf9] [51d68996] [3e146637] [d4e9bc65] [b272e86d] [abe2b4ce] [c54b54cb0805732a-19] [c54b54cb0805732a-20] [cc01e180] [d34e1585] [eeca4fe9] [fd77d5f2] [d3f95843] [e4c44fbd] [63845c03] [a2a969ed] [e54a9b90] [ad9e98f8] [ee9d50a8] [31bda36a] [a6bd17cd] [df91895f] [871edec7] [8c4ae3b9] [84675e43a58d58cc] [063271e57f785225-4] [de06ced4] [f305dae4] [8d6a4f57] [bc295f9831206ba3-3] [bc295f9831206ba3-4] [8ab77384ea4cc532] [063f72b1] [8fbb2760] [a4d11148] [0cef2b7e7679766a] [7a8638e4] [36255e61] [28135664] [8db4d8757db9fb63-2] [bde27b1f] [98f5bb64] [af9b1384] [d5882157dc780592-5] [c380a3ee] [0252226f] [9221c53d] [be15cd49] [84a798df] [b7e7821f] [00b96753] [8b366f03] [e387d0bd] [1392d2aa] [74ef3cbf] [c87ac88c] [13849c37] [4d9c577be104c776] [2d26d25ee8ee8de6] [dfa15974] [6e3c5f63] [fe28932d] [bd685ff5]

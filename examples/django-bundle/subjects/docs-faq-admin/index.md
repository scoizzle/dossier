# docs/faq/admin

- Subject: docs/faq/admin (id `1a3edef8-8528-4659-a0a3-217f0332cca4`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1911 tokens
- Facts shown: 29 of 29
- Conflicts: 0
- Gaps: 0

## Highlights

- .. _admin-browser-support: [037f79d5]
- ============== FAQ: The admin ============== [78740fb7]
- Depending on feature support, there *may* be minor stylistic differences between browsers. These are considered acceptable variations in rendering. [4be9742b]
- Django won't bother displaying the filter for a ``ManyToManyField`` if there are no related objects. [b3c18f19]
- For example, if your :attr:`~django.contrib.admin.ModelAdmin.list_filter` includes :doc:`sites </ref/contrib/sites>`, and there are no sites in your database, it won't display a "Site" filter. In that case, filtering by site would be meaningless. [5c9a5fe4]
- How can I customize the functionality of the admin interface? ============================================================= [a94e64ba]
- How do I automatically set a field's value to the user who last edited the object in the admin? =============================================================================================== [7c6de59f]
- How do I limit admin access so that objects can only be edited by the users who created them? ============================================================================================= [5ff3fc6d]
- I can't log in. When I enter a valid username and password, it brings up the login page again, with a "Please enter a correct username and password" error. =========================================================================================================================================================== [0b99422c]
- I can't log in. When I enter a valid username and password, it just brings up the login page again, with no error messages. =========================================================================================================================== [5e4c83be]
- If you want more flexibility than is feasible by tweaking the auto-generated forms, feel free to write custom views for the admin. The admin is powered by Django itself, and you can write custom views that hook into the authentication system, check permissions and do whatever else they need to do. [5ab66a69]
- If you want to customize the look-and-feel of the admin interface, read the next question. [c5eef62a]
- If you're sure your username and password are correct, make sure your user account has :attr:`~django.contrib.auth.models.User.is_active` and :attr:`~django.contrib.auth.models.User.is_staff` set to True. The admin site only allows access to users with those two fields both set to True. [904df5bb]
- Inconsistent row counts may be caused by missing foreign key values or a foreign key field incorrectly set to :attr:`null=False <django.db.models.Field.null>`. If you have a record with a :class:`~django.db.models.ForeignKey` pointing to a nonexistent object and that foreign key is included is :attr:`~django.contrib.admin.ModelAdmin.list_display`, the record will not be shown in the admin changelist because the Django model is declaring an integrity constraint that is not implemented at the database level. [418e0f3a]
- See :ref:`serving the admin files <serving-the-admin-files>` in the "How to use Django with mod_wsgi" documentation. [cd6df392]

## All facts

- [0f143fef] My "list_filter" contains a ManyToManyField, but the filter doesn't display. ============================================================================
- [869487ff] My admin-site CSS and images showed up fine using the development server, but they're not displaying when using mod_wsgi. =========================================================================================================================
- [3fb680ba] On mobile and tablet devices, the admin provides a responsive experience for web standards compliant browsers. This includes the major browsers on both Android and iOS.
- [e7684c65] Some objects aren't appearing in the admin. ===========================================
- [b6f286c8] The :class:`~django.contrib.admin.ModelAdmin` class also provides customization hooks that allow you to control the visibility and editability of objects in the admin. Using the same trick of extracting the user from the request, the :meth:`~django.contrib.admin.ModelAdmin.get_queryset` and :meth:`~django.contrib.admin.ModelAdmin.has_change_permission` can be used to control the visibility and editability of objects in the admin.
- [299a8de3] The :class:`~django.contrib.admin.ModelAdmin` class provides customization hooks that allow you to transform an object as it saved, using details from the request. By extracting the current user from the request, and customizing the :meth:`~django.contrib.admin.ModelAdmin.save_model` hook, you can update an object to reflect the user that edited it. See :ref:`the documentation on ModelAdmin methods <model-admin-methods>` for an example.
- [453c46ce] The admin is intended to be compatible with a wide range of assistive technologies, but there are currently many blockers. The support target is all latest versions of major assistive technologies, including Dragon, JAWS, NVDA, Orca, TalkBack, Voice Control, VoiceOver iOS, VoiceOver macOS, Windows Contrast Themes, ZoomText, and screen magnifiers.
- [d1a47f2a] The admin provides a fully-functional experience to the recent versions of modern, web standards compliant browsers. On desktop this means Chrome, Edge, Firefox, Opera, Safari, and others.
- [a2f2333f] The dynamically-generated admin site is ugly! How can I change it? ==================================================================
- [34275423] The login cookie isn't being set correctly, because the domain of the cookie sent out by Django doesn't match the domain in your browser. Try setting the :setting:`SESSION_COOKIE_DOMAIN` setting to match your domain. For example, if you're going to "https://www.example.com/admin/" in your browser, set ``SESSION_COOKIE_DOMAIN = 'www.example.com'``.
- [cc8e9b6b] We like it, but if you don't agree, you can modify the admin site's presentation by editing the CSS stylesheet and/or associated image files. The site is built using semantic HTML and plenty of CSS hooks, so any changes you'd like to make should be possible by editing the stylesheet.
- [5718643a] What assistive technologies are supported for using the admin? ==============================================================
- [a048d433] What browsers are supported for using the admin? ================================================
- [ba760220] You've got several options. If you want to piggyback on top of an add/change form that Django automatically generates, you can attach arbitrary JavaScript modules to the page via the model's class Admin :ref:`js parameter <modeladmin-asset-definitions>`. That parameter is a list of URLs, as strings, pointing to JavaScript modules that will be included within the admin form via a ``<script>`` tag.

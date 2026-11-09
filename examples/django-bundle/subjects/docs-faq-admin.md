# docs/faq/admin

- Subject: docs/faq/admin (id `65f2df6e-267b-47dc-8f7e-4a2e7057e502`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 15 of 29
- Conflicts: 0
- Gaps: 0

## Facts

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

## Beyond the budget

14 more facts did not fit in the budget: [0f143fef] [869487ff] [3fb680ba] [e7684c65] [b6f286c8] [299a8de3] [453c46ce] [d1a47f2a] [a2f2333f] [34275423] [cc8e9b6b] [5718643a] [a048d433] [ba760220]

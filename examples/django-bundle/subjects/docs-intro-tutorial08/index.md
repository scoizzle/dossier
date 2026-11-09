# docs/intro/tutorial08

- Subject: docs/intro/tutorial08 (id `b159a12d-1d7f-4d48-8895-1ad62175f610`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1420 tokens
- Facts shown: 24 of 24
- Conflicts: 0
- Gaps: 0

## Highlights

- $ python -m pip install django-debug-toolbar [916a9692]
- If you're having trouble going through this tutorial, please head over to the :doc:`Getting Help</faq/help>` section of the FAQ. [eff105796d7d4d6a-8]
- #. If the problem is with a specific package, check if there's a troubleshooting guide or FAQ in the package's documentation. For example the Django Debug Toolbar has a `Tips section <https://django-debug-toolbar.readthedocs.io/en/latest/tips.html>`_ that outlines troubleshooting options. #. Search for similar issues on the package's issue tracker. Django Debug Toolbar’s is `on GitHub <https://github.com/django-commons/django-debug-toolbar/issues>`_. #. Consult the `Django Forum <https://forum.djangoproject.com/>`_. #. Join the `Django Discord server <https://chat.djangoproject.com>`_. [c055849f]
- .. admonition:: Where to get help: [dbb2ef17dd903b2b-9]
- .. console:: [7714e199aac2701e-82]
- ===================================== Writing your first Django app, part 8 ===================================== [2980f95c]
- As Adam points out in his post, when the answer to one of the questions is "no", that's an opportunity to contribute. [39fb082a]
- At some point you will run into a problem, for example the toolbar may not render. When this happens and you're unable to resolve the issue yourself, there are options available to you. [7bd64bab]
- Django Debug Toolbar is a useful tool for debugging Django web applications. It's a third-party package that is maintained by the community organization `Django Commons <https://github.com/django-commons>`_. The toolbar helps you understand how your application functions and to identify problems. It does so by providing panels that provide debug information about the current request and response. [2e0c33e0]
- Django Debug Toolbar requires several setup steps. Follow them in `its installation guide <https://django-debug-toolbar.readthedocs.io/en/latest/installation.html>`_. The steps are not duplicated in this tutorial, because as a third-party package, it may change separately to Django's schedule. [7241944e]
- Getting help from others ======================== [cceea305]
- If you are familiar with Python packaging and interested in learning how to turn polls into a "reusable app", check out :doc:`Advanced tutorial: How to write reusable apps</intro/reusable-apps>`. [61fc9af4]
- Installing Django Debug Toolbar =============================== [92cda455]
- Installing other third-party packages ===================================== [56fb9647]
- It can be difficult to know what third-party packages you should use. This depends on your needs and goals. Sometimes it's fine to use a package that's in its alpha state. Other times, you need to know it's production ready. `Adam Johnson has a blog post <https://adamj.eu/tech/2021/11/04/the-well-maintained-test/>`_ that outlines a set of characteristics that qualifies a package as "well maintained". Django Packages shows data for some of these characteristics, such as when the package was last updated. [2867936d]
- What's next? ============ [772ceab8a391e4de-2]

## All facts

- [8dff7427] Once installed, you should be able to see the DjDT "handle" on the right side of the browser window when you browse to ``http://localhost:8000/admin/``. Click it to open the debug toolbar and use the tools in each panel. See the `panels documentation page`__ for more information on what the panels show.
- [54c635e7] The beginner tutorial ends here. In the meantime, you might want to check out some pointers on :doc:`where to go from here </intro/whatsnext>`.
- [2ece33d3] There are many more third-party packages, which you can find using the fantastic Django resource, `Django Packages <https://djangopackages.org/>`_.
- [f70507d6] Third-party packages that integrate with Django need some post-installation setup to integrate them with your project. Often you will need to add the package's Django app to your :setting:`INSTALLED_APPS` setting. Some packages need other changes, like additions to your URLconf (``urls.py``).
- [8a3870ee] This tutorial begins where :doc:`Tutorial 7 </intro/tutorial07>` left off. We've built our web-poll application and will now look at third-party packages. One of Django's strengths is the rich ecosystem of third-party packages. They're community developed packages that can be used to quickly improve the feature set of an application.
- [4225048a] This tutorial will show how to add :pypi:`Django Debug Toolbar <django-debug-toolbar>`, a commonly used third-party package. The Django Debug Toolbar has ranked in the top three most used third-party packages in the Django Developers Survey in recent years.
- [31cb9a76] To install a third-party application like the toolbar, you need to install the package by running the below command within an activated virtual environment. This is similar to our earlier step to :ref:`install Django <installing-official-release>`.
- [e929bc03] __ https://django-debug-toolbar.readthedocs.io/en/latest/panels.html

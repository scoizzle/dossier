# docs/intro/tutorial07

- Subject: docs/intro/tutorial07 (id `08b0df05-34bb-40e9-b864-2e49ff3d884d`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 24 of 117
- Conflicts: 0
- Gaps: 0

## Facts

- $ python -c "import django; print(django.__path__)" [5b004fb8]
- # ... admin.site.register(Choice) [3ec0132b]
- .. console:: [7714e199aac2701e-81]
- If you have difficulty finding where the Django source files are located on your system, run the following command: [475e857f]
- If you're having trouble going through this tutorial, please head over to the :doc:`Getting Help</faq/help>` section of the FAQ. [eff105796d7d4d6a-7]
- Just like the static files, we *could* have all our templates together, in one big templates directory, and it would work perfectly well. However, templates that belong to a particular application should be placed in that application's template directory (e.g. ``polls/templates``) rather than the project's (``templates``). We'll discuss in more detail in the :doc:`reusable apps tutorial </intro/reusable-apps>` *why* we do this. [3fb1ede1]
- TEMPLATES = [ { "BACKEND": "django.template.backends.django.DjangoTemplates", "DIRS": [BASE_DIR / "templates"], "APP_DIRS": True, "OPTIONS": { "context_processors": [ "django.template.context_processors.request", "django.contrib.auth.context_processors.auth", "django.contrib.messages.context_processors.messages", ], }, }, ] [f8a8c46a]
- admin.site.register(Question, QuestionAdmin) [ed68076a1c9d4412]
- class ChoiceInline(admin.StackedInline): model = Choice extra = 3 [4690fd46]
- class ChoiceInline(admin.TabularInline): ... [11c0100b]
- class Question(models.Model): # ... @admin.display( boolean=True, ordering="pub_date", description="Published recently?", ) def was_published_recently(self): now = timezone.now() return now - datetime.timedelta(days=1) <= self.pub_date <= now [4284aaad]
- class QuestionAdmin(admin.ModelAdmin): # ... list_display = ["question_text", "pub_date", "was_published_recently"] [b32f73fa]
- class QuestionAdmin(admin.ModelAdmin): # ... list_display = ["question_text", "pub_date"] [dac7b1c3]
- class QuestionAdmin(admin.ModelAdmin): fields = ["pub_date", "question_text"] [d8e02837]
- class QuestionAdmin(admin.ModelAdmin): fieldsets = [ (None, {"fields": ["question_text"]}), ("Date information", {"fields": ["pub_date"], "classes": ["collapse"]}), ] inlines = [ChoiceInline] [107d0487]
- class QuestionAdmin(admin.ModelAdmin): fieldsets = [ (None, {"fields": ["question_text"]}), ("Date information", {"fields": ["pub_date"]}), ] [6d7f0f50]
- from .models import Choice, Question [5fac61bb1ff3fe06-3]
- from .models import Question [df692aec3f5cbbed-8]
- from django.contrib import admin [13fbe7fc2a5a9c75-3]
- list_filter = ["pub_date"] [491d2dc1]
- search_fields = ["question_text"] [05f14916]
- {% block branding %} <div id="site-name"><a href="{% url 'admin:index' %}">Polls Administration</a></div> {% if user.is_anonymous %} {% include "admin/color_theme_toggle.html" %} {% endif %} {% endblock %} [cffab59e]
- .. _ref-customizing-your-projects-templates: [037773a9]
- .. admonition:: Organizing templates [15d0d005]

## Beyond the budget

79 more facts did not fit in the budget: [d20d6183] [bc5c887c] [dbb2ef17dd903b2b-8] [685d15dfb6eb2285-44] [bf67fa15468f979f-2] [20257edb57d397a8-2] [ce20b11c82955ef6-5] [9c127d039bb0d767-2] [6699141e] [ad974c0c] [bcc9c369] [b55c68fb] [ef6ccd53] [0482eb4b] [60dfb8e9] [641805dd] [6b4a5e54e001d097-14] [73e3efb0] [a8ca4443] [309a8951] [5f063fd2] [6e60517c] [67a49769] [ef002c98] [cd2f5235] [fa1834ea] [631154c1] [2fe3a5d5] [f0d5f759] [dffcdad3] [08b50a3c] [c9ae8445] [0da268e3] [4516d6ee] [fda8653d] [e29557c5] [fb938f36] [92284d45] [018c581c] [d4dfc1e6] [f474c8df] [88f32091] [0f514642] [1d382d81] [57843cf3] [52f8926f] [98031d91] [984aed3c] [4e752115] [761554ef] [e34a77e5] [3d103173] [fef8b8fb] [192a138e] [a54366a4] [2b739680] [510a75f5] [217e09b0] [0d5aff09] [cdeee7af] [34fe7beb] [9b062922] [63d67bf8] [db688598] [3e7b11f0] [144556be] [cac21871] [a7408945] [b44e0373] [52b0f939] [005086b5] [f208a6e2] [d51cd9d5] [34c388e3] [453fbc33] [c8c2870e] [a590c620] [2bf73b32] [945907f8]

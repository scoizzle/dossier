# docs/intro/tutorial02

- Subject: docs/intro/tutorial02 (id `2a33e63f-f11f-417b-ad55-ae295de2d2a8`)
- Kind: subject
- Budget: 1200 tokens
- Used: 898 tokens
- Facts shown: 17 of 171
- Conflicts: 0
- Gaps: 0

## Facts

- # Access model field values via Python attributes. >>> q.question_text "What's new?" >>> q.pub_date datetime.datetime(2012, 2, 26, 13, 0, 0, 775217, tzinfo=datetime.UTC) [4ef2867a]
- # And vice versa: Question objects get access to Choice objects. >>> q.choice_set.all() <QuerySet [<Choice: Not much>, <Choice: The sky>, <Choice: Just hacking again>]> >>> q.choice_set.count() 3 [b2a18ce9]
- # Change values by changing the attributes, then calling save(). >>> q.question_text = "What's up?" >>> q.save() [6e795705]
- # Choice objects have API access to their related Question objects. >>> c.question <Question: What's up?> [44a99dc7]
- # Create a new Question. # Support for time zones is enabled in the default settings file, so # Django expects a datetime with tzinfo for pub_date. Use timezone.now() # instead of datetime.datetime.now() and it will do the right thing. >>> from django.utils import timezone >>> q = Question(question_text="What's new?", pub_date=timezone.now()) [9d435290]
- # Create three choices. >>> q.choice_set.create(choice_text="Not much", votes=0) <Choice: Not much> >>> q.choice_set.create(choice_text="The sky", votes=0) <Choice: The sky> >>> c = q.choice_set.create(choice_text="Just hacking again", votes=0) [1274df34]
- # Display any choices from the related object set -- none so far. >>> q.choice_set.all() <QuerySet []> [278dc9ed]
- # Django provides a rich database lookup API that's entirely driven by # keyword arguments. >>> Question.objects.filter(id=1) <QuerySet [<Question: What's up?>]> >>> Question.objects.filter(question_text__startswith="What") <QuerySet [<Question: What's up?>]> [968900ba]
- # Get the question that was published this year. >>> from django.utils import timezone >>> current_year = timezone.now().year >>> Question.objects.get(pub_date__year=current_year) <Question: What's up?> [6457dee2]
- # Give the Question a couple of Choices. The create call constructs a new # Choice object, does the INSERT statement, adds the choice to the set # of available choices and returns the new Choice object. Django creates # a set (defined as "choice_set") to hold the "other side" of a ForeignKey # relation (e.g. a question's choice) which can be accessed via the API. >>> q = Question.objects.get(pk=1) [1188d9e8]
- # Let's delete one of the choices. Use delete() for that. >>> c = q.choice_set.filter(choice_text__startswith="Just hacking") >>> c.delete() [f97f0f90]
- # Lookup by a primary key is the most common case, so Django provides a # shortcut for primary-key exact lookups. # The following is identical to Question.objects.get(id=1). >>> Question.objects.get(pk=1) <Question: What's up?> [623cda48]
- # Make sure our __str__() addition worked. >>> Question.objects.all() <QuerySet [<Question: What's up?>]> [5e602203]
- # Make sure our custom method worked. >>> q = Question.objects.get(pk=1) >>> q.was_published_recently() True [bf055409]
- # No questions are in the system yet. >>> Question.objects.all() <QuerySet []> [054ac35d]
- # Now it has an ID. >>> q.id 1 [a8cbed8e]
- $ python manage.py createsuperuser [8302498608e60ebc]

## Beyond the budget

151 more facts did not fit in the budget: [07694718] [027f747b] [73fb2877] [59b8e6a2] [877585f1] [bdbd2b79172db241-2] [4896611d] [46c9a5006c713d0c-3] [dc0da2cbf091829d-4] [b379af71] [0ab0f38a] [d96ac3c9] [8e1b8972] [c6961d8f] [eff105796d7d4d6a-2] [7f202ca1] [dd48ceff] [6942b39a] [2b5bb7eb] [ce2aeee2] [c13596e9] [54704ccb] [2039e8a0] [368af50a] [14161146] [524baa14] [df692aec3f5cbbed] [13fbe7fc2a5a9c75-2] [4af926756c29efa6-7] [11a0b287] [b75c8d9ca5df7aa8] [e97cba14] [cd8b4256] [5cc969b9] [997084a2] [c986763d] [f551ee92] [4b305cf9] [a1e90b0d] [24db99a0] [c42f124a] [3946df0f] [2695cc20] [cb065274] [32da7e4e] [4593f3a6] [3d394907] [8e6204a7] [d1b50c2e] [8967f1e2] [27072d7c] [e18944c4] [50bed6e0d454902f] [50bed6e0d454902f-2] [50bed6e0d454902f-3] [dbb2ef17dd903b2b-3] [eaf050be34acb41d-7] [eaf050be34acb41d-8] [bf67fa15468f979f] [20257edb57d397a8] [ce20b11c82955ef6] [3a9340cd0d877339-13] [3a9340cd0d877339-14] [3a9340cd0d877339-15] [3a9340cd0d877339-16] [7714e199aac2701e-71] [7714e199aac2701e-72] [7714e199aac2701e-73] [7714e199aac2701e-74] [7714e199aac2701e-75] [7714e199aac2701e-76] [47ea25fc] [7575044a] [fd12fc9f] [9c127d039bb0d767] [63e9f1a2] [607c7e73] [b134712f] [34736392] [bbedd779] [e2a0588d] [3f5fa925] [31d7baa8] [09874d83] [8527badb] [4781169b] [04bf2659] [f153308b] [254281c9] [814c5b0b] [9b215853] [bcc5eee7] [59e74758] [a4fb02eb] [94052251] [1f52b52e] [5b234653] [173599bc] [1c84c1d4] [2d82d25d] [09afb45f] [0cde77cb] [55e0cf46] [c3046f92] [9dadade2] [478a13f3] [b714f8c1] [7d664cda] [22d85bab] [d31372ca] [23d34020] [55554208] [05749667] [5ded7b59] [dc4f98c9] [860f6d43] [1b535cb3] [00470e16] [c41ec076] [60cd1c68] [452a28bf] [b0d5100a] [422d9e2d] [21bf0e25] [0d266b91] [6598e22a] [fe1dd67c] [15dcbf8d] [44f41db9] [767d7d4a] [e3e6d871] [e1b88d65] [5a36e43d] [eb2b0726] [dbee1375] [f72c2bfa] [1fec4ff2] [0e48e4b7] [be59050a] [2460df54] [d9b0bcb5] [9744809b] [c24acd2e] [5cb3aeda] [924ed805] [6662cfec] [0d390413] [64ad63cf] [6e8036b1] [331fd909] [1230493b]

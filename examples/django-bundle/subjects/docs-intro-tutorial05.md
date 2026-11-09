# docs/intro/tutorial05

- Subject: docs/intro/tutorial05 (id `e6f8d77e-b477-49c7-bd1f-1d07d5207cd1`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 12 of 173
- Conflicts: 0
- Gaps: 0

## Facts

- def get_queryset(self): """ Excludes any questions that aren't published yet. """ return Question.objects.filter(pub_date__lte=timezone.now()) [f5757eee]
- def get_queryset(self): """Return the last five published questions.""" return Question.objects.order_by("-pub_date")[:5] [2f2fa3d8f383864e-2]
- def test_future_question(self): """ Questions with a pub_date in the future aren't displayed on the index page. """ create_question(question_text="Future question.", days=30) response = self.client.get(reverse("polls:index")) self.assertContains(response, "No polls are available.") self.assertQuerySetEqual(response.context["latest_question_list"], []) [61e099e5]
- def test_future_question_and_past_question(self): """ Even if both past and future questions exist, only past questions are displayed. """ question = create_question(question_text="Past question.", days=-30) create_question(question_text="Future question.", days=30) response = self.client.get(reverse("polls:index")) self.assertQuerySetEqual( response.context["latest_question_list"], [question], ) [f968d422]
- def test_past_question(self): """ Questions with a pub_date in the past are displayed on the index page. """ question = create_question(question_text="Past question.", days=-30) response = self.client.get(reverse("polls:index")) self.assertQuerySetEqual( response.context["latest_question_list"], [question], ) [995ce93a]
- def test_past_question(self): """ The detail view of a question with a pub_date in the past displays the question's text. """ past_question = create_question(question_text="Past Question.", days=-5) url = reverse("polls:detail", args=(past_question.id,)) response = self.client.get(url) self.assertContains(response, past_question.question_text) [324e54cd]
- def test_two_past_questions(self): """ The questions index page may display multiple questions. """ question1 = create_question(question_text="Past question 1.", days=-30) question2 = create_question(question_text="Past question 2.", days=-5) response = self.client.get(reverse("polls:index")) self.assertQuerySetEqual( response.context["latest_question_list"], [question2, question1], ) [80162869]
- $ python manage.py shell [dc0da2cbf091829d-5]
- $ python manage.py test polls [58c2b5d7]
- ---------------------------------------------------------------------- Ran 1 test in 0.001s [ae40ecc3]
- >>> # get a response from '/' >>> response = client.get("/") Not Found: / >>> # we should expect a 404 from that address; if you instead see an >>> # "Invalid HTTP_HOST header" error and a 400 response, you probably >>> # omitted the setup_test_environment() call described earlier. >>> response.status_code 404 >>> # on the other hand we should expect to find something at '/polls/' >>> # we'll use 'reverse()' rather than a hardcoded URL >>> from django.urls import reverse >>> response = client.get(reverse("polls:index")) >>> response.status_code 200 >>> response.content b'\n <ul>\n \n <li><a href="/polls/1/">What&#x27;s up?</a></li>\n \n </ul>\n\n' >>> response.context["latest_question_list"] <QuerySet [<Question: What's up?>]> [05601858]
- >>> from django.test import Client >>> # create an instance of the client for our use >>> client = Client() [7d089887]

## Beyond the budget

153 more facts did not fit in the budget: [8d87d4c0] [1e7ffdef] [b248a034] [0d24be93] [0ef6813d] [707b79e7] [eff105796d7d4d6a-5] [6e486d98] [f12c735e] [b38d1651ebe8413e-2] [76b2e1c7] [b38e603c] [40133125] [f3b60fae] [6d3d9db0] [fb369a2d] [311a5b4f] [0e3c63c0] [df692aec3f5cbbed-7] [d85af63d] [cab390ceec62b73f] [be1864a7] [b75c8d9ca5df7aa8-2] [d03c6484] [8941a591] [b2fbc0bf] [75ab3c82] [52a67ab8] [8ad9f8f5] [dd5b2a65] [0c23dc9d] [b2812491] [d1bc5178] [0758b225] [dbb2ef17dd903b2b-6] [eaf050be34acb41d-10] [eaf050be34acb41d-11] [eaf050be34acb41d-12] [eaf050be34acb41d-13] [fccd37de02dbdecc-4] [ce20b11c82955ef6-4] [f6fe084f1479e5db] [d59bf1960628576c-11] [8aa7203c166b13be-74] [7714e199aac2701e-77] [7714e199aac2701e-78] [7714e199aac2701e-79] [0d836b6e] [958b64b6] [fdbdbe76] [af144f7d] [b2232ba1] [7cbe66fd] [29d87afd] [794eda83] [9184c85e] [07de14d9] [99058742] [7aeb6f6a] [3ec8d397] [ab776c86] [f3b81e31] [8077a923] [d47ff43c] [d12d69f7] [afa4d482] [573989ad] [0733c0dd] [2ddd8e25] [05abd4f5] [a4396e5b] [c936c5f3] [9395c748] [934d704f] [05254100] [350bb492] [391c472e] [dfd6787f] [ec50a3a8] [4fe09dd1] [dcf2d6b3] [19d34a21] [425987ca] [7b14e902] [949e06a5] [a398d67e] [59158ffe] [dc0ee2d5] [efce08c2] [dc20df5d] [1381c1a8] [49f3341d] [92089dc9] [adbe1ebc] [f6454533] [0e1dadb93d50ca4b-2] [8ed98782] [3b491bb9] [366f9969] [fb548c44] [d793eb23] [65960a58] [1053eb08] [522d9c36] [7bd93c99] [13dbe6bb] [9833787e] [7f39f68d] [517eaaa7] [de998001] [54cfeb47] [a3a471ef] [c9bbbf0a] [41002543] [1db3619c] [2a151c96] [5989f216] [fb2a63db] [bd9011a8] [48000462] [caaa5261] [28ca8afd] [8a3e40b6] [11ff77c0] [d907cbc6] [963ca205] [b9b7ae76] [38ce4870] [f36e0a6b] [ce2f7205] [2935ce3b] [a39696c3] [13c17313] [bf5eb2d3] [953cf99f] [7e7beafe] [772ceab8a391e4de] [adc1eee3] [1079831b] [b25711ef] [1c4f20fa] [959dd6d7] [15f94ddc] [9f3f7583] [5b3d6f2b] [4bf640e6] [99feb585] [195ea213] [0b4850be] [1b1e979c] [9755ff32] [96ce0681] [be236052]

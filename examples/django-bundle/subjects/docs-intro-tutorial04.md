# docs/intro/tutorial04

- Subject: docs/intro/tutorial04 (id `bf78755e-abd4-4062-b377-56c3aaa496d0`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 16 of 79
- Conflicts: 0
- Gaps: 0

## Facts

- def get_queryset(self): """Return the last five published questions.""" return Question.objects.order_by("-pub_date")[:5] [2f2fa3d8f383864e]
- "/polls/3/results/" [9882c0a6]
- # ... def vote(request, question_id): question = get_object_or_404(Question, pk=question_id) try: selected_choice = question.choice_set.get(pk=request.POST["choice"]) except (KeyError, Choice.DoesNotExist): # Redisplay the question voting form. return render( request, "polls/detail.html", { "question": question, "error_message": "You didn't select a choice.", }, ) else: selected_choice.votes = F("votes") + 1 selected_choice.save() # Always return an HttpResponseRedirect after successfully dealing # with POST data. This prevents data from being posted twice if a # user hits the Back button. return HttpResponseRedirect(reverse("polls:results", args=(question.id,))) [c09324b6]
- <a href="{% url 'polls:detail' question.id %}">Vote again?</a> [52536bb7]
- <form action="{% url 'polls:vote' question.id %}" method="post"> {% csrf_token %} <fieldset> <legend><h1>{{ question.question_text }}</h1></legend> {% if error_message %}<p><strong>{{ error_message }}</strong></p>{% endif %} {% for choice in question.choice_set.all %} <input type="radio" name="choice" id="choice{{ forloop.counter }}" value="{{ choice.id }}"> <label for="choice{{ forloop.counter }}">{{ choice.choice_text }}</label><br> {% endfor %} </fieldset> <input type="submit" value="Vote"> </form> [17a5aa2a]
- <h1>{{ question.question_text }}</h1> [bd3c6277]
- <ul> {% for choice in question.choice_set.all %} <li>{{ choice.choice_text }} -- {{ choice.votes }} vote{{ choice.votes|pluralize }}</li> {% endfor %} </ul> [18afe120]
- Generally, when writing a Django app, you'll evaluate whether generic views are a good fit for your problem, and you'll use them from the beginning, rather than refactoring your code halfway through. But this tutorial intentionally has focused on writing the views "the hard way" until now, to focus on core concepts. [e98431b2]
- If you're having trouble going through this tutorial, please head over to the :doc:`Getting Help</faq/help>` section of the FAQ. [eff105796d7d4d6a-4]
- You should know basic math before you start using a calculator. [a646edc1]
- app_name = "polls" urlpatterns = [ path("", views.IndexView.as_view(), name="index"), path("<int:pk>/", views.DetailView.as_view(), name="detail"), path("<int:pk>/results/", views.ResultsView.as_view(), name="results"), path("<int:question_id>/vote/", views.vote, name="vote"), ] [0ffa653a]
- class DetailView(generic.DetailView): model = Question template_name = "polls/detail.html" [ca6f2c0e]
- class IndexView(generic.ListView): template_name = "polls/index.html" context_object_name = "latest_question_list" [b38d1651ebe8413e]
- class ResultsView(generic.DetailView): model = Question template_name = "polls/results.html" [b7ce16df]
- def results(request, question_id): question = get_object_or_404(Question, pk=question_id) return render(request, "polls/results.html", {"question": question}) [f3183b06]
- def vote(request, question_id): # same as above, no changes needed. ... [bad04222]

## Beyond the budget

59 more facts did not fit in the budget: [c00926fe3424edad-5] [5fac61bb1ff3fe06] [a7f0126f] [bb1d04f0] [02eea688fdf57895-2] [c537d1941a7e3025-5] [a446e32e] [f9164c4a] [c5b568fb] [5bbe2dd2] [6180c78d] [cafb7eb6] [1aa548c4] [a252cf89] [dac2f965] [031f906e] [8c3022ae] [28ca62ef] [b38cf279] [dd32dbfa] [1684e3b2] [ee1aeaab] [dbb2ef17dd903b2b-5] [f75be361] [5a286ce802025afd-3] [fab8424b] [5c9a4d2d821e33d5-4] [d59bf1960628576c-8] [c111bf0d] [7972f593] [4f558dfa] [84578d25] [270aa016] [13cef5e1] [ad09c515] [9e3b9e4c] [87869a89] [b652405c] [b19482e4] [e782e3c9] [6c413ebb] [b0ad8bd2] [35d44af5] [82cb5805] [e0f75f4d] [092c8371] [06821733] [27b1faa3] [1e01611a] [dfdbe169] [e292f1b2] [a487d261] [abb5f213] [18184efa] [26429932] [bfa6710a] [ef82d9ae] [b6990d0b] [fcf055b0]

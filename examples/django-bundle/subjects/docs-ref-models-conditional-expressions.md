# docs/ref/models/conditional-expressions

- Subject: docs/ref/models/conditional-expressions (id `5c36046b-7ad7-406b-9e89-f969379f48ce`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 9 of 58
- Conflicts: 0
- Gaps: 0

## Facts

- >>> When(then__exact=0, then=1) >>> When(Q(then=0), then=1) [97213297]
- .. code-block:: pycon [eaf050be34acb41d-350]
- >>> >>> from datetime import date, timedelta >>> from django.db.models import Case, Value, When >>> Client.objects.create( ... name="Jane Doe", ... account_type=Client.REGULAR, ... registered_on=date.today() - timedelta(days=36), ... ) >>> Client.objects.create( ... name="James Smith", ... account_type=Client.GOLD, ... registered_on=date.today() - timedelta(days=5), ... ) >>> Client.objects.create( ... name="Jack Black", ... account_type=Client.PLATINUM, ... registered_on=date.today() - timedelta(days=10 * 365), ... ) >>> # Get the discount for each Client based on the account type >>> Client.objects.annotate( ... discount=Case( ... When(account_type=Client.GOLD, then=Value("5%")), ... When(account_type=Client.PLATINUM, then=Value("10%")), ... default=Value("0%"), ... ), ... ).values_list("name", "discount") <QuerySet [('Jane Doe', '0%'), ('James Smith', '5%'), ('Jack Black', '10%')]> [cfea5afe]
- >>> # Create some more Clients first so we can have something to count >>> Client.objects.create( ... name="Jean Grey", account_type=Client.REGULAR, registered_on=date.today() ... ) >>> Client.objects.create( ... name="James Bond", account_type=Client.PLATINUM, registered_on=date.today() ... ) >>> Client.objects.create( ... name="Jane Porter", account_type=Client.PLATINUM, registered_on=date.today() ... ) >>> # Get counts for each value of account_type >>> from django.db.models import Count >>> Client.objects.aggregate( ... regular=Count("pk", filter=Q(account_type=Client.REGULAR)), ... gold=Count("pk", filter=Q(account_type=Client.GOLD)), ... platinum=Count("pk", filter=Q(account_type=Client.PLATINUM)), ... ) {'regular': 2, 'gold': 1, 'platinum': 3} [e1178519]
- >>> a_month_ago = date.today() - timedelta(days=30) >>> a_year_ago = date.today() - timedelta(days=365) >>> # Get the discount for each Client based on the registration date >>> Client.objects.annotate( ... discount=Case( ... When(registered_on__lte=a_year_ago, then=Value("10%")), ... When(registered_on__lte=a_month_ago, then=Value("5%")), ... default=Value("0%"), ... ) ... ).values_list("name", "discount") <QuerySet [('Jane Doe', '5%'), ('James Smith', '0%'), ('Jack Black', '10%')]> [1da38c2f]
- >>> a_month_ago = date.today() - timedelta(days=30) >>> a_year_ago = date.today() - timedelta(days=365) >>> # Update the account_type for each Client from the registration date >>> Client.objects.update( ... account_type=Case( ... When(registered_on__lte=a_year_ago, then=Value(Client.PLATINUM)), ... When(registered_on__lte=a_month_ago, then=Value(Client.GOLD)), ... default=Value(Client.REGULAR), ... ), ... ) >>> Client.objects.values_list("name", "account_type") <QuerySet [('Jane Doe', 'G'), ('James Smith', 'R'), ('Jack Black', 'P')]> [6de7b8d2]
- >>> a_month_ago = date.today() - timedelta(days=30) >>> a_year_ago = date.today() - timedelta(days=365) >>> Client.objects.filter( ... registered_on__lte=Case( ... When(account_type=Client.GOLD, then=a_month_ago), ... When(account_type=Client.PLATINUM, then=a_year_ago), ... ), ... ).values_list("name", "account_type") <QuerySet [('Jack Black', 'P')]> [ad84f3a0]
- from django.db import models [4af926756c29efa6-17]
- .. _conditional-aggregation: [e51d85d0]

## Beyond the budget

49 more facts did not fit in the budget: [744d8070] [9d3f32b7] [f7af092c] [e4b98caf] [a2ec19c3] [34caab8e] [780c31f4] [9b91a60e] [795090b6] [483e3ebe] [eaf050be34acb41d-351] [eaf050be34acb41d-352] [eaf050be34acb41d-353] [eaf050be34acb41d-354] [eaf050be34acb41d-355] [eaf050be34acb41d-356] [eaf050be34acb41d-357] [0ee73173f492412a-28] [0ee73173f492412a-29] [0ee73173f492412a-30] [e4d958b020902249] [942ae6c11625c81c-100] [942ae6c11625c81c-101] [62fa3f73] [3658d5f0] [1e77e03d] [bc0309c3] [07f1fe36] [27d22988] [415c8436] [dab12d4c] [ec7b37c5] [df4495a1] [8429157b] [a4f69d058049da89] [98700f19] [3df8c9f3] [6ad3322f] [c5d19d6b728490f9-2] [8d950e11] [a2ffd59f] [f4306af9] [5df547d7] [947bf61e] [13cef096] [16a44c6a] [871ee235] [c85bda26] [1e60f037]

# docs/ref/contrib/humanize

- Subject: docs/ref/contrib/humanize (id `ba775681-0da2-4863-b45b-bcfd560c0235`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 20 of 42
- Conflicts: 0
- Gaps: 0

## Facts

- * ``1000000`` becomes ``'1,0 Million'``. * ``1200000`` becomes ``'1,2 Millionen'``. * ``1200000000`` becomes ``'1,2 Milliarden'``. * ``-1200000000`` becomes ``'-1,2 Milliarden'``. [ccb4cfea]
- * ``1000000`` becomes ``1.0 million``. * ``1200000`` becomes ``1.2 million``. * ``1200000000`` becomes ``1.2 billion``. * ``-1200000000`` becomes ``-1.2 billion``. [e1fcb2a6]
- * ``16 Feb 2007`` becomes ``yesterday``. * ``17 Feb 2007`` becomes ``today``. * ``18 Feb 2007`` becomes ``tomorrow``. * Any other day is formatted according to given argument or the :setting:`DATE_FORMAT` setting if no argument is given. [940c922e]
- * ``17 Feb 2007 16:30:00`` becomes ``now``. * ``17 Feb 2007 16:29:31`` becomes ``29 seconds ago``. * ``17 Feb 2007 16:29:00`` becomes ``a minute ago``. * ``17 Feb 2007 16:25:35`` becomes ``4 minutes ago``. * ``17 Feb 2007 15:30:29`` becomes ``59 minutes ago``. * ``17 Feb 2007 15:30:01`` becomes ``59 minutes ago``. * ``17 Feb 2007 15:30:00`` becomes ``an hour ago``. * ``17 Feb 2007 13:31:29`` becomes ``2 hours ago``. * ``16 Feb 2007 13:31:29`` becomes ``1 day, 2 hours ago``. * ``16 Feb 2007 13:30:01`` becomes ``1 day, 2 hours ago``. * ``16 Feb 2007 13:30:00`` becomes ``1 day, 3 hours ago``. * ``17 Feb 2007 16:30:30`` becomes ``30 seconds from now``. * ``17 Feb 2007 16:30:29`` becomes ``29 seconds from now``. * ``17 Feb 2007 16:31:00`` becomes ``a minute from now``. * ``17 Feb 2007 16:34:35`` becomes ``4 minutes from now``. * ``17 Feb 2007 17:30:29`` becomes ``an hour from now``. * ``17 Feb 2007 18:31:29`` becomes ``2 hours from now``. * ``18 Feb 2007 16:31:29`` becomes ``1 day from now``. * ``26 Feb 2007 18:31:29`` becomes ``1 week, 2 days from now``. [8d224e6f]
- * ``1`` becomes ``1st``. * ``2`` becomes ``2nd``. * ``3`` becomes ``3rd``. [a6f2295a]
- * ``1`` becomes ``one``. * ``2`` becomes ``two``. * ``10`` becomes ``10``. [23a3ef4a]
- * ``45000`` becomes ``'45.000'``. * ``450000`` becomes ``'450.000'``. [b6b7a484]
- * ``4500`` becomes ``4,500``. * ``4500.2`` becomes ``4,500.2``. * ``45000`` becomes ``45,000``. * ``450000`` becomes ``450,000``. * ``4500000`` becomes ``4,500,000``. [bf2f98fa]
- **Argument:** Date formatting string as described in the :tfilter:`date` tag. [08fe95dd]
- .. module:: django.contrib.humanize :synopsis: A set of Django template filters useful for adding a "human touch" to data. [142987a4]
- .. templatefilter:: apnumber [c0d63d36]
- .. templatefilter:: intcomma [306a7fa8]
- .. templatefilter:: intword [2ee07b3c]
- .. templatefilter:: naturalday [a1dc1f91]
- .. templatefilter:: naturaltime [b989c512]
- .. templatefilter:: ordinal [a34ddf16]
- :doc:`/topics/i18n/formatting` will be respected if enabled, e.g. with the ``'de'`` language: [bef8f040cb0ee6d7]
- =========================== ``django.contrib.humanize`` =========================== [fbf49b71]
- A set of Django template filters useful for adding a "human touch" to data. [dde959badf9b03bb]
- Converts an integer to its ordinal as a string. [cc7ac622]

## Beyond the budget

21 more facts did not fit in the budget: [fe6a8a3f] [77aa403c] [87c8ee5a] [fc0f7135] [12678636d153d030] [12678636d153d030-2] [12678636d153d030-3] [12678636d153d030-4] [a44db05b] [1ec9ddff] [7a795a6a] [f175d9cf] [60fba40c] [ead1ec1f] [332b5964] [67ce23ad] [fc111c88] [17c66613] [7304e082] [81b213df] [b2694f0f]

# docs/ref/contrib/humanize

- Subject: docs/ref/contrib/humanize (id `4342d6ae-a73e-473b-b999-db0644ff19f4`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 1578 tokens
- Facts shown: 42 facts
- Conflicts: 0
- Gaps: 0

## Highlights

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
- :doc:`/topics/i18n/formatting` will be respected if enabled, e.g. with the ``'de'`` language: [bef8f040cb0ee6d7-2]
- =========================== ``django.contrib.humanize`` =========================== [fbf49b71]
- Converts an integer to its ordinal as a string. [cc7ac622]

## All facts

- [dde959badf9b03bb] A set of Django template filters useful for adding a "human touch" to data.
- [fe6a8a3f] Converts a large integer (or a string representation of an integer) to a friendly text representation. Translates ``1.0`` as a singular phrase and all other numeric values as plural, this may be incorrect for some languages. Works best for numbers over 1 million.
- [77aa403c] Converts an integer or float (or a string representation of either) to a string containing commas every three digits.
- [87c8ee5a] Examples (when 'now' is 17 Feb 2007 16:30:00):
- [fc0f7135] Examples (when 'today' is 17 Feb 2007):
- [12678636d153d030] Examples:
- [12678636d153d030-2] Examples:
- [12678636d153d030-3] Examples:
- [12678636d153d030-4] Examples:
- [a44db05b] For dates that are the current day or within one day, return "today", "tomorrow" or "yesterday", as appropriate. Otherwise, format the date using the passed in format string.
- [1ec9ddff] For datetime values, returns a string representing how many seconds, minutes or hours ago it was -- falling back to the :tfilter:`timesince` format if the value is more than a day old. In case the datetime value is in the future the return value will automatically use an appropriate phrase.
- [7a795a6a] For numbers 1-9, returns the number spelled out. Otherwise, returns the number. This follows Associated Press style.
- [f175d9cf] To activate these filters, add ``'django.contrib.humanize'`` to your :setting:`INSTALLED_APPS` setting. Once you've done that, use ``{% load humanize %}`` in a template, and you'll have access to the following filters.
- [60fba40c] Values up to 10^100 (Googol) are supported.
- [ead1ec1f] You can pass in either an integer or a string representation of an integer.
- [332b5964] You can pass in either an integer or a string representation of an integer. Negative integers are returned unchanged.
- [67ce23ad] ``apnumber`` ============
- [fc111c88] ``intcomma`` ============
- [17c66613] ``intword`` ===========
- [7304e082] ``naturalday`` ==============
- [81b213df] ``naturaltime`` ===============
- [b2694f0f] ``ordinal`` ===========

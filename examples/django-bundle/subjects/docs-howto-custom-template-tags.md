# docs/howto/custom-template-tags

- Subject: docs/howto/custom-template-tags (id `2cd5054e-e758-4e7f-a980-4df627c9ed0e`)
- Kind: subject
- Budget: 1200 tokens
- Used: 895 tokens
- Facts shown: 24 of 346
- Conflicts: 0
- Gaps: 0

## Facts

- @register.filter(needs_autoescape=True) def urlize_and_linebreaks(text, autoescape=True): return linebreaksbr(urlize(text, autoescape=autoescape), autoescape=autoescape) [184760f7]
- def render(self, context): context["current_time"] = datetime.datetime.now().strftime(self.format_string) return "" [873e665d]
- def render(self, context): context[self.var_name] = datetime.datetime.now().strftime(self.format_string) return "" [1f9a4283]
- def render(self, context): if self not in context.render_context: context.render_context[self] = itertools.cycle(self.cyclevars) cycle_iter = context.render_context[self] return next(cycle_iter) [e901cc44]
- def render(self, context): output = self.nodelist.render(context) return output.upper() [adda9261]
- def render(self, context): return datetime.datetime.now().strftime(self.format_string) [214d4712]
- def render(self, context): return next(self.cycle_iter) [9b109f30]
- def render(self, context): try: actual_date = self.date_to_be_formatted.resolve(context) return actual_date.strftime(self.format_string) except template.VariableDoesNotExist: return "" [1070da6f]
- from django.template.defaultfilters import linebreaksbr, urlize [bc55272b]
- {{ comment|urlize_and_linebreaks }} [e3690341]
- {{ comment|urlize|linebreaksbr }} [240e5434]
- @register.filter(is_safe=True) def add_xx(value): return "%sxx" % value [337ce23a]
- @register.filter(is_safe=True) def myfilter(value): return value [8982e12a]
- @register.filter(needs_autoescape=True) def initial_letter_filter(text, autoescape=True): first, other = text[0], text[1:] if autoescape: esc = conditional_escape else: esc = lambda x: x result = "<strong>%s</strong>%s" % (esc(first), esc(other)) return mark_safe(result) [efcefc85]
- from django import template from django.utils.html import conditional_escape from django.utils.safestring import mark_safe [963e669d]
- from django.utils.safestring import SafeString [69f43b8c]
- if isinstance(value, SafeString): # Do something with the "safe" string. ... [37981d81]
- register = template.Library() [9d8da1aa6b2ee980]
- {% msgbox level="error" %} Please fix all errors. Further documentation can be found at <a href="http://example.com">Docs</a>. {% endmsgbox %} [24214d5c]
- {% msgbox level="info" %} More information at: <a href="http://othersite.com">Other Site</a>/ {% endmsgbox %} [b7082bf7]
- # Here, register is a django.template.Library instance, as before @register.inclusion_tag("results.html") def show_results(poll): ... [8e2f0c6c]
- .. code-block:: html+django [685d15dfb6eb2285-6]
- <div class="msgbox error"> <details open> <summary> <strong>Error</strong>: Please read for <i>Important Site</i> </summary> <p> Please fix all errors. Further documentation can be found at <a href="http://example.com">Docs</a>. </p> </details> </div> [ce581276]
- <p>The time is {% current_time "%Y-%m-%d %I:%M %p" %}.</p> [2b5073e3]

## Beyond the budget

292 more facts did not fit in the budget: [2057be9b] [3cb5cbfc] [383c1753] [99a99b54] [73069cb4] [5550b406] [af216c8e] [39ac202c] [ce6805ba] [6d999a1d] [d517255a] [0470d5e7] [943dfae2] [80f9f0f767ae3f52] [a88b2678] [748b9e1f] [9f88db80] [84638ed3] [f034a02b] [8d14170c] [b3488630] [ea00bffa] [e4171e19] [6aba4908] [2ccbefad] [9b8013e9] [aa043a50] [c5d69a2e] [b02e30e7] [575fe061] [8c7bf64a] [dc79f45a] [3d3a74c4] [63debf70] [f519ea31] [3c404b92] [bc8afed5] [f8657e88] [f0c4cf19] [87e4fdbe] [1155bb01] [6349f0dc] [73246b25] [741e5e42] [e5b094db] [e24ed9fe] [0bd380f6] [3deaed8dc7b0ec22] [184adb68] [8fb6bc67] [92288e9d] [f3bb80f2b2fd7f5d] [fcdb468c] [290c2f3b] [2c05df5540b201db] [f362afda] [90f4387cea1dbdff-2] [6df3cb3b] [9d8da1aa6b2ee980-2] [9d8da1aa6b2ee980-3] [9d8da1aa6b2ee980-4] [9d8da1aa6b2ee980-5] [9d8da1aa6b2ee980-6] [611918c0] [6df81dd8] [a923a258] [26106dd0] [49e48010] [3d4c4e5442e939f4] [1bf138ca] [d665f743] [c3bd3a6e] [27937693bf26c47c] [0a6c70ed0cb3c3fb] [097eb6936783c2dc] [946fb553] [bb83f242] [62c4fefd] [005618072ec479e9] [87b96041] [6a46f0b6] [e324ef04] [91a373a9] [37d9c8e5] [50a61833] [ec0c1fb5] [959e8002] [aa30fb24] [a4c75735] [926fc1fa] [e542062f] [6b071196] [3709cc28] [772d0d6b] [11c00c99] [cd6d9bb3] [095e599d] [238da046] [93d75d0f] [35905d3e] [a935ed3a] [ce0e02c2] [8a7f578e] [8d0a9960] [259897c0] [24e64aff] [e94f4362] [1bc329e1] [d7a28b0f] [55c37311] [fd94de42] [0252f435] [65e994d2] [9223f89e] [eead8cc5] [557fcacd] [81b23d40] [4bcfd6df] [a75807f0] [323823a0] [93c1275e] [b6245e82] [5c6de003] [4ab99508] [27a2862b] [6aeec3ab63d3bfd4] [9c877a17] [5dbed0de] [f1634b861a77cfdb] [f1634b861a77cfdb-2] [338a2db4] [d2229886] [fcc91ef0] [3a9340cd0d877339-3] [b35d0e0d] [44a02404] [9a6e8f43] [0651684b] [63d704bd] [f16440bf] [ec92c705] [ec5758e8] [051abfad] [fa0dafbb] [fcb863df] [03e86715] [3aa9a8bf] [64d6a238] [2b1c6bb5] [ed3c492c] [219eb2b5] [99a8a0b3] [91f5ef6d] [187f4697] [511a5486] [812e1ecb] [32ed4014] [345027cd] [f985cb33] [f9217b6e] [47af3f15] [c6834c3e] [b4c9a917] [1763ed0f] [86231a46] [5c307092] [5b07df2c] [a7b2b553] [708a9493] [a1207b8b] [f19dede1] [bdd62717] [85520af6] [ca45a70f] [eada2178] [cf108d66] [87c59f1c] [2a03ee9c] [67a829a7] [34f20468] [e3ee0e6a] [b0f71c5b] [af57aa20] [74979df8] [5e6ab174] [571e563d] [008c95d0] [cde48e53] [6de6eb35] [0543e1d1] [b34ca8d6] [cb241b2e] [8ec959c4] [65f986e1] [b7758621] [b471b1e6] [dd314713] [af6f4181] [79d69167] [c5a736e1] [c1cd332f] [6cea264b] [ac0a554d] [83ab8dc8] [9aeb710a] [196b5054] [fc2a7897] [7aa391e7] [94618c81] [071459cc] [bc312158] [a62e0eb9] [cb32d182] [b59a815d] [759ca593] [f7782ed4] [1f3b1259] [bf142e70bdb63e9c] [bf142e70bdb63e9c-2] [71a62af8] [1fcf4d31] [bdcfac1d] [a8fabeb8] [9630fa16] [559d44d1] [79471320] [f2c554ef] [63c655ec] [47c5f7eb] [6dc0da48] [4f5306a3] [9dc1a4a1] [bd92ad73] [ac617754] [2ec01f3d] [c370503c] [7d8eff6d] [740af104] [1ae6f56c] [8f0f12d3] [f8739479] [15dbe47a] [bc138e11] [1e0e729f] [02d2eb3f] [001a00d8] [e2e6c673] [a4ced5e0] [fd8d8abc] [53967bbd] [4b8ffbb6] [5370eaeb] [4622e549] [58f94919] [ead032fa] [1b8c9b4ee56a5042] [114289fa] [86c0c4f5] [d5722523] [a8632a9c] [f577ed84] [23b75616] [372a481c] [6a8cee61] [a6feb080] [95fdd89c] [c7048088] [e20be081] [f2011ed1] [29888663] [c6057030] [69f560bf] [ed61add7b30c480a] [23210d97] [23b0f054] [e96cd90c] [94c2c24e] [e63a46b3] [6c44e5a5] [dce28fba] [1e0528ad] [67329472] [c35a4f32] [861d5041] [b5180a66] [267e8661] [666e822a] [ab110437] [7b42de99] [d475ddfa] [dba6cb23] [5df2187d]

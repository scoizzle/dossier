# Several agents, one store

How agents share a Dossier store, what the store guarantees them, and what it does not. Back to the [README](../README.md).

## The short version

A store shared by several agents has to answer questions a single agent's notes never raise: who wrote this, is it still the current claim, does anyone dispute it, was the thing I built on changed since, and what did the others write while I was away. Dossier answers each from the facts and refs already in the store, with no model in the loop, and says plainly where it has no answer yet.

## The loop for a shared store

This extends the loop in [`skills/dossier/SKILL.md`](../skills/dossier/SKILL.md).

1. **Take a cursor.** `dossier changes --last 1` (MCP `changes` with `last: 1`) and keep `next`. Do it before you read, so the cursor is never ahead of what you saw.
2. **Orient.** `dossier check --subject <name>` and `dossier dossier compile --subject <name>`. Keep the fact ids you rely on.
3. **Post with your inputs declared.** When a fact is a conclusion from other facts, give it `derived_from` refs of kind `fact` to exactly those facts. When you disagree with a fact and cannot settle it, post your observation with a `refutes` or `contradicts` ref of kind `fact` to it. When you know a fact is wrong, post the right claim with a `supersedes` ref of kind `fact` to it: the old fact is kept as history and no longer returned. Give durable attributes a `key`, so every agent that posts the same claim converges on one row.
4. **Verify before you act.** `dossier verify <id>...` (MCP `verify_facts`) on the ids your plan, summary or answer cites. Act only when `current` is true; otherwise read `why`, re-read the replacement and redo the step. `dossier verify --require-current <ids> && <command>` makes that a gate in a script.
5. **Catch up from the cursor.** `dossier changes --since <cursor> --subject <name>` lists what was written since. `reset: true` means the cursor fell outside the retained window: re-read everything.

You do not have to call `verify` to see the label: every search hit, compiled fact and `show` reports the same derived status, and `search --status live` leaves out what is stale or contested. `verify` is the one that takes the ids you already hold and gives the reason for each.

The journal and `verify` do different jobs. The journal records row writes, so it tells you that a subject changed. It has no row for a fact that became stale because its input was superseded, since that fact's row was never touched. `changes` says when to look again; `verify` says what is still true.

## What a shared store owes its agents

Recent work on agent memory names the ways a store shared by several agents fails. Each row is one of them, what Dossier does about it, and where it is measured. "Fleet evaluation" is the table in [evaluation](evaluation.md#fleet-evaluation).

| Failure | Named by | What Dossier does | Measured |
| --- | --- | --- | --- |
| **Provenance collapse**: a retrieved fact cannot be traced to its writer or source. | *Governed Shared Memory for Multi-Agent LLM Systems* (arXiv:2606.24535) | Every fact keeps its actor, channel and time; every ref keeps its basis; a derivation chain walks back hop by hop with `get_fact`. | Fleet evaluation, provenance rows |
| **Contradiction persistence**: conflicting facts coexist unmarked, and a near-duplicate gate rejects the very write that contradicts. | The same paper, which found a dedup gate pre-empting its contradiction detector | Dedupe is by exact content hash, so "X is A" never swallows "X is B". Disagreeing `data` is listed under conflicts in every dossier, outside the budget. A declared `contradicts` or `refutes` makes the fact `contested`. | Fleet evaluation, contradiction rows |
| **Revoked but still authoritative**: a superseded fact is marked but still returned, and outranks its replacement. | *Revoked but Still Authoritative* (arXiv:2609.08258) | Superseded and retracted facts are excluded from search and compile unless asked for by status, so they are never ranked at all. History is kept for audit: `show` returns the old row. | Fleet evaluation, supersession and revocation rows |
| **Ghost memory**: old and current values of the same thing sit in the store with nothing telling them apart. | *A-TMA* (arXiv:2607.01935); *TEPA* (arXiv:2608.07429) | A keyed repost supersedes the fact in its slot, so a slot has one live value, and a `supersedes` ref corrects any fact by id. `verify` names the fact that replaced an old id. | Fleet evaluation, supersession and correction rows |
| **Stale derivations**: an agent holds the latest input yet acts on a plan built from an older one. A freshness check misses it, because the plan's own row never changed. | *Fresh Memory, Stale Plans* (arXiv:2609.03340) | A fact names its exact inputs with `derived_from`. Every read walks them and reports `stale`, transitively: search, compile, `show` and `verify`, which also names the input that changed. Compile ranks stale facts last. | Fleet evaluation, derivation currency rows |
| **Stale propagation**: one agent's update is not seen by another. | arXiv:2606.24535; *Multi-Agent Memory from a Computer Architecture Perspective* (arXiv:2603.10062) | One store, so a committed write is visible to the next read. The journal gives each agent a cursor, a per-subject filter and an explicit `reset` when the cursor is too old. | Fleet evaluation, propagation rows |
| **Write-time distillation loses what a later question needs.** | *Mem++* (arXiv:2610.02002); *JitMem* (arXiv:2609.27334) | No model runs at write time. Facts are stored as posted and a dossier is compiled at read time for the subject and budget asked. | [evaluation](evaluation.md#measured-results) |

## Not covered

These are real gaps. None of them is hidden by the features above.

- **Scoped access.** There are no scopes, tenants or authentication. Every agent that can open the store reads all of it, and the loopback web UI has no login. Isolation today is one database file per trust boundary. The governed-memory work above treats unauthorized leakage as the first failure mode; Dossier does not address it.
- **Identity is a label.** The actor on a fact is whatever name the client sent. It is preserved exactly and it is not proof. Nothing may be gated on it.
- **Any writer can supersede any fact.** A keyed post replaces the slot's fact whoever wrote it, and a `supersedes` ref replaces any fact by id, on any subject, over MCP as well as the CLI. So any agent on a store can take any fact out of search and compile. The old row and both writers stay on record, and the overwritten value is not flagged as a disagreement (the fleet evaluation reports this as 0/200 for keyed overwrites). Work on memory poisoning (*Securing LLM-Agent Long-Term Memory Against Poisoning*, arXiv:2606.24322; *MAPLE-Guard*, arXiv:2608.00426) argues that authority has to be bound to a write's origin and that risky writes need quarantine. Trust-gated supersede is on the not-built list.
- **Echo is not corroboration.** When a second agent posts an identical fact the write is deduped and the second agent is not recorded, so the store cannot say how many agents asserted a claim, let alone whether they were independent. *GovMem* (arXiv:2607.02579) and *CPB* (arXiv:2609.30813) show that copies and paraphrases look like independent evidence and that admission cannot be made sound without lineage. Dossier keeps lineage (refs and their basis) and does not yet count support.
- **Status outside the store's own reads.** A published bundle, the change journal and the graph view carry the stored status, so a stale fact reads `live` there. A bundle holds live facts only, so staleness does not survive publish and import: the changed input is not in the bundle.
- **A re-dump revives a corrected claim.** Dedupe compares a post with live facts only, so dumping an unchanged source again creates the corrected claim anew, next to its correction (issue #25). `SupersedesRefTests` pins this as a known gap.
- **Old `supersedes` refs.** A store written before corrections took effect may hold such refs with their targets still live. Nothing repairs them on upgrade; posting the correction again applies it.
- **A write is committed belief.** There is no staging, quarantine or review state; `post --dry-run` and `check --drafts` preview a write and that is all. *MemTX* (arXiv:2607.23929) and *TARL* (arXiv:2608.03699) argue for staged writes.
- **Time.** There is no valid-time on a fact and no "as of" read; the store knows when a fact was posted and whether it has been superseded, in the manner of transaction time only (compare the bi-temporal model in *Zep*, arXiv:2501.13956).
- **Retraction over MCP.** Retract is a CLI verb. Over MCP an agent corrects a fact by reposting its key or by a `supersedes` ref; it cannot remove one.
- **What an agent does with a label.** *STALE* (arXiv:2605.06527) reports a wide gap between retrieving updated evidence and acting on it. A correct `stale` label is necessary and does not make an agent heed it; the `--require-current` gate exists for that reason.

## Design choices that follow from this

- **Derived, never stored.** `stale` and `contested` are computed from refs when asked. A stored label would need every write to find and rewrite its dependents, and would drift the first time one was missed.
- **A different claim, not a different row.** Staleness compares content hashes, so reposting the same claim (a tag change, a re-verification) does not invalidate what was built on it.
- **Exact inputs.** Only refs of kind `fact` carry staleness or a dispute. A slot ref follows whatever the slot holds now, so it cannot say which value a conclusion was built on.
- **Surface, do not delete.** A changed input makes its dependents `stale`; it does not hide or remove them. Hard-filtering facts classified as stale can reduce accuracy when the classification is wrong (*When Should LLM Agents Forget?*, arXiv:2611.17338), and the old claim is often the context a reader needs.
- **Report, do not resolve.** Dossier never picks the winner of a conflict or a dispute. It names both sides and leaves the decision to whoever can check the source.

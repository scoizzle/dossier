# Fact b6f809c8

Store id: af44a101-7552-4c05-952a-b5c7e54e466d

## Text

```text
Clicking a memo card opens the memo detail screen.
```

## Attributes

- Kind: action
- Status: live
- Confidence: 1
- Tags: `section:actions`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:20:04.9288170+00:00`

## Refs

- rel: leads_to
  - kind: subject
  - target: [Memos/MemoDetail](../../memos-memodetail/index.md)
  - basis: observed
  - confidence: none
  - locator: none
- rel: derived_from
  - kind: git
  - target: `usememos/memos/web/src/pages/Home.tsx`
  - basis: observed
  - confidence: none
  - locator: none
  - rev: `e4f3fb2d2d114f6eaea6ec75a10b0a274f57a8a1`

## Referenced by

None.

## Subject

[Memos/Home](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "af44a101-7552-4c05-952a-b5c7e54e466d",
  "kind": "action",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:20:04.9288170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "rel": "leads_to",
      "target": "Memos/MemoDetail"
    },
    {
      "basis": "observed",
      "kind": "git",
      "rel": "derived_from",
      "rev": "e4f3fb2d2d114f6eaea6ec75a10b0a274f57a8a1",
      "target": "usememos/memos/web/src/pages/Home.tsx"
    }
  ],
  "status": "live",
  "subject_id": "bdf5b7de-81c8-4130-bb3c-d4b8bdbbd4f5",
  "subject_name": "Memos/Home",
  "tags": [
    "section:actions"
  ],
  "text": "Clicking a memo card opens the memo detail screen."
}
```

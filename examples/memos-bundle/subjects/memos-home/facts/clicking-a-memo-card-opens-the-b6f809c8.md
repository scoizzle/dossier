# Fact b6f809c8

Store id: 2ec2656d-dfd1-486a-8d7d-ff79355c0e54

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
- posted_at: `2026-11-09T23:31:46.5621970+00:00`

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
  "id": "2ec2656d-dfd1-486a-8d7d-ff79355c0e54",
  "kind": "action",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:46.5621970+00:00"
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
  "subject_id": "c1a56451-1df8-4cc1-b0d4-80c0e18682e3",
  "subject_name": "Memos/Home",
  "tags": [
    "section:actions"
  ],
  "text": "Clicking a memo card opens the memo detail screen."
}
```

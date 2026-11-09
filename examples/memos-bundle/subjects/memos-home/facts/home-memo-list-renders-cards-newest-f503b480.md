# Fact f503b480

Store id: 923647b1-1cc0-47d3-bb45-ab2f486627b0

## Text

```text
Home memo list renders cards newest first in a single column.
```

## Attributes

- Kind: element
- Status: live
- Confidence: 1
- Tags: `section:list`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:46.5621970+00:00`

## Refs

- rel: contains
  - kind: fact
  - target: [3937c1bf](home-header-is-64-pixels-tall-3937c1bf.md)
  - basis: observed
  - confidence: none
  - locator: none
- rel: contains
  - kind: fact
  - target: [c98fcec9](home-composer-lets-a-user-type-c98fcec9.md)
  - basis: observed
  - confidence: none
  - locator: none
- rel: derived_from
  - kind: git
  - target: `usememos/memos/web/src/components/PagedMemoList/PagedMemoList.tsx`
  - basis: observed
  - confidence: none
  - locator: none
  - rev: `e4f3fb2d2d114f6eaea6ec75a10b0a274f57a8a1`

## Items

```json
[
  {
    "key": "card",
    "text": "Memo card with text and timestamp"
  },
  {
    "key": "pin",
    "text": "Pin badge on pinned cards"
  }
]
```

## Referenced by

None.

## Subject

[Memos/Home](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "923647b1-1cc0-47d3-bb45-ab2f486627b0",
  "items": [
    {
      "key": "card",
      "text": "Memo card with text and timestamp"
    },
    {
      "key": "pin",
      "text": "Pin badge on pinned cards"
    }
  ],
  "kind": "element",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:46.5621970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "fact",
      "rel": "contains",
      "target": "66f68924-352c-43e5-bb6c-db0a98420274"
    },
    {
      "basis": "observed",
      "kind": "fact",
      "rel": "contains",
      "target": "eb162ac3-b6e5-4c55-b797-28e1b501faa2"
    },
    {
      "basis": "observed",
      "kind": "git",
      "rel": "derived_from",
      "rev": "e4f3fb2d2d114f6eaea6ec75a10b0a274f57a8a1",
      "target": "usememos/memos/web/src/components/PagedMemoList/PagedMemoList.tsx"
    }
  ],
  "status": "live",
  "subject_id": "c1a56451-1df8-4cc1-b0d4-80c0e18682e3",
  "subject_name": "Memos/Home",
  "tags": [
    "section:list"
  ],
  "text": "Home memo list renders cards newest first in a single column."
}
```

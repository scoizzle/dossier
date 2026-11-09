# Fact f503b480

Store id: 1583550c-b2a8-4cd0-a626-584d97cfb193

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
- posted_at: `2026-11-09T23:44:32.4257550+00:00`

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
  "id": "1583550c-b2a8-4cd0-a626-584d97cfb193",
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
    "posted_at": "2026-11-09T23:44:32.4257550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "fact",
      "rel": "contains",
      "target": "b10f135c-781f-4ad1-a60f-0c94d0a831c5"
    },
    {
      "basis": "observed",
      "kind": "fact",
      "rel": "contains",
      "target": "bb07c64e-35e7-475d-adab-464cb281ffd3"
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
  "subject_id": "4dc72333-e0bf-4125-bcee-81c96c23bb0b",
  "subject_name": "Memos/Home",
  "tags": [
    "section:list"
  ],
  "text": "Home memo list renders cards newest first in a single column."
}
```

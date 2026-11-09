# Fact f503b480

Store id: ac2948e8-d962-445b-8f36-78aec3fcc72b

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
- posted_at: `2026-11-09T22:20:04.9288170+00:00`

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
  "id": "ac2948e8-d962-445b-8f36-78aec3fcc72b",
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
    "posted_at": "2026-11-09T22:20:04.9288170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "fact",
      "rel": "contains",
      "target": "bc817cbc-534b-467c-bf6e-3d0971e84ce1"
    },
    {
      "basis": "observed",
      "kind": "fact",
      "rel": "contains",
      "target": "b69bc42d-b7db-46bd-b473-b200f239630b"
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
  "subject_id": "bdf5b7de-81c8-4130-bb3c-d4b8bdbbd4f5",
  "subject_name": "Memos/Home",
  "tags": [
    "section:list"
  ],
  "text": "Home memo list renders cards newest first in a single column."
}
```

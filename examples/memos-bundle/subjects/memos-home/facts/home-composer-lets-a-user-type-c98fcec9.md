# Fact c98fcec9

Store id: b69bc42d-b7db-46bd-b473-b200f239630b

## Text

```text
Home composer lets a user type a memo, attach media, and choose visibility.
```

## Attributes

- Kind: element
- Status: live
- Confidence: 1
- Tags: `section:composer`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:20:04.9288170+00:00`

## Refs

- rel: derived_from
  - kind: git
  - target: `usememos/memos/web/src/components/MemoEditor/MemoEditor.tsx`
  - basis: observed
  - confidence: none
  - locator: none
  - rev: `e4f3fb2d2d114f6eaea6ec75a10b0a274f57a8a1`

## Items

```json
[
  {
    "key": "editor",
    "text": "Rich text area for the memo body"
  },
  {
    "key": "attach",
    "text": "Attach media button"
  },
  {
    "key": "visibility",
    "text": "Visibility selector"
  }
]
```

## Referenced by

- [f503b480](home-memo-list-renders-cards-newest-f503b480.md) (element, rel: contains)
- [b5a926c6](home-shows-a-floating-action-button-b5a926c6.md) (element, rel: mentions)
- [fb0b6c6b](home-composer-auto-saves-the-draft-while-fb0b6c6b.md) (note, rel: derived_from)
- [e1931db4](home-keeps-the-draft-in-local-e1931db4.md) (note, rel: derived_from)

## Subject

[Memos/Home](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "b69bc42d-b7db-46bd-b473-b200f239630b",
  "items": [
    {
      "key": "editor",
      "text": "Rich text area for the memo body"
    },
    {
      "key": "attach",
      "text": "Attach media button"
    },
    {
      "key": "visibility",
      "text": "Visibility selector"
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
      "kind": "git",
      "rel": "derived_from",
      "rev": "e4f3fb2d2d114f6eaea6ec75a10b0a274f57a8a1",
      "target": "usememos/memos/web/src/components/MemoEditor/MemoEditor.tsx"
    }
  ],
  "status": "live",
  "subject_id": "bdf5b7de-81c8-4130-bb3c-d4b8bdbbd4f5",
  "subject_name": "Memos/Home",
  "tags": [
    "section:composer"
  ],
  "text": "Home composer lets a user type a memo, attach media, and choose visibility."
}
```

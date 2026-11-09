# Fact c98fcec9

Store id: eb162ac3-b6e5-4c55-b797-28e1b501faa2

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
- posted_at: `2026-11-09T23:31:46.5621970+00:00`

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
  "id": "eb162ac3-b6e5-4c55-b797-28e1b501faa2",
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
    "posted_at": "2026-11-09T23:31:46.5621970+00:00"
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
  "subject_id": "c1a56451-1df8-4cc1-b0d4-80c0e18682e3",
  "subject_name": "Memos/Home",
  "tags": [
    "section:composer"
  ],
  "text": "Home composer lets a user type a memo, attach media, and choose visibility."
}
```

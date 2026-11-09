# Fact 3937c1bf

Store id: 66f68924-352c-43e5-bb6c-db0a98420274

## Text

```text
Home header is 64 pixels tall in the first audit and shows the workspace name.
```

## Attributes

- Kind: element
- Status: live
- Confidence: 1
- Tags: `section:header`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:46.5621970+00:00`

## Data

```json
{
  "headerHeight": 64
}
```

## Refs

- rel: derived_from
  - kind: git
  - target: `usememos/memos/web/src/components/AppSidebar/AppSidebar.tsx`
  - basis: observed
  - confidence: none
  - locator: none
  - rev: `e4f3fb2d2d114f6eaea6ec75a10b0a274f57a8a1`

## Referenced by

- [f503b480](home-memo-list-renders-cards-newest-f503b480.md) (element, rel: contains)

## Subject

[Memos/Home](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "headerHeight": 64
  },
  "id": "66f68924-352c-43e5-bb6c-db0a98420274",
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
      "target": "usememos/memos/web/src/components/AppSidebar/AppSidebar.tsx"
    }
  ],
  "status": "live",
  "subject_id": "c1a56451-1df8-4cc1-b0d4-80c0e18682e3",
  "subject_name": "Memos/Home",
  "tags": [
    "section:header"
  ],
  "text": "Home header is 64 pixels tall in the first audit and shows the workspace name."
}
```

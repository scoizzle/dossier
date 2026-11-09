# Fact 3937c1bf

Store id: b10f135c-781f-4ad1-a60f-0c94d0a831c5

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
- posted_at: `2026-11-09T23:44:32.4257550+00:00`

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
  "id": "b10f135c-781f-4ad1-a60f-0c94d0a831c5",
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
      "kind": "git",
      "rel": "derived_from",
      "rev": "e4f3fb2d2d114f6eaea6ec75a10b0a274f57a8a1",
      "target": "usememos/memos/web/src/components/AppSidebar/AppSidebar.tsx"
    }
  ],
  "status": "live",
  "subject_id": "4dc72333-e0bf-4125-bcee-81c96c23bb0b",
  "subject_name": "Memos/Home",
  "tags": [
    "section:header"
  ],
  "text": "Home header is 64 pixels tall in the first audit and shows the workspace name."
}
```

# Fact 54a64f2d

Store id: 6ab68d0e-8482-4ee0-a960-b4436758be6f

## Text

```text
class UUIDTextMixin
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.0995460+00:00`

## Data

```json
{
  "end_line": 797,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 781,
  "symbol": "UUIDTextMixin"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":781,"selector":"L781-L797","symbol":"UUIDTextMixin"}`

## Items

```json
[
  {
    "text": "Strip hyphens from a value when filtering a UUIDField on backends without a native datatype for UUID.",
    "locator": {
      "line": 782
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/lookups::UUIDTextMixin](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 797,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 781,
    "symbol": "UUIDTextMixin"
  },
  "id": "6ab68d0e-8482-4ee0-a960-b4436758be6f",
  "items": [
    {
      "locator": {
        "line": 782
      },
      "text": "Strip hyphens from a value when filtering a UUIDField on backends without a native datatype for UUID."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.0995460+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 781,
        "selector": "L781-L797",
        "symbol": "UUIDTextMixin"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "dee28838-2cc3-4f87-995e-4c9c747fbf23",
  "subject_name": "django/db/models/lookups::UUIDTextMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class UUIDTextMixin"
}
```

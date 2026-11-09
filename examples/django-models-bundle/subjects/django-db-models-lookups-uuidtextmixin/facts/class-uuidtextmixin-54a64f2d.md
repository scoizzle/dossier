# Fact 54a64f2d

Store id: 3721e3f9-db4b-4281-81f3-ebe218185cf9

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
- posted_at: `2026-11-09T23:32:03.4652070+00:00`

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
  "id": "3721e3f9-db4b-4281-81f3-ebe218185cf9",
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
    "posted_at": "2026-11-09T23:32:03.4652070+00:00"
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
  "subject_id": "660e3158-cf72-4101-b09b-d6e484078016",
  "subject_name": "django/db/models/lookups::UUIDTextMixin",
  "tags": [
    "entity:class"
  ],
  "text": "class UUIDTextMixin"
}
```

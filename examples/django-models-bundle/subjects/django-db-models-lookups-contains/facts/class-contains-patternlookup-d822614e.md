# Fact d822614e

Store id: 3fc0fc84-c6ed-48cd-82f0-9bdc4dc54c02

## Text

```text
class Contains(PatternLookup)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:Field.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.3572110+00:00`

## Data

```json
{
  "end_line": 627,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 625,
  "symbol": "Contains"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":625,"selector":"L625-L627","symbol":"Contains"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Contains](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 627,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 625,
    "symbol": "Contains"
  },
  "id": "3fc0fc84-c6ed-48cd-82f0-9bdc4dc54c02",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3572110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 625,
        "selector": "L625-L627",
        "symbol": "Contains"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "f329660c-cb80-4cef-892e-f650223aeaf0",
  "subject_name": "django/db/models/lookups::Contains",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class Contains(PatternLookup)"
}
```

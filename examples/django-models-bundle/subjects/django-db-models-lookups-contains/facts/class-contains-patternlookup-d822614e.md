# Fact d822614e

Store id: f0c9033c-3df8-41e8-86c6-a48d6b1985b6

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
- posted_at: `2026-11-09T22:39:48.1770340+00:00`

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
  "id": "f0c9033c-3df8-41e8-86c6-a48d6b1985b6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.1770340+00:00"
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
  "subject_id": "1e7ef2c4-20c7-413f-bc73-5cd1f2e9d329",
  "subject_name": "django/db/models/lookups::Contains",
  "tags": [
    "entity:class",
    "decorator:Field.register_lookup"
  ],
  "text": "class Contains(PatternLookup)"
}
```

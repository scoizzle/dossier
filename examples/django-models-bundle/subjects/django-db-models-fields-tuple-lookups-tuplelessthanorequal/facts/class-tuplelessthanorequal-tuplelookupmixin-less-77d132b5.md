# Fact 77d132b5

Store id: 618114c1-6c03-4ee1-9ab3-29df355e7d15

## Text

```text
class TupleLessThanOrEqual(TupleLookupMixin, LessThanOrEqual)
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
- posted_at: `2026-11-09T22:39:45.6245660+00:00`

## Data

```json
{
  "end_line": 300,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 275,
  "symbol": "TupleLessThanOrEqual"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":275,"selector":"L275-L300","symbol":"TupleLessThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLessThanOrEqual](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 300,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 275,
    "symbol": "TupleLessThanOrEqual"
  },
  "id": "618114c1-6c03-4ee1-9ab3-29df355e7d15",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6245660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 275,
        "selector": "L275-L300",
        "symbol": "TupleLessThanOrEqual"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "9290fe3f-767c-4695-ae3b-d614ecc34631",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLessThanOrEqual",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleLessThanOrEqual(TupleLookupMixin, LessThanOrEqual)"
}
```

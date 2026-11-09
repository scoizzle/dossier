# Fact e1c0e6f5

Store id: 10792277-670e-4555-940d-39e4c899653d

## Text

```text
class TupleLessThan(TupleLookupMixin, LessThan)
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
- posted_at: `2026-11-09T23:44:52.7756230+00:00`

## Data

```json
{
  "end_line": 272,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 247,
  "symbol": "TupleLessThan"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":247,"selector":"L247-L272","symbol":"TupleLessThan"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleLessThan](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 272,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 247,
    "symbol": "TupleLessThan"
  },
  "id": "10792277-670e-4555-940d-39e4c899653d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7756230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 247,
        "selector": "L247-L272",
        "symbol": "TupleLessThan"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "c3e24090-2335-4452-ab69-5364a553f576",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleLessThan",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleLessThan(TupleLookupMixin, LessThan)"
}
```

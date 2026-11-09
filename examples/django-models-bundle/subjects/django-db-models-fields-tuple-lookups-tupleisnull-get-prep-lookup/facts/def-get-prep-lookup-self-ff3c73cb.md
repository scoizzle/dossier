# Fact ff3c73cb

Store id: 6df27fcc-6a97-4f18-9982-67058e51386f

## Text

```text
def get_prep_lookup(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:45.6004480+00:00`

## Data

```json
{
  "end_line": 178,
  "entity_kind": "method",
  "parent": "TupleIsNull",
  "start_line": 170,
  "symbol": "TupleIsNull.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":170,"selector":"L170-L178","symbol":"TupleIsNull.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIsNull.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 178,
    "entity_kind": "method",
    "parent": "TupleIsNull",
    "start_line": 170,
    "symbol": "TupleIsNull.get_prep_lookup"
  },
  "id": "6df27fcc-6a97-4f18-9982-67058e51386f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6004480+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 170,
        "selector": "L170-L178",
        "symbol": "TupleIsNull.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "694a47e4-778d-4c42-a801-82a310cf53cb",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIsNull.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```

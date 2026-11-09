# Fact 168048ae

Store id: b03c68b1-8996-42e9-a686-eeb8fc394c87

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
- posted_at: `2026-11-09T22:39:45.6314750+00:00`

## Data

```json
{
  "end_line": 313,
  "entity_kind": "method",
  "parent": "TupleIn",
  "start_line": 304,
  "symbol": "TupleIn.get_prep_lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":304,"selector":"L304-L313","symbol":"TupleIn.get_prep_lookup"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleIn.get_prep_lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 313,
    "entity_kind": "method",
    "parent": "TupleIn",
    "start_line": 304,
    "symbol": "TupleIn.get_prep_lookup"
  },
  "id": "b03c68b1-8996-42e9-a686-eeb8fc394c87",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.6314750+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 304,
        "selector": "L304-L313",
        "symbol": "TupleIn.get_prep_lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "406de9e0-2bf1-4e04-a0bf-dcaec1165611",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleIn.get_prep_lookup",
  "tags": [
    "entity:method"
  ],
  "text": "def get_prep_lookup(self)"
}
```

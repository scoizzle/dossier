# Fact 9fef63ff

Store id: 8782b93e-eeb6-4230-862e-8ded1ad1c802

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T23:32:00.5306810+00:00`

## Data

```json
{
  "end_line": 36,
  "entity_kind": "method",
  "parent": "Tuple",
  "start_line": 35,
  "symbol": "Tuple.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":35,"selector":"L35-L36","symbol":"Tuple.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::Tuple.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 36,
    "entity_kind": "method",
    "parent": "Tuple",
    "start_line": 35,
    "symbol": "Tuple.__iter__"
  },
  "id": "8782b93e-eeb6-4230-862e-8ded1ad1c802",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.5306810+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 35,
        "selector": "L35-L36",
        "symbol": "Tuple.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "15222d65-18f7-4b7d-81d3-c3c1c324d94a",
  "subject_name": "django/db/models/fields/tuple_lookups::Tuple.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```

# Fact 3eda13eb

Store id: f9f48019-1039-413d-a1d5-f0b5915fb2db

## Text

```text
class TupleExact(TupleLookupMixin, Exact)
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
- posted_at: `2026-11-09T22:39:45.5932410+00:00`

## Data

```json
{
  "end_line": 166,
  "entity_kind": "class",
  "parent": "tuple_lookups",
  "start_line": 155,
  "symbol": "TupleExact"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/tuple_lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":155,"selector":"L155-L166","symbol":"TupleExact"}`

## Referenced by

None.

## Subject

[django/db/models/fields/tuple_lookups::TupleExact](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 166,
    "entity_kind": "class",
    "parent": "tuple_lookups",
    "start_line": 155,
    "symbol": "TupleExact"
  },
  "id": "f9f48019-1039-413d-a1d5-f0b5915fb2db",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.5932410+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 155,
        "selector": "L155-L166",
        "symbol": "TupleExact"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/tuple_lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "cd6db5d2-893a-4aa3-8d2c-35ed7d083785",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleExact",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleExact(TupleLookupMixin, Exact)"
}
```

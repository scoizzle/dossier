# Fact 3eda13eb

Store id: 4b51d7ea-ea00-415f-8c83-0f149c4a9acb

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
- posted_at: `2026-11-09T23:44:52.7527600+00:00`

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
  "id": "4b51d7ea-ea00-415f-8c83-0f149c4a9acb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.7527600+00:00"
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
  "subject_id": "a43d1064-120f-497b-a589-d41fdc358ea1",
  "subject_name": "django/db/models/fields/tuple_lookups::TupleExact",
  "tags": [
    "entity:class"
  ],
  "text": "class TupleExact(TupleLookupMixin, Exact)"
}
```
